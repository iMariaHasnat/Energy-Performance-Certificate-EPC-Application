using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPCPROJECT
{
    public partial class UserManagementUserControl3 : UserControl
    {
        // Helper method for design mode detection.
        private bool IsInDesignMode()
        {
            return (LicenseManager.UsageMode == LicenseUsageMode.Designtime) || this.DesignMode;
        }

        private string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={System.IO.Path.Combine(Application.StartupPath, "db_users.mdb")}";

        public UserManagementUserControl3()
        {
            InitializeComponent();

            // Set up DataGridView behavior
            dataGridView_usermanage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_usermanage.ReadOnly = false;
            dataGridView_usermanage.AllowUserToAddRows = false;
            dataGridView_usermanage.AllowUserToDeleteRows = false;

            // Add event handler for cell clicks on the grid
            dataGridView_usermanage.CellClick += dataGridView_usermanage_CellClick;
        }

        private void UserManagementUserControl_Load(object sender, EventArgs e)
        {
            // Only load users if not in design mode.
            if (!IsInDesignMode())
            {
                LoadUsers();
            }
        }


        private void LoadUsers()
        {
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tbl_users", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_usermanage.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading users: " + ex.Message);
                }
            }
        }


        private void btn_registeruser_Click(object sender, EventArgs e)
        {
            Register registeruser = new Register();
            registeruser.Show();
        }


        private void btn_searchUser_Click(object sender, EventArgs e)
        {
            string username = txt_uname_usermanage.Text.Trim();
            string email = txt_email_usermanage.Text.Trim();
            string usertype = combobx_usertype_usermanage.Text.Trim();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM tbl_users WHERE 1=1";
                    if (!string.IsNullOrEmpty(username)) query += " AND username LIKE '%" + username + "%'";
                    if (!string.IsNullOrEmpty(email)) query += " AND email LIKE '%" + email + "%'";
                    if (!string.IsNullOrEmpty(usertype)) query += " AND usertype = '" + usertype + "'";

                    OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_usermanage.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching users: " + ex.Message);
                }
            }
        }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            if (dataGridView_usermanage.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_usermanage.SelectedRows[0];

                if (!int.TryParse(selectedRow.Cells["ID"].Value.ToString(), out int id))
                {
                    MessageBox.Show("Could not find a valid user ID to update.");
                    return;
                }

                string username = txt_uname_usermanage.Text.Trim();
                string email = txt_email_usermanage.Text.Trim();
                string usertype = combobx_usertype_usermanage.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(usertype))
                {
                    MessageBox.Show("Please fill all fields to update.");
                    return;
                }

                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        string query = "UPDATE tbl_users SET username=?, email=?, usertype=? WHERE ID=?";
                        using (OleDbCommand cmd = new OleDbCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("?", username);
                            cmd.Parameters.AddWithValue("?", email);
                            cmd.Parameters.AddWithValue("?", usertype);
                            cmd.Parameters.AddWithValue("?", id);

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("User updated successfully.");
                                LoadUsers(); // Refresh grid
                            }
                            else
                            {
                                MessageBox.Show("Update failed. No rows were affected.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating user: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user from the list to update.");
            }
        }


        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView_usermanage.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_usermanage.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (OleDbConnection con = new OleDbConnection(connectionString))
                    {
                        try
                        {
                            con.Open();
                            OleDbCommand cmd = new OleDbCommand("DELETE FROM tbl_users WHERE ID=?", con);
                            cmd.Parameters.AddWithValue("?", id);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("User deleted successfully.");
                            LoadUsers();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting user: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void dataGridView_usermanage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_usermanage.Rows[e.RowIndex];
                txt_uname_usermanage.Text = row.Cells["username"].Value.ToString();
                txt_email_usermanage.Text = row.Cells["email"].Value.ToString();
                combobx_usertype_usermanage.Text = row.Cells["usertype"].Value.ToString();
            }
        }

        private void btn_SeeReqs_Click(object sender, EventArgs e)
        {
            var reqForm = new AccountsRequests();
            reqForm.ShowDialog();

        }
    }
    }


