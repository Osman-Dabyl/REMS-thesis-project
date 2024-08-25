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
using Rafat.Core;
using Rafat.Core.Enums;
using Rafat.Data.EF;
using static Rafat.Core.Enums.Listing_Type;

namespace Rafat.Gui.ReportGui
{
    public partial class ReportMaker : Form
    {
        private ReportViewer reportViewer;
        private readonly ReportService _reportService;
        private readonly IDataHelper<Agent> dataHelperForAgent;
        private bool _Isclicked = false ;
        public ReportMaker()
        {
            InitializeComponent();

            _reportService = new ReportService(new DBContext());

            dataHelperForAgent = new AgentEF();

        }


        private async Task LoadAgentReportAsync(ReportLoading loadingForm)
        {
            List<Data.ReportsData.AgentPerformanceReport> agentsdata;
            try
            {
                var salectedAgent = (int)cmbrepid.SelectedValue;
                if (salectedAgent == 0)
                {
                    agentsdata = await _reportService.GetAgentPerformanceReportAsync();
                }
                else
                {
                    agentsdata = await _reportService.GetAgentPerformanceReportAsync(salectedAgent);
                }

                // Initialize the ReportViewer control
                ReportViewer reportViewer = new ReportViewer();
                ReportDataSource dataSource = new ReportDataSource("DataSet1", agentsdata);
                reportViewer.LocalReport.DataSources.Add(dataSource);
                reportViewer.LocalReport.ReportPath = "C:\\Users\\hp.osampc\\Downloads\\Rafat-master\\Rafat-master\\Rafat\\Code\\Reports\\Report1.rdlc";
                reportViewer.RefreshReport();

                // Close the loading form
                loadingForm.Invoke(new Action(loadingForm.Close));

                // Show the report viewer form on the UI thread
                ReportViewerForm reportViewerForm = new ReportViewerForm(reportViewer);
                reportViewerForm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadingForm.Invoke(new Action(loadingForm.Close)); 
            }
            

           

        
        }



        private async Task LoadSalesReportAsync(ReportLoading loadingForm)
        {

            var Dtpto = dtpto.Value;
            var DtpFrom = dtpfrom.Value;
            // Generate the report data asynchronously
            var reportData = await _reportService.GetSalesReportsAsync(DtpFrom, Dtpto);

            // Initialize the ReportViewer control
            ReportViewer reportViewer = new ReportViewer();
            ReportDataSource dataSource = new ReportDataSource("DataSet1", reportData);
            reportViewer.LocalReport.DataSources.Add(dataSource);
            reportViewer.LocalReport.ReportPath = "C:\\Users\\hp.osampc\\Downloads\\Rafat-master\\Rafat-master\\Rafat\\Code\\Reports\\SalesReport.rdlc";
            reportViewer.RefreshReport();

            // Close the loading form
            loadingForm.Invoke(new Action(loadingForm.Close));

            // Show the report viewer form on the UI thread
            ReportViewerForm reportViewerForm = new ReportViewerForm(reportViewer);
            reportViewerForm.ShowDialog();
        }


        private async Task LoadPropertyReportAsync(ReportLoading loadingForm)
        {
            // Generate the report data asynchronously


            var type = (ListingType)cmbrepid.SelectedItem;

            var reportData = await _reportService.GetPropertyReport(type);

            // Initialize the ReportViewer control
            ReportViewer reportViewer = new ReportViewer();
            ReportDataSource dataSource = new ReportDataSource("DataSet1", reportData);
            reportViewer.LocalReport.DataSources.Add(dataSource);
            reportViewer.LocalReport.ReportPath = "C:\\Users\\hp.osampc\\Downloads\\Rafat-master\\Rafat-master\\Rafat\\Code\\Reports\\PropertyAvailable.rdlc";
            reportViewer.RefreshReport();

            // Close the loading form
            loadingForm.Invoke(new Action(loadingForm.Close));

            // Show the report viewer form on the UI thread
            ReportViewerForm reportViewerForm = new ReportViewerForm(reportViewer);
            reportViewerForm.ShowDialog();
        }





        private async void btnGenarate_Click(object sender, EventArgs e)
        {
            if (cmbreptype.SelectedIndex != -1)
            {
                _Isclicked = true;

                var salectedReport = cmbreptype.SelectedItem.ToString();
                ReportLoading loadingForm = new ReportLoading();
                loadingForm.Show();

                this.Hide();

                // Start report generation in a background task

                switch (salectedReport)
                {
                    case "Agent Performance Report":
                        await Task.Run(() => LoadAgentReportAsync(loadingForm));
                        break;
                    case "Sales Report":
                        await Task.Run(() => LoadSalesReportAsync(loadingForm));
                        break;
                    case "Property Avalibilaty Report":
                        await Task.Run(() => LoadPropertyReportAsync(loadingForm));
                        break;
                  
                }

            }
            if (!_Isclicked)
            {

                MessageBox.Show("Please Choise One Report Type");
            }

           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private async void databending()
        {
            var agent = await Task.Run(() => dataHelperForAgent.GetAllData());

            agent.Insert(0, new Agent { AgentId = 0, FullName = "All" });

            cmbrepid.DataSource = agent;
            cmbrepid.DisplayMember = "FullName";
            cmbrepid.ValueMember = "AgentId";
            cmbrepid.SelectedIndex = 0;

        }

        private void cmbreptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbreptype.SelectedIndex == 1)
            {
                cmbrepid.SelectedIndex = -1;
                cmbrepid.Enabled = false;
                pnldaterang.Visible = true;

            }
            else
            {
                if (cmbreptype.SelectedIndex == 0)
                {
                    databending();
                    cmbrepid.Enabled = true;

                }
                else
                {
                    cmbrepid.DataSource = null;
                    cmbrepid.DataSource = Enum.GetValues(typeof(Listing_Type.ListingType));
                    cmbrepid.Enabled = true;

                }

                pnldaterang.Visible = false;
            }

        }

        private void ReportMaker_Load(object sender, EventArgs e)
        {
           
        }
    }
}
