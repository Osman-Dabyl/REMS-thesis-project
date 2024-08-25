using System.Diagnostics.CodeAnalysis;
using Rafat.Code.Helper;
using Rafat.Code.Models;
using Rafat.Core;
using Rafat.Data.EF;
using Rafat.Gui.LoadingGui;
using GMap.NET;
using GMap.NET.MapProviders;
using Rafat.Core.Enums;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Rafat.Gui.test;

// ReSharper disable SpecifyACultureInStringConversionExplicitly

namespace Rafat.Gui.PropertysGui
{
    public partial class AddPropertyForm : Form
    {
        private readonly IDataHelper<Property> dataHelperForProperty;
        private readonly IDataHelper<PropertyFile> dataHelperForPropertyFile;
        private readonly IDataHelper<Agent> dataHelperForAgent;
        private readonly Main main;
        private readonly int id;
        private DateTime userCreatedDate;
        private const double ZoomStep = 0.5; // Step size for zooming
#pragma warning disable IDE0052
        private readonly PropertsUserControl page;
        private readonly testuser pagelist;
#pragma warning restore IDE0052


        public AddPropertyForm(Main main, int id)
        {
            InitializeComponent();

            dataHelperForProperty = new PropertyEF();
            dataHelperForPropertyFile = new PropertyFilesEF();
            dataHelperForAgent = new AgentEF();
            page = PropertsUserControl.Instance(main);
            pagelist = testuser.Instance(main);

            this.Owner = main;
            this.main = main;
            this.id = id;

            setMap();
            LoadEnumValues();
            LoadAgents();

            if (this.id > 0)
            {
                SetDataForEdit();
            }
        }


        private bool IsValid()
        {
            if (
                txtName.Text.Length < 3 ||
                txtprice.Text.Length < 1
            )
                return false;
            return true;
        }


        private async void Add()
        {
            // Save property Logic
            var property = new Property
            {
                PropertyName = txtName.Text,
                Price = Convert.ToDecimal(txtprice.Text),
                AgentId = (int)cmpAgent.SelectedValue,
                PType = (Property_Type.PropertyType)cmbType.SelectedValue,
                Listing = (Listing_Type.ListingType)cmbListing.SelectedValue,
                Status = (Property_Stutus.PropertyStatus)cmbStatus.SelectedValue,
                Description = richTextBox1.Text,
                Latitude = float.Parse(txtLat.Text),
                Longitude = float.Parse(txtLong.Text),
                AddedDate = DateTime.Now,
                UpDatedDate = DateTime.Now,
                UserId = LocalUser.UserId
            };


            var result = await Task.Run(() => dataHelperForProperty.Add(property));

            if (result == "1")
            {
                // Success
                SystemRecordHelper.Add("Property Added", $"({property.PropertyName}) Added Successfully. ");
                // 
                ToastHelper.ShowAddToast();

                var propertyFiles = new List<PropertyFile>();

                foreach (ListViewItem item in listView1.Items)
                {
                    var filePath = item.Tag.ToString();
                    if (filePath != null)
                    {
                        var fileData = await File.ReadAllBytesAsync(filePath);
                        var fileType =
                            Path.GetExtension(filePath).ToLower() == ".jpg" ||
                            Path.GetExtension(filePath).ToLower() == ".png"
                                ? "Picture"
                                : "Document";
                        var filename = Path.GetFileName(filePath);
                        propertyFiles.Add(new PropertyFile
                        {
                            PropertyId = property.PropertyId,
                            FileName = filename,
                            FileData = fileData,
                            FileType = fileType,
                            FilePath = filePath
                        });
                    }
                }

                await using (var context = new DBContext())
                {
                    context.PropertyFiles.AddRange(propertyFiles);
                    await context.SaveChangesAsync();
                }

                page.LoadData();
                pagelist.DisplayPropertyCards();
                Close();
            }
            else
            {
                // Msg Box with result
                MessageBox.Show(result);
            }
        }

