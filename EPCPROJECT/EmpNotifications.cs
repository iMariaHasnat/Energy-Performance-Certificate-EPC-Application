using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EPCPROJECT
{
    public partial class EmpNotifications : UserControl
    {
        // Connection string to your Access database
        private readonly string connectionString =
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "db_users.mdb")}";

        public EmpNotifications()
        {
            InitializeComponent();
            // Wire up Load event correctly
            this.Load -= EmpNotifications_Load;
            this.Load += EmpNotifications_Load;
        }

        // Prevent loading at design time
        private bool IsInDesignMode() =>
            LicenseManager.UsageMode == LicenseUsageMode.Designtime || this.DesignMode;

        // Correct Load event handler
        private void EmpNotifications_Load(object sender, EventArgs e)
        {
            if (IsInDesignMode()) return;
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            try
            {
                using (var con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    // Exclude IsRead column
                    var query =
                        "SELECT ID, [Message], [NotificationDateTime], [CreatedBy] " +
                        "FROM tbl_notifs " +
                        "ORDER BY [NotificationDateTime] DESC";

                    using (var da = new OleDbDataAdapter(query, con))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgv_empNotifs.DataSource = dt;

                        // Adjust column headers or formatting
                        if (dgv_empNotifs.Columns.Contains("Message"))
                            dgv_empNotifs.Columns["Message"].HeaderText = "Notification";
                        if (dgv_empNotifs.Columns.Contains("NotificationDateTime"))
                            dgv_empNotifs.Columns["NotificationDateTime"].HeaderText = "Date/Time";
                        if (dgv_empNotifs.Columns.Contains("CreatedBy"))
                            dgv_empNotifs.Columns["CreatedBy"].HeaderText = "From";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading notifications: " + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
