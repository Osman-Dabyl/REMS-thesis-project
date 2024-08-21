
using System.Windows.Forms.DataVisualization.Charting;


namespace Rafat.Gui.HomeGui
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl? _homeUserControl;
       

        public HomeUserControl()
        {
            InitializeComponent();
            LoadTestDataAndCreateChart();
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
    }
}
