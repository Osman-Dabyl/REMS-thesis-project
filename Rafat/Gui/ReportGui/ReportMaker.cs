using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Rafat.Data.EF;

namespace Rafat.Gui.ReportGui
{
    public partial class ReportMaker : Form
    {
        private ReportViewer reportViewer;
        private readonly ReportService _reportService;


        public ReportMaker()
        {
            InitializeComponent();

            _reportService = new ReportService(new DBContext());
           // reportViewer = new ReportViewer();
        }


        private async Task LoadReportAsync(ReportLoading loadingForm)
        {
            // Generate the report data asynchronously
            var reportData = await _reportService.GetAgentPerformanceReportAsync();

            // Initialize the ReportViewer control
            ReportViewer reportViewer = new ReportViewer();
            ReportDataSource dataSource = new ReportDataSource("DataSet1", reportData);
            reportViewer.LocalReport.DataSources.Add(dataSource);
            reportViewer.LocalReport.ReportPath = "C:\\Users\\hp.osampc\\Downloads\\Rafat-master\\Rafat-master\\Rafat\\Code\\Reports\\Report1.rdlc";
            reportViewer.RefreshReport();

            // Close the loading form
            loadingForm.Invoke(new Action(loadingForm.Close));

            // Show the report viewer form on the UI thread
            ReportViewerForm reportViewerForm = new ReportViewerForm(reportViewer);
            reportViewerForm.ShowDialog();
        }




        private async void btnGenarate_Click(object sender, EventArgs e)
        {
          
            
                // Create and show the loading form
                ReportLoading loadingForm = new ReportLoading();
                loadingForm.Show();

                this.Hide();

            // Start report generation in a background task
                await Task.Run(() => LoadReportAsync(loadingForm));

                // Close the ReportMakerForm
               
            

        }
    }
}
