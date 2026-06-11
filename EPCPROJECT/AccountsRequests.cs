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
using ClosedXML.Excel;
using System.Data.OleDb;


namespace EPCPROJECT
{
    public partial class AccountsRequests : Form
    {
        private readonly string _connStr =
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "db_users.mdb")}";

        public AccountsRequests()
        {
            InitializeComponent();
            // wire up events
            this.Load += AccountsRequests_Load;
            //btn_Refresh.Click += btn_Refresh_Click;
            //btn_accsReqsExport.Click += btn_accsReqsExport_Click;
            //dgv_Requests.CellContentClick += dgv_Requests_CellContentClick;
            lbl_accsReqsCross.Click += (s, e) => Close();
        }

        private void lbl_accsReqsCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountsRequests_Load(object sender, EventArgs e)
        {
            // populate status filter
            cmb_StatusFilter.Items.Clear();
            cmb_StatusFilter.Items.AddRange(new[] { "All", "Pending", "Approved", "Denied" });
            cmb_StatusFilter.SelectedIndex = 1; // default to “Pending”

            LoadRequests();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void LoadRequests()
        {
            var dt = new DataTable();
            using (var con = new OleDbConnection(_connStr))
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT RequestID, Username, Email, UserType, RequestDate, Status
                      FROM tbl_requests
                     WHERE (@status = 'All' OR Status = @status)
                       AND (Username LIKE @search OR Email LIKE @search)";
                cmd.Parameters.AddWithValue("?", cmb_StatusFilter.Text);
                cmd.Parameters.AddWithValue("?", "%" + txt_usernameORemail.Text.Trim() + "%");

                con.Open();
                new OleDbDataAdapter(cmd).Fill(dt);
            }

            dgv_Requests.DataSource = dt;

            // add Approve/Deny buttons if not already present
            if (!dgv_Requests.Columns.Contains("Approve"))
            {
                var approveCol = new DataGridViewButtonColumn
                {
                    Name = "Approve",
                    HeaderText = "",
                    Text = "Approve",
                    UseColumnTextForButtonValue = true
                };
                dgv_Requests.Columns.Add(approveCol);
            }
            if (!dgv_Requests.Columns.Contains("Deny"))
            {
                var denyCol = new DataGridViewButtonColumn
                {
                    Name = "Deny",
                    HeaderText = "",
                    Text = "Deny",
                    UseColumnTextForButtonValue = true
                };
                dgv_Requests.Columns.Add(denyCol);
            }

            lbl_RequestCount.Text = $"Showing {dt.Rows.Count} request(s)";
        }

        private void dgv_Requests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgv_Requests.Columns[e.ColumnIndex].Name;
            if (colName != "Approve" && colName != "Deny") return;

            int requestId = Convert.ToInt32(
                dgv_Requests.Rows[e.RowIndex].Cells["RequestID"].Value);

            // build a friendly verb
            string verb = colName == "Approve" ? "approve" : "deny";

            // ask confirmation
            var result = MessageBox.Show(
                $"Are you sure you want to {verb} request #{requestId}?",
                $"Confirm {verb}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ProcessRequest(requestId, colName == "Approve");
            }
            // otherwise do nothing
        }

        private void ProcessRequest(int requestId, bool isApproved)
        {
            string username, email, userType;

            // 1) Look up the request details
            using (var con = new OleDbConnection(_connStr))
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT Username, Email, UserType FROM tbl_requests WHERE RequestID = ?";
                cmd.Parameters.AddWithValue("?", requestId);
                con.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    if (!dr.Read()) return;
                    username = dr.GetString(0);
                    email = dr.GetString(1);
                    userType = dr.GetString(2);
                }
            }

            // 2) Update the request status
            using (var con = new OleDbConnection(_connStr))
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "UPDATE tbl_requests SET Status = ? WHERE RequestID = ?";
                cmd.Parameters.AddWithValue("?", isApproved ? "Approved" : "Denied");
                cmd.Parameters.AddWithValue("?", requestId);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            // 3) If approved, add to tbl_users (with blank password)
            if (isApproved)
            {
                // hand off to the Register form
                using (var reg = new Register(username, email, userType, requestId))
                {
                    if (reg.ShowDialog() == DialogResult.OK)
                    {
                        // Register form has already updated tbl_users and tbl_requests
                        // so just inform and refresh:
                        MessageBox.Show(
                          $"Request {requestId} approved and user '{username}' was created.",
                          "Approved",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        // admin cancelled, roll back the status back to Pending
                        using (var con2 = new OleDbConnection(_connStr))
                        using (var cmd2 = new OleDbCommand(
                               "UPDATE tbl_requests SET Status='Pending' WHERE RequestID=?", con2))
                        {
                            cmd2.Parameters.AddWithValue("?", requestId);
                            con2.Open();
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    $"Request {requestId} has been denied.",
                    "Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            // 4) Refresh the grid
            LoadRequests();
        }

        private void btn_accsReqsExport_Click(object sender, EventArgs e)
        {
            if (!(dgv_Requests.DataSource is DataTable dt) || dt.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Export Requests to Excel";
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.FileName = "AccountRequests.xlsx";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                using (var wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Requests");
                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show($"Exported to {sfd.FileName}", "Export Complete",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
