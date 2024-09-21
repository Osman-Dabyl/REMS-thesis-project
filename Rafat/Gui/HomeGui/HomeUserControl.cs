
using Rafat.Core;
using Rafat.Data.EF;
using System.Windows.Forms.DataVisualization.Charting;
using Rafat.Code.Models;


namespace Rafat.Gui.HomeGui
{
    public partial class HomeUserControl : UserControl
    {
        private IDataHelper<Order> dataHelper;
        private static HomeUserControl? _homeUserControl;
        private List<Property> data;


        public HomeUserControl()
        {
            data = new List<Property>();


            InitializeComponent();
            LoadTestDataAndCreateChart();
            LoadCounters();

            lblgreeting.Text =  $" Welcome " + LocalUser.FullName + "!";
        }

        public static HomeUserControl Instance()
        {
            return _homeUserControl ?? (_homeUserControl = new HomeUserControl());
        }

        private void LoadTestDataAndCreateChart()
        {
            // Test data: Randomly generated sales and rental numbers
            Random rnd = new Random();
            int saleCount = rnd.Next(50, 200); // Random sales count between 50 and 200
            int rentalCount = rnd.Next(30, 150); // Random rental count between 30 and 150

            // Customize the chart
            Series series = new Series
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true,
                Font = new Font("Arial", 12),
            };

            // Add data points
            series.Points.AddXY("Sales", saleCount);
            series.Points.AddXY("Rentals", rentalCount);

            series.Points[0].Color = Color.FromArgb(135, 206, 250); // Light Sky Blue for Sales
            series.Points[1].Color = Color.FromArgb(255, 105, 97);  // Salmon for Rentals

            // Increase the gradient effect with more pronounced secondary colors
            series.Points[0].BackGradientStyle = GradientStyle.TopBottom;
            series.Points[0].BackSecondaryColor = Color.FromArgb(70, 130, 180); // Steel Blue
            series.Points[1].BackGradientStyle = GradientStyle.TopBottom;
            series.Points[1].BackSecondaryColor = Color.FromArgb(220, 20, 60);  // Crimson

            // Add the series to the chart
            chart1.Series.Add(series);

            // Refresh the chart to display the data
            chart1.Invalidate();
        }

        


        private void LoadCounters()
        {
            using (var context = new DBContext())
            {
                // Total Properties
                var totalProperties = context.Properties.Count();

                // Properties for Sale
                var totalCustomers = context.Customers.Count();

                // Properties for Rent
                var totalOrders = context.Orders.Count();

                // Total Agents
                var totalAgents = context.Agents.Count();

                var totaSales = context.Orders.Where(x => x.Status == Core.Enums.Order_Status.OrderStatus.Accepted && x.Ordertype == Core.Enums.Oreder_Type.OrderType.Purchase)
                    .Sum(x => x.SalePrice);

                // Assign values to labels or UI components
                txtPcount.Text = totalProperties.ToString();
                txtCCount.Text = totalCustomers.ToString();
                txtOcount.Text = totalOrders.ToString();
                txtACount.Text = totalAgents.ToString();
                txtsales.Text = totaSales.ToString();
                txtrevenue.Text = totaSales.ToString();

                var latestProperties = context.Properties
                                  .OrderByDescending(p => p.AddedDate)
                                  .Take(5) // Take the latest 5 properties
                                  .ToList();
                dataGridView1.DataSource = latestProperties;

                SetColumns();

            }
        }


        private void SetColumns()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "Property ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Property Name";
            dataGridView1.Columns[2].HeaderCell.Value = "Price";
            dataGridView1.Columns[3].HeaderCell.Value = "Property Type";
            dataGridView1.Columns[4].HeaderCell.Value = "Status";
            dataGridView1.Columns[5].HeaderCell.Value = "Listing";
            dataGridView1.Columns[6].HeaderCell.Value = "Description";
            dataGridView1.Columns[7].HeaderCell.Value = "Added Date";
            dataGridView1.Columns[8].HeaderCell.Value = "Updated Date";
            dataGridView1.Columns[9].HeaderCell.Value = "longitude";
            dataGridView1.Columns[10].HeaderCell.Value = "latitude";
            dataGridView1.Columns[11].HeaderCell.Value = "userId";
            dataGridView1.Columns[12].HeaderCell.Value = "agentId";
            dataGridView1.Columns[13].HeaderCell.Value = "";
            dataGridView1.Columns[8].HeaderCell.Value = "";
            dataGridView1.Columns[9].HeaderCell.Value = "";
            dataGridView1.Columns[10].HeaderCell.Value = "";
            dataGridView1.Columns[11].HeaderCell.Value = "";
            dataGridView1.Columns[12].HeaderCell.Value = "";
            dataGridView1.Columns[13].HeaderCell.Value = "";
            dataGridView1.Columns[14].HeaderCell.Value = "";
            dataGridView1.Columns[15].HeaderCell.Value = "";

            // Visible of Columns
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
        }

    }
}
