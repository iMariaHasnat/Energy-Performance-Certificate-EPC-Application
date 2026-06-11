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
using ClosedXML.Excel;


namespace EPCPROJECT
{
    public partial class FilterMoreData : Form
    {
        // holds your full imported dataset
        private DataTable _allData;
        public FilterMoreData()
        {
            InitializeComponent();
            // Ensure no duplicate subscriptions from designer + code
            btn_FilterImportData.Click -= btn_FilterImportData_Click;
            btn_Filter.Click -= btn_Filter_Click;
            btn_downloadData.Click -= Btn_downloadData_Click;
            dataGridView1.DataBindingComplete -= DataGridView1_DataBindingComplete;

            // Wire up events once
            btn_FilterImportData.Click += btn_FilterImportData_Click;
            btn_Filter.Click += btn_Filter_Click;
            btn_downloadData.Click += Btn_downloadData_Click;
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;

            // Close “X”
            lbl_filtermoreDCross.Click += (s, e) => Close();
            lbl_NumberofProperties.Text = string.Empty;

        }


        private void lbl_filtermoreDCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterMoreData_Load(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(
    System.Text.CodePagesEncodingProvider.Instance);
        }

        private void btn_FilterImportData_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Import EPC Data from Excel";
                ofd.Filter = "Excel Files|*.xlsx;*.xls";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    _allData = LoadExcelWithExcelDataReader(ofd.FileName);

                    // If you have a date column, set the pickers to its full range
                    if (_allData.Columns.Contains("LODGEMENT_DATE"))
                    {
                        var dates = _allData.AsEnumerable()
                            .Select(r => r.Field<DateTime?>("LODGEMENT_DATE"))
                            .Where(d => d.HasValue)
                            .Select(d => d.Value)
                            .ToList();

                        if (dates.Any())
                        {
                            var min = dates.Min();
                            var max = dates.Max();

                            dtp_fmdFrom.MinDate = min;
                            dtp_fmdFrom.Value = min;
                            dtp_fmdTo.MaxDate = max;
                            dtp_fmdTo.Value = max;
                        }
                    }

                    if (_allData.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = _allData;
                        MessageBox.Show(
                            $"Data loaded successfully. {_allData.Rows.Count} rows imported.",
                            "Import Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "The selected file contained no data.",
                            "Import Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error loading data: {ex.Message}",
                        "Import Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }



        private void DataGridView1_DataBindingComplete(object sender,
                                                       DataGridViewBindingCompleteEventArgs e)
        {
            int count = dataGridView1.Rows.Count
                      - (dataGridView1.AllowUserToAddRows ? 1 : 0);
            lbl_NumberofProperties.Text = $"Number of properties: {count}";
        }


        private void Btn_downloadData_Click(object sender, EventArgs e)
        {
            DataTable toExport;

            // Decide whether to export the full imported data or the filtered view
            if (ReferenceEquals(dataGridView1.DataSource, _allData))
                toExport = _allData;
            else
                toExport = (DataTable)dataGridView1.DataSource;

            if (toExport == null || toExport.Rows.Count == 0)
            {
                MessageBox.Show(
                    "There’s no data to export.",
                    "Export Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Save Filtered Data as Excel";
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.FileName = "FilteredEPC.xlsx";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                ExportToExcel(toExport, sfd.FileName);

                MessageBox.Show(
                    $"Data exported successfully to:\n{sfd.FileName}",
                    "Export Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private DataTable LoadExcelWithExcelDataReader(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var conf = new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                };
                var ds = reader.AsDataSet(conf);
                var table = ds.Tables[0];

                if (table.Columns.Contains("LODGEMENT_DATE"))
                {
                    table.Columns["LODGEMENT_DATE"].DataType = typeof(DateTime);
                    foreach (DataRow r in table.Rows)
                        r["LODGEMENT_DATE"] = DateTime.Parse(
                            r["LODGEMENT_DATE"].ToString()
                        );
                }

                return table.Copy();
            }
        }


        private void ExportToExcel(DataTable dt, string filePath)
        {
            using (var wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "FilteredData");
                wb.SaveAs(filePath);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (_allData == null)
            {
                MessageBox.Show(
                    "No data has been imported yet.\nPlease click Import Data first.",
                    "Filter Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var filtered = ApplyFilters();

            if (filtered.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No properties found matching your criteria.",
                    "Filter Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private DataTable ApplyFilters()
        {
            // gather criteria
            string townFilter = txt_fmdCity.Text.Trim();
            var ratings = txt_fmdRating.Text
                             .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(r => r.Trim())
                             .ToList();

            DateTime from = dtp_fmdFrom.Value.Date;
            DateTime to = dtp_fmdTo.Value.Date;

            // LINQ with null-safe pulls
            var rows = _allData.AsEnumerable()
                .Where(r =>
                {
                    string town = r.Field<string>("POSTTOWN") ?? string.Empty;
                    string rating = r.Field<string>("CURRENT_ENERGY_RATING") ?? string.Empty;
                    DateTime? lodgement = r.Field<DateTime?>("LODGEMENT_DATE");

                    // Town filter
                    if (!string.IsNullOrWhiteSpace(townFilter)
                        && !town.Equals(townFilter, StringComparison.OrdinalIgnoreCase))
                        return false;

                    // Rating filter
                    if (ratings.Count > 0
                        && !ratings.Contains(rating, StringComparer.OrdinalIgnoreCase))
                        return false;

                    // Date filter (must have a date and be in range)
                    if (!lodgement.HasValue
                        || lodgement.Value < from
                        || lodgement.Value > to)
                        return false;

                    return true;
                });

            var filtered = rows.Any()
                           ? rows.CopyToDataTable()
                           : _allData.Clone();

            dataGridView1.DataSource = filtered;
            return filtered;
        }

        private void btn_pieChart_Click(object sender, EventArgs e)
        {
            PieChart pie = new PieChart();
            pie.Show();
        }
    }
}
