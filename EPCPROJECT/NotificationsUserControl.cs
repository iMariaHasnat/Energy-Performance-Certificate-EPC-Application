using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPCPROJECT
{
    public partial class NotificationsUserControl3 : UserControl
    {
        // Connection string points to the database in the output folder.
        private string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "db_users.mdb")}";

        public NotificationsUserControl3()
        {
            InitializeComponent();
            // Attach the Load event if it isn't already wired up via the designer.
            this.Load += new EventHandler(NotificationsUserControl_Load);
        }

        // Helper method to check if we're in design mode.
        private bool IsInDesignMode()
        {
            return (LicenseManager.UsageMode == LicenseUsageMode.Designtime) || this.DesignMode;
        }

        private void NotificationsUserControl_Load(object sender, EventArgs e)
        {
            // Only load notifications at runtime.
            if (!IsInDesignMode())
            {
                LoadNotifications();
            }
        }

        private void LoadNotifications()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    // Adjust the query with exact column names.
                    string query = "SELECT ID, [Message], [NotificationDateTime], [CreatedBy], [IsRead] FROM tbl_notifs ORDER BY [NotificationDateTime] DESC";
                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView_notifications.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notifications: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