        private async void Edit()
        {
            var property = new Property
            {
                PropertyId = id,
                PropertyName = txtName.Text,
                Price = Convert.ToDecimal(txtprice.Text),
                AgentId = (int)cmpAgent.SelectedValue,
                PType = (Property_Type.PropertyType)cmbType.SelectedValue,
                Listing = (Listing_Type.ListingType)cmbListing.SelectedValue,
                Status = (Property_Stutus.PropertyStatus)cmbStatus.SelectedValue,
                Description = richTextBox1.Text,
                Latitude = float.Parse(txtLat.Text),
                Longitude = float.Parse(txtLong.Text),
                AddedDate = userCreatedDate,
                UpDatedDate = DateTime.Now.Date,
                UserId = LocalUser.UserId
            };


            var result = await Task.Run(() => dataHelperForProperty.Edit(property));

            if (result == "1")
            {
                //SUCCSESS
                SystemRecordHelper.Add("Property Edited", $"({property.PropertyName}) updated Successfully.");
                //page.LoadData();
                ToastHelper.ShowEditToast();

                using (var context = new DBContext())
                {
                    // Retrieve existing files to avoid duplicates
                    var existingFiles = context.PropertyFiles
                        .Where(f => f.PropertyId == property.PropertyId)
                        .Select(f => f.FileName)
                        .ToList();

                    var propertyFiles = new List<PropertyFile>();

                    foreach (ListViewItem item in listView1.Items)
                    {
                        var filePath = item.Tag.ToString();
                        var fileName = Path.GetFileName(filePath);

                        // Only add files that are not already in the database
                        if (fileName != null && !existingFiles.Contains(fileName))
                        {
                            if (filePath != null)
                            {
                                var fileData = await File.ReadAllBytesAsync(filePath);
                                var fileType = Path.GetExtension(filePath).ToLower() == ".jpg" ||
                                               Path.GetExtension(filePath).ToLower() == ".png"
                                    ? "Picture"
                                    : "Document";

                                propertyFiles.Add(new PropertyFile
                                {
                                    PropertyId = property.PropertyId,
                                    FileName = fileName,
                                    FileData = fileData,
                                    FileType = fileType,
                                    FilePath = filePath
                                });
                            }
                        }
                    }

                    // Add only new files
                    if (propertyFiles.Count > 0)
                    {
                        context.PropertyFiles.AddRange(propertyFiles);
                        await context.SaveChangesAsync();
                    }
                }
                page.LoadData();
                pagelist.DisplayPropertyCards();
                Close();
            }
            else
            {
                // Msg Box with result
                MessageBox.Show(result);
            }
        }


        private async void SetDataForEdit()
        {
            // Get Edit Property Data
            var property = await Task.Run(() => dataHelperForProperty.Find(id));
            var fullname = await Task.Run(() => dataHelperForAgent.GetAllData()
                .Where(x => x.AgentId == property.AgentId)
                .Select(p => p.FullName).FirstOrDefault());
            if (property != null)
            {
                txtName.Text = property.PropertyName;
                txtprice.Text = property.Price.ToString();
                cmpAgent.Text = fullname;
                cmbListing.Text = property.Listing.ToString();
                cmbStatus.Text = property.Status.ToString();
                cmbType.Text = property.PType.ToString();
                richTextBox1.Text = property.Description;
                // ReSharper disable once SpecifyACultureInStringConversionExplicitly
                txtLat.Text = property.Latitude.ToString();
                // ReSharper disable once SpecifyACultureInStringConversionExplicitly
                txtLong.Text = property.Longitude.ToString();
                userCreatedDate = property.AddedDate;
            }

            // Set Map

            if (property != null) LoadPropertyLocation(property);

            // Load Files and images

            if (property != null) LoadPropertyFiles(property.PropertyId);
        }

        // map methods
        private void setMap()
        {
            gmap3.MapProvider = GMapProviders.GoogleSatelliteMap;

            gmap3.MapProvider = GoogleSatelliteMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gmap3.Manager.Mode = AccessMode.ServerAndCache;
            gmap3.DragButton = MouseButtons.Left;
            gmap3.MouseWheelZoomEnabled = true;
            gmap3.Position = new PointLatLng(10.615097418402913, 47.36559208545123); // Center of Erigavo
            gmap3.MinZoom = 1; // Set min zoom level
            gmap3.MaxZoom = 20; // Set max zoom level
            gmap3.Zoom = 40;
            gmap3.MouseWheel += GmapControl_MouseWheel;
            gmap3.Refresh();
        }


