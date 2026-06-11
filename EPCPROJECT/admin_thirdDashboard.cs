using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.OleDb;



namespace EPCPROJECT
{
    public partial class admin_thirdDashboard : Form
    {
        // add a connectionString here (or pull it from a shared config)
        private string connectionString =
          "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
          Path.Combine(Application.StartupPath, "db_users.mdb");


        public object UserManagementUserControl1 { get; private set; }
        public object DataUpdateControl21 { get; private set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );



        public void ShowUserManagement()
        {
            dashboardUserControl31.Hide();
            dataUpdateControl31.Hide();
            analyticsUserControl31.Hide();
            notificationsUserControl31.Hide();
            settingsUserControl31.Hide();

            userManagementUserControl31.Show();
            userManagementUserControl31.BringToFront();

            // move the nav bar, highlight the button…
            pnl_thirdadSideNav.Height = btn_thirdadUserManage.Height;
            pnl_thirdadSideNav.Top = btn_thirdadUserManage.Top;
            btn_thirdadUserManage.BackColor = Color.FromArgb(46, 51, 73);
        }

        public void ShowDataUpdate()
        {
            dashboardUserControl31.Hide();
            userManagementUserControl31.Hide();
            analyticsUserControl31.Hide();
            notificationsUserControl31.Hide();
            settingsUserControl31.Hide();

            dataUpdateControl31.Show();
            dataUpdateControl31.BringToFront();

            pnl_thirdadSideNav.Height = btn_thirdadUpdate.Height;
            pnl_thirdadSideNav.Top = btn_thirdadUpdate.Top;
            btn_thirdadUpdate.BackColor = Color.FromArgb(46, 51, 73);
        }

        public void ShowNotifications()
        {
            dashboardUserControl31.Hide();
            dataUpdateControl31.Hide();
            analyticsUserControl31.Hide();
            userManagementUserControl31.Hide();
            settingsUserControl31.Hide();

            notificationsUserControl31.Show();
            notificationsUserControl31.BringToFront();

            pnl_thirdadSideNav.Height = btn_thirdadNotifs.Height;
            pnl_thirdadSideNav.Top = btn_thirdadNotifs.Top;
            btn_thirdadNotifs.BackColor = Color.FromArgb(46, 51, 73);
        }


        public admin_thirdDashboard()
        {
            InitializeComponent();
            Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Width, Height, 25, 25)
            );

