
using Rafat.Data.EF;
using Rafat.Gui.PropertysGui;
using System.Data;
using static Rafat.Core.Enums.Property_Stutus;


namespace Rafat.Gui.test;

public partial class testuser : UserControl
{
    private static testuser? testusercontrol;
    private AddPropertyForm addPropertyForm;
    private static Main _main;
    private IDataHelper<Core.Property> dataHelper;
    private List<Core.Property> data;
    private List<int> idDeleteList;
    private DBContext db;
    private DataGridView dataGridView1;

    public testuser()
    {
        InitializeComponent();

        dataHelper = new PropertyEF();
        data = new List<Core.Property>();
        idDeleteList = new List<int>();
        db = new DBContext();

        DisplayPropertyCards();


        DataGridView dataGridView1 = new DataGridView();
    }


    public void DisplayPropertyCards()
    {
        flowLayoutPanel1.Controls.Clear();
        var propertyCards = LoadPropertyCards();

        foreach (var card in propertyCards)
        {
            var propertyCardControl = new PropertyCard();
            propertyCardControl.SetData(card.PropertyId, card.PropertyImage, card.PropertyName, $"${card.Price:F2}",card.Stuts);

            var panel = new Panel
            {
                Width = propertyCardControl.Width + 15, // Add padding to the panel width
                Height = propertyCardControl.Height + 15, // Add padding to the panel height
                Padding = new Padding(7) // Add some padding inside the panel
            };

            panel.BackColor = System.Drawing.Color.FromArgb(240, 240, 245);
            panel.BorderStyle = BorderStyle.FixedSingle;


            propertyCardControl.Dock = DockStyle.Fill;
            CenterControlInPanel(panel, propertyCardControl);

            panel.Controls.Add(propertyCardControl);

            flowLayoutPanel1.Controls.Add(panel);

            flowLayoutPanel1.Controls.Add(panel);
        }
    }

    private void CenterControlInPanel(Panel panel, System.Windows.Forms.Control control)
    {
        // Calculate the available space inside the panel (excluding padding)
        int availableWidth = panel.ClientSize.Width - panel.Padding.Left - panel.Padding.Right;
        int availableHeight = panel.ClientSize.Height - panel.Padding.Top - panel.Padding.Bottom;

        // Calculate the position to center the control
        int x = panel.Padding.Left + (availableWidth - control.Width) / 2;
        int y = panel.Padding.Top + (availableHeight - control.Height) / 2;

        // Set the control's location
        control.Location = new System.Drawing.Point(x, y);
    }




    private List<PropertyCardcore> LoadPropertyCards()
    {
        using (var context = new DBContext())
        {
            var properties = context.Properties.OrderByDescending(x => x.AddedDate).Where(x => x.Status == PropertyStatus.Available).ToList();
            var propertyCards = new List<PropertyCardcore>();

            foreach (var property in properties)
            {
                var firstImageFile = context.PropertyFiles
                    .Where(pf => pf.PropertyId == property.PropertyId)
                    .OrderBy(pf => pf.FileName)
                    .FirstOrDefault();

                Image propertyImage = ByteArrayToImage(firstImageFile.FileData);

                propertyCards.Add(new PropertyCardcore
                {
                    PropertyId = property.PropertyId,
                    PropertyImage = propertyImage,
                    PropertyName = property.PropertyName,
                    Price = property.Price,
                    Stuts = property.Listing.ToString()

                });
            }

            return propertyCards;
        }
    }

    private Image ByteArrayToImage(byte[] byteArray)
    {
        using (var ms = new MemoryStream(byteArray))
        {
            return Image.FromStream(ms);
        }
    }


    public static testuser Instance(Main main)
    {
        _main = main;
        var instance = testusercontrol;
        if (instance != null && !instance.IsDisposed)
        {
            return instance;
        }

        return (testusercontrol = new testuser());
    }


}