        private void GmapControl_MouseWheel(object? sender, MouseEventArgs e)
        {
            // Calculate new zoom level
            double zoom = gmap3.Zoom;

            if (e.Delta > 0)
            {
                // Zoom in
                zoom += ZoomStep;
            }
            else if (e.Delta < 0)
            {
                // Zoom out
                zoom -= ZoomStep;
            }

            // Ensure zoom is within valid range
            zoom = Math.Max(gmap3.MinZoom, Math.Min(gmap3.MaxZoom, zoom));

            // Apply the new zoom level
            gmap3.Zoom = zoom;

            // Optional: Adjust the center of the map to maintain focus on the cursor position
            var point = gmap3.FromLocalToLatLng(e.X, e.Y);
            gmap3.Position = point;
        }


        private void btnpick_Click(object sender, EventArgs e)
        {
           
            var centerLat = gmap3.Position.Lat;
            var centerLng = gmap3.Position.Lng;


            txtLat.Text = centerLat.ToString();

            txtLong.Text = centerLng.ToString();
        }

        private void gmap3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Convert the mouse click position to latitude and longitude
                var point = gmap3.FromLocalToLatLng(e.X, e.Y);

                // Step 3: Update the text boxes with the captured values
                txtLat.Text = point.Lat.ToString();
                txtLong.Text = point.Lng.ToString();
            }
        }

        [SuppressMessage("ReSharper", "LocalizableElement")]
        private void btnloadimages_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = "C:\\Users\\hp.osampc\\Pictures";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = openFileDialog.FileNames;
                foreach (string file in selectedFiles)
                {
                    try
                    {
                        Image img = Image.FromFile(file);
                        imageList1.Images.Add(img);

                        ListViewItem item = new ListViewItem
                        {
                            ImageIndex = imageList1.Images.Count - 1,
                            Tag = Path.GetFullPath(file),
                            Text = Path.GetFileName(file)
                        };
                        listView1.Items.Add(item);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


        private void LoadPropertyLocation(Property property)
        {
            gmap3.Position = new PointLatLng(property.Latitude, property.Longitude);

            // Optionally, add a marker
            var marker = new GMarkerGoogle(new PointLatLng(property.Latitude, property.Longitude),
                GMarkerGoogleType.red_dot);
            var markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gmap3.Overlays.Add(markers);
        }

        private void LoadPropertyFiles(int propertyId)
        {
            var files = dataHelperForPropertyFile.GetAllData().Where(p => p.PropertyId == propertyId).ToList();


            foreach (var file in files)
            {
                Image img = ByteArrayToImage(file.FileData);
                imageList1.Images.Add(img);

                ListViewItem item = new ListViewItem
                {
                    ImageIndex = imageList1.Images.Count - 1,
                    Tag = file.FilePath,
                    Text = file.FileName
                };
                listView1.Items.Add(item);
            }
        }

        private void LoadEnumValues()
        {
            // Populate PropertyType ComboBox
            cmbType.DataSource = Enum.GetValues(typeof(Property_Type.PropertyType));

            // Populate ListingType ComboBox
            cmbListing.DataSource = Enum.GetValues(typeof(Listing_Type.ListingType));

            // Populate PropertyStatus ComboBox
            cmbStatus.DataSource = Enum.GetValues(typeof(Property_Stutus.PropertyStatus));

            cmbType.SelectedIndex = -1; // 
            cmbListing.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1; //
        }

        public async void LoadAgents()
        {
            var agents = await Task.Run(() => dataHelperForAgent.GetAllData());
            cmpAgent.DataSource = agents;
            cmpAgent.DisplayMember = "FullName"; // assuming FullName is a property of the Agent entity
            cmpAgent.ValueMember = "AgentId";
            cmpAgent.SelectedIndex = -1; //
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                MsgHelper.ShowRequiredFields();
            }
            else
            {
                // Show Loading
                LoadingForm.Instance(main).Show();
                // Check Connection
                if (await Task.Run(() => dataHelperForProperty.IsCanConnect()))
                {
                    // Add
                    if (id == 0)
                    {
                        Add();
                    }
                    else
                    {
                        // Edit
                        Edit();
                    }
                }
                else
                {
                    LoadingForm.Instance(main).Hide();
                    MsgHelper.ShowServerError();
                }

                LoadingForm.Instance(main).Hide();
            }
        }
    }
}