            // Wire up Load event
            Load += admin_thirdDashboard_Load;
        }




        public void UpdateProfilePicture(string newImagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(newImagePath) && File.Exists(newImagePath))
                {
                    picBox_thirdadUser.Image = Image.FromFile(newImagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating dashboard profile picture: " + ex.Message);
            }
        }


        private void admin_thirdDashboard_Load(object sender, EventArgs e)
        {
            lbl_thirdadUsername.Text = Login_Form.usernameLocal;
            LoadProfilePictureFromDb();

            // initialize your first tab
            dataUpdateControl31.Hide();
            analyticsUserControl31.Hide();
            userManagementUserControl31.Hide();
            notificationsUserControl31.Hide();
            settingsUserControl31.Hide();
            dashboardUserControl31.Show();
            dashboardUserControl31.BringToFront();

            // check pending requests toast...
            CheckPendingRequests();
        }

        private void CheckPendingRequests()
        {
            int count;
            using (var con = new OleDbConnection(connectionString))
            using (var cmd = new OleDbCommand(
                "SELECT COUNT(*) FROM tbl_requests WHERE Status = 'Pending'", con))
            {
                con.Open();
                count = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
            }

            if (count > 0)
            {
                string msg = $"You have {count} pending account request{(count > 1 ? "s" : "")}.";
                var toast = new AccsReqsToastForm(msg);
                toast.StartPosition = FormStartPosition.Manual;
                // position near bottom‑right of this dashboard
                toast.Location = new Point(
                    this.Location.X + this.Width - toast.Width - 10,
                    this.Location.Y + this.Height - toast.Height - 10
                );
                toast.Show();
            }
        }


        /// <summary>
        /// Reads ProfilePicturePath from tbl_users and sets picBox_thirdadUser.
        /// </summary>
        private void LoadProfilePictureFromDb()
        {
            var user = Login_Form.usernameLocal;
            if (string.IsNullOrEmpty(user))
                return;

            using (var con = new OleDbConnection(connectionString))
            using (var cmd = new OleDbCommand(
                       "SELECT ProfilePicturePath FROM tbl_users WHERE Username = ?", con))
            {
                // positional parameter for the single '?'
                cmd.Parameters.AddWithValue("?", user);
                con.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    var path = result.ToString();
                    if (File.Exists(path))
                        picBox_thirdadUser.Image = Image.FromFile(path);
                }
            }
        }

        /// <summary>
        /// Called immediately after the user picks a new image in Settings.
        /// </summary>

        private void btn_thirdadDashboard_Click(object sender, EventArgs e)
        {
            //Hide these user controls

            dataUpdateControl31.Hide();
            analyticsUserControl31.Hide();
            userManagementUserControl31.Hide();
            notificationsUserControl31.Hide();
            settingsUserControl31.Hide();

            //Show current user control
            dashboardUserControl31.Show();
            dashboardUserControl31.BringToFront();

            pnl_thirdadSideNav.Height = btn_thirdadDashboard.Height;
            pnl_thirdadSideNav.Top = btn_thirdadDashboard.Top;
            pnl_thirdadSideNav.Left = btn_thirdadDashboard.Left;
            btn_thirdadDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_thirdadUpdate_Click(object sender, EventArgs e)
        {
            //Hide these user controls

            dashboardUserControl31.Hide();
            analyticsUserControl31.Hide();
            userManagementUserControl31.Hide();
            notificationsUserControl31.Hide();
            settingsUserControl31.Hide();

            //Show current user control
            dataUpdateControl31.Show();
            dataUpdateControl31.BringToFront();

            pnl_thirdadSideNav.Height = btn_thirdadUpdate.Height;
            pnl_thirdadSideNav.Top = btn_thirdadUpdate.Top;
            btn_thirdadUpdate.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_thirdadAnalytics_Click(object sender, EventArgs e)
        {
            //Hide these user controls

            dashboardUserControl31.Hide();
            dataUpdateControl31.Hide();
            userManagementUserControl31.Hide();
            notificationsUserControl31.Hide();
            settingsUserControl31.Hide();

            //Show current user control
            analyticsUserControl31.Show();
            analyticsUserControl31.BringToFront();

            pnl_thirdadSideNav.Height = btn_thirdadAnalytics.Height;
            pnl_thirdadSideNav.Top = btn_thirdadAnalytics.Top;
            btn_thirdadAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_thirdadUserManage_Click(object sender, EventArgs e)
        {

            dashboardUserControl31.Hide();
            dataUpdateControl31.Hide();
            analyticsUserControl31.Hide();
            notificationsUserControl31.Hide();
            settingsUserControl31.Hide();

            //Show current user control
            userManagementUserControl31.Show();
            userManagementUserControl31.BringToFront();

            pnl_thirdadSideNav.Height = btn_thirdadUserManage.Height;
            pnl_thirdadSideNav.Top = btn_thirdadUserManage.Top;
            btn_thirdadUserManage.BackColor = Color.FromArgb(46, 51, 73);
        }


        private void btn_thirdadSettings_Click(object sender, EventArgs e)
        {
            dashboardUserControl31.Hide();
            dataUpdateControl31.Hide();
            analyticsUserControl31.Hide();
            userManagementUserControl31.Hide();
            notificationsUserControl31.Hide();

            //Show current user control
            settingsUserControl31.Show();
            settingsUserControl31.BringToFront();

            pnl_thirdadSideNav.Height = btn_thirdadSettings.Height;
            pnl_thirdadSideNav.Top = btn_thirdadSettings.Top;
            btn_thirdadSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_thirdadDashboard_Leave(object sender, EventArgs e)
        {
            btn_thirdadDashboard.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btn_thirdadUpdate_Leave(object sender, EventArgs e)
        {
            btn_thirdadUpdate.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btn_thirdadAnalytics_Leave(object sender, EventArgs e)
        {
            btn_thirdadAnalytics.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btn_thirdadUserManage_Leave(object sender, EventArgs e)
        {
            btn_thirdadUserManage.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btn_thirdadNotifs_Leave(object sender, EventArgs e)
        {
            btn_thirdadNotifs.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btn_thirdadSettings_Leave(object sender, EventArgs e)
        {
            btn_thirdadSettings.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void lbl_thirdadCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_adminHelp_Click(object sender, EventArgs e)
        {
            // See if the help form is already open
            var existing = Application.OpenForms
                               .OfType<helpandcontact>()
                               .FirstOrDefault();
            if (existing != null)
            {
                MessageBox.Show(
                    "The Help form is already open.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                existing.BringToFront();
                return;
            }

            // Otherwise, open a new one
            var helpfrm = new helpandcontact();
            helpfrm.Show();
        }

        private void txtBox_adminSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thirdadNotifs_Click_1(object sender, EventArgs e)
        {
            dashboardUserControl31.Hide();
            dataUpdateControl31.Hide();
            analyticsUserControl31.Hide();
            userManagementUserControl31.Hide();
            settingsUserControl31.Hide();

            //Show current user control
            notificationsUserControl31.Show();
            notificationsUserControl31.BringToFront();

            pnl_thirdadSideNav.Height = btn_thirdadNotifs.Height;
            pnl_thirdadSideNav.Top = btn_thirdadNotifs.Top;
            btn_thirdadNotifs.BackColor = Color.FromArgb(46, 51, 73);
        }
    }
}
