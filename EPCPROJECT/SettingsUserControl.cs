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
using System.Text.RegularExpressions;

namespace EPCPROJECT
{
    public partial class SettingsUserControl3 : UserControl
    {
        // Connection string to your Access database.
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\maria\\Desktop\\FinalYearProject\\EPCPROJECT\\EPCPROJECT\\bin\\Debug\\db_users.mdb";


        public SettingsUserControl3()
        {
            InitializeComponent();
            this.Load -= SettingsUserControl3_Load;
            this.Load += SettingsUserControl3_Load;


        }

        private void SettingsUserControl3_Load(object sender, EventArgs e)
        {
            string currentUsername = Login_Form.usernameLocal;
            if (string.IsNullOrEmpty(currentUsername)) return;

            string safeUser = currentUsername.Replace("'", "''");
            string query =
              $"SELECT Email, ProfilePicturePath " +
              $"FROM tbl_users " +
              $"WHERE [Username] = '{safeUser}'";

            try
            {
                using (var con = new OleDbConnection(connectionString))
                using (var cmd = new OleDbCommand(query, con))
                {
                    con.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txt_settingsEmail.Text = dr["Email"].ToString();
                            var picPath = dr["ProfilePicturePath"].ToString();
                            if (!string.IsNullOrEmpty(picPath) && File.Exists(picPath))
                                picBox_profileChange.Image = Image.FromFile(picPath);

                            // ** Update any open dashboards **
                            foreach (var admin in Application.OpenForms.OfType<admin_thirdDashboard>())
                                admin.UpdateProfilePicture(picPath);
                            foreach (var emp in Application.OpenForms.OfType<EmployeeDashboard>())
                                emp.UpdateProfilePicture(picPath);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                  "Error loading settings: " + ex.Message,
                  "Database Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }

        private void btn_profileChange_Click(object sender, EventArgs e)
    {
        using (var ofd = new OpenFileDialog())
        {
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() != DialogResult.OK) return;

            try
            {
                string sourceFile = ofd.FileName;
                string ext = Path.GetExtension(sourceFile);
                string currentUsername = Login_Form.usernameLocal;

                string folderPath = Path.Combine(Application.StartupPath, "ProfilePics");
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string newFileName = $"{currentUsername}_{DateTime.Now:yyyyMMddHHmmss}{ext}";
                string destPath = Path.Combine(folderPath, newFileName);
                File.Copy(sourceFile, destPath, true);

                using (var con = new OleDbConnection(connectionString))
                using (var cmd = new OleDbCommand(
                    "UPDATE tbl_users SET ProfilePicturePath = ? WHERE Username = ?", con))
                {
                    cmd.Parameters.AddWithValue("?", destPath);
                    cmd.Parameters.AddWithValue("?", currentUsername);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Profile picture updated successfully.", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // ** Update any open dashboards **
                        foreach (var admin in Application.OpenForms.OfType<admin_thirdDashboard>())
                            admin.UpdateProfilePicture(destPath);
                        foreach (var emp in Application.OpenForms.OfType<EmployeeDashboard>())
                                emp.UpdateProfilePicture(destPath);

                        }
                    else
                    {
                        MessageBox.Show("Failed to update profile picture in the database.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile picture: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    private void btn_updatecontactSettings_Click(object sender, EventArgs e)
        {
            {
                string newEmail = txt_settingsEmail.Text.Trim();
                if (string.IsNullOrEmpty(newEmail))
                {
                    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string currentUsername = Login_Form.usernameLocal;
                try
                {
                    using (OleDbConnection con = new OleDbConnection(connectionString))
                    {
                        con.Open();
                        string query = "UPDATE tbl_users SET Email = ? WHERE Username = ?";
                        using (OleDbCommand cmd = new OleDbCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("?", newEmail);
                            cmd.Parameters.AddWithValue("?", currentUsername);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Contact details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to update contact details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating contact details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_changePword_Click(object sender, EventArgs e)
        {
            string currentPassword = txt_currentPword.Text;
            string newPassword = txt_newPword.Text;
            string confirmPassword = txt_confirmPword.Text;
            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string currentUsername = Login_Form.usernameLocal;
            try
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    // Verify that the current password is correct.
                    string selectQuery = "SELECT COUNT(*) FROM tbl_users WHERE Username = ? AND [Password] = ?";
                    using (OleDbCommand selectCmd = new OleDbCommand(selectQuery, con))
                    {
                        selectCmd.Parameters.AddWithValue("?", currentUsername);
                        selectCmd.Parameters.AddWithValue("?", currentPassword);
                        int count = (int)selectCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Update the password in the database.
                    string updateQuery = "UPDATE tbl_users SET [Password] = ? WHERE Username = ?";
                    using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("?", newPassword);
                        updateCmd.Parameters.AddWithValue("?", currentUsername);
                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Password update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }




