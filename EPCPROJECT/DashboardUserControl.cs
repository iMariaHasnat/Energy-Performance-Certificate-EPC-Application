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
using System.Data.OleDb;


namespace EPCPROJECT
{
    public partial class DashboardUserControl3 : UserControl
    {
        public DashboardUserControl3()
        {
            InitializeComponent();
            // wire up Load if not already in Designer
            this.Load += DashboardUserControl3_Load;
        }

        private void DashboardUserControl3_Load(object sender, EventArgs e)
        {
            // skip in the designer
            if (this.DesignMode ||
                LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            string dbPath = Path.Combine(Application.StartupPath, "db_users.mdb");
            string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";

            try
            {
                using (var con = new OleDbConnection(connStr))
                using (var cmd = new OleDbCommand("SELECT COUNT(*) FROM tbl_users", con))
                {
                    con.Open();
                    var result = cmd.ExecuteScalar();
                    int total = (result != null && result != DBNull.Value)
                                ? Convert.ToInt32(result)
                                : 0;
                    txt_totalusers.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading total users: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btn_dashbManageUsers_Click(object sender, EventArgs e)
        {
            var parent = this.FindForm() as admin_thirdDashboard;
            parent?.ShowUserManagement();
        }

        private void btn_dashbImportEPC_Click(object sender, EventArgs e)
        {
            var parent = this.FindForm() as admin_thirdDashboard;
            parent?.ShowDataUpdate();
        }

        private void btn_dashbViewNotifs_Click(object sender, EventArgs e)
        {
            var parent = this.FindForm() as admin_thirdDashboard;
            parent?.ShowNotifications();
        }

    }
}
