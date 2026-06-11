using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.Windows.Forms.DataVisualization.Charting;

namespace EPCPROJECT
{
    public partial class PieChart : Form
    {
        // Holds imported EPC data
        private DataTable _allData;
        public PieChart()
        {
            InitializeComponent();
            // Prevent duplicate event subscriptions
            btn_piechartImport.Click -= btn_piechartImport_Click;
            btn_distribution.Click -= btn_distribution_Click;
            btn_downloadpie.Click -= btn_downloadpie_Click;

            // Wire up button events once
            btn_piechartImport.Click += btn_piechartImport_Click;
            btn_distribution.Click += btn_distribution_Click;
            btn_downloadpie.Click += btn_downloadpie_Click;
        }

        private void btn_piechartImport_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Import EPC Data...";
                ofd.Filter = "Excel Files|*.xlsx;*.xls";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    _allData = LoadExcelWithExcelDataReader(ofd.FileName);

                    if (_allData.Columns.Contains("LODGEMENT_DATE"))
                    {
                        var dates = _allData.AsEnumerable()
                                    .Select(r => r.Field<DateTime?>("LODGEMENT_DATE"))
                                    .Where(d => d.HasValue)
                                    .Select(d => d.Value)
                                    .ToList();
                        if (dates.Any())
                        {
                            dtp_piechartFrom.MinDate = dates.Min();
                            dtp_piechartFrom.Value = dates.Min();
                            dtp_piechartTo.MaxDate = dates.Max();
                            dtp_piechartTo.Value = dates.Max();
                        }
                    }

                    MessageBox.Show($"Imported {_allData.Rows.Count} records.",
                                    "Import Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error importing data: {ex.Message}",
                                    "Import Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btn_distribution_Click(object sender, EventArgs e)
        {
            if (_allData == null || _allData.Rows.Count == 0)
            {
                MessageBox.Show("No data loaded. Please import first.",
                                "No Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string cityFilter = txt_piechartCity.Text.Trim();
            DateTime fromDate = dtp_piechartFrom.Value.Date;
            DateTime toDate = dtp_piechartTo.Value.Date;

            var filtered = _allData.AsEnumerable()
                .Where(r =>
                {
                    var lodg = r.Field<DateTime?>("LODGEMENT_DATE");
                    if (!lodg.HasValue) return false;
                    if (lodg.Value.Date < fromDate || lodg.Value.Date > toDate)
                        return false;
                    if (!string.IsNullOrEmpty(cityFilter))
                    {
                        var town = r.Field<string>("POSTTOWN") ?? string.Empty;
                        if (!town.Equals(cityFilter, StringComparison.OrdinalIgnoreCase))
                            return false;
                    }
                    return true;
                });

            var groups = filtered
                .GroupBy(r => r.Field<string>("CURRENT_ENERGY_RATING") ?? "(Blank)")
                .Select(g => new { Rating = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .ToList();

            chart_pie.Series.Clear();
            chart_pie.Legends.Clear();

            var seriesObj = chart_pie.Series.Add("Ratings");
            seriesObj.ChartType = SeriesChartType.Pie;
            seriesObj.IsValueShownAsLabel = true;
            seriesObj.Label = "#PERCENT{P0}";
            seriesObj["PieLabelStyle"] = "Outside";

            var legend = chart_pie.Legends.Add("RatingsLegend");
            legend.LegendStyle = LegendStyle.Table;
            legend.Docking = Docking.Right;
            legend.Alignment = StringAlignment.Center;

            seriesObj.Legend = legend.Name;
            seriesObj.LegendText = "#VALX";

            foreach (var g in groups)
                seriesObj.Points.AddXY(g.Rating, g.Count);

            chart_pie.Titles.Clear();
            chart_pie.Titles.Add(
                $"Distribution of Ratings for {cityFilter} ({fromDate:yyyy-MM-dd} to {toDate:yyyy-MM-dd})");
        }



        // Utility: loads Excel into DataTable with ExcelDataReader
        private DataTable LoadExcelWithExcelDataReader(string filePath)
        {
            System.Text.Encoding.RegisterProvider(
                System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var config = new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                };

                var ds = reader.AsDataSet(config);
                var table = ds.Tables[0];

                if (table.Columns.Contains("LODGEMENT_DATE"))
                {
                    table.Columns["LODGEMENT_DATE"].DataType = typeof(DateTime);
                    foreach (DataRow row in table.Rows)
                    {
                        if (DateTime.TryParse(row["LODGEMENT_DATE"].ToString(), out var dt))
                            row["LODGEMENT_DATE"] = dt;
                    }
                }

                return table.Copy();
            }
        }

        private void lbl_piechartCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_downloadpie_Click(object sender, EventArgs e)
        {
            {
                if (chart_pie.Series.Count == 0)
                {
                    MessageBox.Show(
                        "There is no chart to export.",
                        "Export Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                using (var sfd = new SaveFileDialog())
                {
                    sfd.Title = "Save Pie Chart as Image";
                    sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
                    sfd.FileName = "PieChart.png";

                    if (sfd.ShowDialog() != DialogResult.OK)
                        return;

                    try
                    {
                        var ext = Path.GetExtension(sfd.FileName).ToLower();
                        ChartImageFormat fmt = ChartImageFormat.Png;
                        if (ext == ".jpg" || ext == ".jpeg") fmt = ChartImageFormat.Jpeg;

                        chart_pie.SaveImage(sfd.FileName, fmt);
                        MessageBox.Show(
                            $"Chart saved successfully to:\n{sfd.FileName}",
                            "Export Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Error saving chart: {ex.Message}",
                            "Export Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
