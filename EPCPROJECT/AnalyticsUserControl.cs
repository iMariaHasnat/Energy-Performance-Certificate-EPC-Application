using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EPCPROJECT
{
    public partial class AnalyticsUserControl3 : UserControl
    {
        // Holds the complete imported data so it can be filtered and used to build charts.
        private DataTable analyticsData;
        public AnalyticsUserControl3()
        {
            InitializeComponent();
        }

        private void txt_city_TextChanged(object sender, EventArgs e)
        {
            // Optional: Live filtering can be added here.
        }

        private void cmbBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: If you want to filter by year directly.
        }

        // Import button event handler - btn_Analyticsimport
        private void btn_Analyticsimport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Register the code pages encoding provider.
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                    using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                    {
                        IExcelDataReader reader = null;
                        if (Path.GetExtension(filePath).ToLower() == ".xls")
                        {
                            reader = ExcelReaderFactory.CreateBinaryReader(stream);
                        }
                        else if (Path.GetExtension(filePath).ToLower() == ".xlsx")
                        {
                            reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                        }

                        if (reader != null)
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            reader.Close();

                            // Assume the first worksheet holds the data.
                            analyticsData = result.Tables[0];

                            // Optionally, display the imported data in a DataGridView for preview.
                            dataGridView_Analytics.DataSource = analyticsData;

                            MessageBox.Show("Data imported successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Unable to create an Excel reader for the selected file.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // Show Graph button event handler - btn_showGraph
        private void btn_showGraph_Click(object sender, EventArgs e)
        {
            // Ensure you have data.
            if (analyticsData == null || analyticsData.Rows.Count == 0)
            {
                MessageBox.Show("Please import data first.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gather inputs from controls.
            string city1 = txt_city1.Text.Trim();
            string city2 = txt_city2.Text.Trim();
            DateTime fromDate = dtp_fromDate.Value.Date;
            DateTime toDate = dtp_toDate.Value.Date;
            string rating = cmbBox_Rating.Text.Trim();  // e.g., "G"

            // Basic validation:
            if (string.IsNullOrEmpty(city1) || string.IsNullOrEmpty(city2))
            {
                MessageBox.Show("Please enter both City 1 and City 2.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(rating))
            {
                MessageBox.Show("Please select a rating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (fromDate > toDate)
            {
                MessageBox.Show("From Date cannot be after To Date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Build a helper function to create a row filter for a given city.
            // We assume the columns are:
            //   [POSTTOWN] for city
            //   [LODGEMENT_DATE] for the date
            //   [POTENTIAL_ENERGY_RATING] for rating
            string BuildFilter(string city)
            {
                // For Access-based date filters in DataView.RowFilter, use US format with # delimiters.
                return $"([POSTTOWN] = '{city}') AND ([POTENTIAL_ENERGY_RATING] = '{rating}') " +
                       $"AND ([LODGEMENT_DATE] >= #{fromDate:MM/dd/yyyy}#) AND ([LODGEMENT_DATE] <= #{toDate:MM/dd/yyyy}#)";
            }

            // Create two DataViews, one for each city.
            DataView dvCity1 = new DataView(analyticsData);
            dvCity1.RowFilter = BuildFilter(city1);
            int city1Count = dvCity1.Count;

            DataView dvCity2 = new DataView(analyticsData);
            dvCity2.RowFilter = BuildFilter(city2);
            int city2Count = dvCity2.Count;

            // Clear any existing chart elements.
            chart_EPC.Series.Clear();
            chart_EPC.Titles.Clear();

            // Add a title that clarifies what is being compared.
            chart_EPC.Titles.Add($"Comparing '{rating}' Properties in {city1} vs. {city2}");

            // Create a new Series for the comparison (Column type).
            var series = chart_EPC.Series.Add("City Comparison");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.Points.Clear();

            // Add two points to represent the counts for City1 and City2.
            // The X values on the axis will show city names; the Y values are the counts.
            series.Points.AddXY(city1, city1Count);
            series.Points.AddXY(city2, city2Count);

            // (Optional) Improve labeling for clarity:
            // Show the data point values on top of each column.
            series.IsValueShownAsLabel = true;

            // (Optional) Axis labels:
            chart_EPC.ChartAreas[0].AxisX.Title = "Cities";
            chart_EPC.ChartAreas[0].AxisY.Title = "Number of Properties";

            // If both counts are zero, let the user know no data matched.
            if (city1Count == 0 && city2Count == 0)
            {
                MessageBox.Show("No matching records found for either city.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_downloadGraph_Click(object sender, EventArgs e)
        {
            // Check if the chart has any series and if the first series has any data points.
            if (chart_EPC.Series.Count == 0 || chart_EPC.Series[0].Points.Count == 0)
            {
                MessageBox.Show("No graph data available. Please filter the data to generate a graph first.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Allow the user to choose a format: PNG or JPEG.
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
                saveFileDialog.Title = "Download Graph";
                // Provide a default filename with a timestamp.
                saveFileDialog.FileName = "Graph_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Determine the image format based on the file extension.
                    ChartImageFormat format = ChartImageFormat.Png;
                    if (Path.GetExtension(saveFileDialog.FileName).ToLower() == ".jpg")
                    {
                        format = ChartImageFormat.Jpeg;
                    }

                    // Save the chart image to the specified file.
                    chart_EPC.SaveImage(saveFileDialog.FileName, format);

                    MessageBox.Show("Graph has been saved successfully!", "Download Complete",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_filtermoreData_Click(object sender, EventArgs e)
        {
            FilterMoreData fmdForm = new FilterMoreData();
            fmdForm.Show();
        }
    }
    }


