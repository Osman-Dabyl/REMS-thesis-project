using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rafat.Gui.test;

public partial class PropertyCard : UserControl
{
    public PropertyCard()
    {
        InitializeComponent();

        this.Size = new Size(365, 402);
    }

      
        
    public int PropertyId { get; set; }


    public void SetData(int propertyId, Image image, string name, string price)
    {
        PropertyId = propertyId;
        pictureBox1.Image = image;
        labelName.Text = name;
        labelPrice.Text = price;
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        // Enforce the fixed size
        this.Size = new Size(365, 402);  // Adjust as necessary
    }

    // Event to handle clicks for editing or deleting
    private void PropertyCardControl_Click(object sender, EventArgs e)
    {
        // Raise an event or handle directly here
        
    }

    //private void OpenEditForm(int propertyId)
    //{
    //    // Implement your editing logic here
    //    var editForm = new EditPropertyForm(propertyId);
    //    editForm.ShowDialog();

    //    // Optionally refresh the view after editing
    //    // Assuming parent control has a method to reload the data
    //    ((YourParentControl)this.Parent).ReloadPropertyCards();

    //}
}