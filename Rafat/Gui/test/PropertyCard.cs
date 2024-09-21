using Rafat.Gui.PropertysGui;
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
    private AddPropertyForm addPropertyForm;
    private Main _main;
    public PropertyCard()
    {
        InitializeComponent();

        this.Click += PropertyCard_Click;

        // Attach click event to all child controls within the PropertyCard
        foreach (Control control in this.Controls)
        {
            control.Click += PropertyCard_Click;
        }

        this.Size = new Size(365, 402);
        this.BorderStyle = BorderStyle.None;
    }



    public int PropertyId { get; set; }


    public void SetData(int propertyId, Image image, string name, string price,string stuts)
    {
        PropertyId = propertyId;
        pictureBox1.Image = image;
        labelName.Text = name;
        labelPrice.Text = price;
        label1.Text = stuts;


    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        // Enforce the fixed size
        this.Size = new Size(365, 402);  // Adjust as necessary
    }

    // Event to handle clicks for editing or deleting
    private void PropertyCard_Click(object sender, EventArgs e)
    {
        int id = PropertyId;
        if (addPropertyForm == null || addPropertyForm.IsDisposed)
        {
            addPropertyForm = new AddPropertyForm(_main, id);
            addPropertyForm.Show();
        }
        else
        {
            addPropertyForm.Focus();
        }

    }

    private void PropertyCard_MouseClick(object sender, MouseEventArgs e)
    {
        int id = PropertyId;
        if (addPropertyForm == null || addPropertyForm.IsDisposed)
        {
            addPropertyForm = new AddPropertyForm(_main, id);
            addPropertyForm.Show();
        }
        else
        {
            addPropertyForm.Focus();
        }
    }
}