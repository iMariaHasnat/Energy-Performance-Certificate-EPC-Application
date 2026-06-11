using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace EPCPROJECT
{
    public partial class Login_Form : Form
    {
        public static string usernameLocal;

        public Login_Form()
        {
            InitializeComponent();
        }


        OleDbConnection con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "db_users.mdb")}");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void label3_Click(object sender, EventArgs e)
        {

        }




        private void lbl_crosslog_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            {
                usernameLocal = txt_username.Text;

            }
            // 1. Check if a user type has been selected
            if (combobox_usertypelogin.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user type before logging in.", "User Type Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Get the user type, username, and password from the controls
            string selectedUserType = combobox_usertypelogin.SelectedItem.ToString();
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            // 3. Build a parameterized query to check for a matching record in tbl_users.
            //    Access table has fields: username, password, and usertype)
            string loginQuery = "SELECT * FROM tbl_users WHERE [username] = ? AND [password] = ? AND [usertype] = ?";

            try
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(loginQuery, con))
                {
                    // For OleDb, parameters are positional.
                    cmd.Parameters.AddWithValue("?", username);
                    cmd.Parameters.AddWithValue("?", password);
                    cmd.Parameters.AddWithValue("?", selectedUserType);

                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        // 4. Check if a matching record was found
                        if (dr.Read())
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Decide which form to open based on the user type
                            if (selectedUserType.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                admin_thirdDashboard adminForm = new admin_thirdDashboard();
                                adminForm.Show();
                                this.Hide();
                            }
                            else if (selectedUserType.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                            {
                                EmployeeDashboard employeeForm = new EmployeeDashboard();
                                employeeForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("User type not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username, password, or user type.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
            combobox_usertypelogin.Text = "";
            txt_username.Focus();
        }

        private void chk_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showpassword.Checked)
            {
                txt_password.PasswordChar = '\0';
            }

            else
            {
                txt_password.PasswordChar = '*';
            }
        }

        private void lbl_createacc_Click(object sender, EventArgs e)
        {
            var reqForm = new RequestAccountForm();
            reqForm.ShowDialog();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }


    }
    }


    


