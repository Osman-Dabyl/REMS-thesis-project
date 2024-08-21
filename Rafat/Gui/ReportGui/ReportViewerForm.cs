using Microsoft.Reporting.WinForms;
using Rafat.Data.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;


namespace Rafat.Gui.ReportGui
{
    public partial class ReportViewerForm : Form
    {
        private readonly ReportService _reportService = new ReportService(new DBContext());

        public ReportViewerForm(ReportViewer reportViewer)
        {
            InitializeComponent();


            Text = "Report viewer";
            reportViewer.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(reportViewer);

            
        }


       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
