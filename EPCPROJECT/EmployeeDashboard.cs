using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPCPROJECT
{
    public partial class EmployeeDashboard : Form
    {
        private string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "db_users.mdb")}";


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

        public void ShowOldEpcFiles()
        {
            empDashboardUserControl1.Hide();
            analyticsUserControl31.Hide();
            empNotifications1.Hide();
            settingsUserControl31.Hide();

            empData1.Show();
            empData1.BringToFront();
        }

        public void ShowAnalytics()
        {
            empDashboardUserControl1.Hide();
            empData1.Hide();
            empNotifications1.Hide();
            settingsUserControl31.Hide();

            analyticsUserControl31.Show();
            analyticsUserControl31.BringToFront();

        }

        public void ShowNotifications()
        {
            empDashboardUserControl1.Hide();
            empData1.Hide();
            analyticsUserControl31.Hide();
            settingsUserControl31.Hide();

            empNotifications1.Show();
            empNotifications1.BringToFront();


        }



        public EmployeeDashboard()
        {
            InitializeComponent();
            // Attach the Load event handler manually
            this.Load += new EventHandler(EmployeeDashboard_Load);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            
                ShowUnreadNotificationsAsToast();
                lbl_empUsername.Text = Login_Form.usernameLocal;

                // ** pull the saved picture when first show the form **
                LoadProfilePictureFromDb();


            // Hide all sub‑controls except the main dashboard
                empData1.Hide();
                analyticsUserControl31.Hide();
                empNotifications1.Hide();
                settingsUserControl31.Hide();

                empDashboardUserControl1.Show();
                empDashboardUserControl1.BringToFront();

        }

        /// <summary>
        /// Called by SettingsUserControl3 (and also on initial Load) to update the icon.
        /// </summary>


        public void UpdateProfilePicture(string newImagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(newImagePath) && File.Exists(newImagePath))
                    picBox_empUserIcon.Image = Image.FromFile(newImagePath);
            }
            catch
            {
                // swallow or log
            }
        }

        private void LoadProfilePictureFromDb()
        {
            var user = Login_Form.usernameLocal;
            if (string.IsNullOrEmpty(user)) return;

            using (var con = new OleDbConnection(connectionString))
            using (var cmd = new OleDbCommand(
                "SELECT ProfilePicturePath FROM tbl_users WHERE Username = ?", con))
            {
                cmd.Parameters.AddWithValue("?", user);
                con.Open();
                var obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    var path = obj.ToString();
                    if (File.Exists(path))
                        picBox_empUserIcon.Image = Image.FromFile(path);
                }
            }
        }




        private void btn_empDashboard_Click(object sender, EventArgs e)
        {
            empData1.Hide();
            analyticsUserControl31.Hide();
            empNotifications1.Hide();
            //settingsUserControl31.Hide();

            //Show current user control
            empDashboardUserControl1.Show();
            empDashboardUserControl1.BringToFront();

        }





        private void btn_empHelp_Click(object sender, EventArgs e)
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





        private void btn_empDashboard_Leave(object sender, EventArgs e)
        {
            btn_empDashboard.BackColor = Color.FromArgb(48, 25, 52);

        }



        private void btn_empHelp_Leave(object sender, EventArgs e)
        {

        }

        private void lbl_empCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowUnreadNotificationsAsToast()
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                con.Open();
                string query = "SELECT ID, [Message] FROM tbl_notifs WHERE [IsRead] = false";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string message = reader["Message"].ToString();
                            // Create and show toast
                            ToastForm toast = new ToastForm(message);
                            toast.Show();

                            // Mark notification as read
                            MarkNotificationAsRead(Convert.ToInt32(reader["ID"]), con);
                        }
                    }
                }
            }
        }

        private void MarkNotificationAsRead(int notifId, OleDbConnection con)
        {
            string updateQuery = "UPDATE tbl_notifs SET [IsRead] = true WHERE ID = ?";
            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, con))
            {
                updateCmd.Parameters.AddWithValue("?", notifId);
                updateCmd.ExecuteNonQuery();
            }
        }

        private void btn_empData_Click(object sender, EventArgs e)
        {
            empDashboardUserControl1.Hide();
            analyticsUserControl31.Hide();
            empNotifications1.Hide();
            //settingsUserControl31.Hide();

            //Show current user control
            empData1.Show();
            empData1.BringToFront();


        }

        private void btn_empAnalytics_Click(object sender, EventArgs e)
        {
            empDashboardUserControl1.Hide();
            empData1.Hide();
            empNotifications1.Hide();
            settingsUserControl31.Hide();

            //Show current user control
            analyticsUserControl31.Show();
            analyticsUserControl31.BringToFront();

        }

        private void btn_empNotifs_Click(object sender, EventArgs e)
        {
            empDashboardUserControl1.Hide();
            empData1.Hide();
            analyticsUserControl31.Hide();
            settingsUserControl31.Hide();

            //Show current user control
            empNotifications1.Show();
            empNotifications1.BringToFront();


        }

        private void btn_empSettings_Click(object sender, EventArgs e)
        {
            empDashboardUserControl1.Hide();
            empData1.Hide();
            analyticsUserControl31.Hide();
            empNotifications1.Hide();

            //Show current user control
            settingsUserControl31.Show();
            settingsUserControl31.BringToFront();

        }

        private void btn_empData_Leave(object sender, EventArgs e)
        {
            btn_empData.BackColor = Color.FromArgb(48, 25, 52);

        }

        private void btn_empAnalytics_Leave(object sender, EventArgs e)
        {
            btn_empAnalytics.BackColor = Color.FromArgb(48, 25, 52);

        }

        private void btn_empNotifs_Leave(object sender, EventArgs e)
        {
            btn_empNotifs.BackColor = Color.FromArgb(48, 25, 52);

        }

        private void btn_empSettings_Leave(object sender, EventArgs e)
        {
            btn_empSettings.BackColor = Color.FromArgb(48, 25, 52);

        }
    }
}





