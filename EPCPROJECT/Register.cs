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
using System.Text.RegularExpressions;

namespace EPCPROJECT
{
    public partial class Register : Form
    {
        private int _requestId = -1;

        // new overload for approving a request
        public Register(string username, string email, string userType, int requestId)
            : this()   // call parameterless ctor
        {
            _requestId = requestId;

            // pre‑fill the fields
            txt_Username.Text = username;
            txt_EmailReg.Text = email;
            combobox_usertypereg.SelectedItem = userType;

            // optionally disable changing some fields:
            txt_Username.Enabled = false;
            txt_EmailReg.Enabled = false;
            combobox_usertypereg.Enabled = false;
        }
        public Register()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = db_users.mdb");


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();



        private void lbl_crossreg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // 1) Check required fields
            if (string.IsNullOrWhiteSpace(txt_Username.Text) ||
                string.IsNullOrWhiteSpace(txt_Password.Text) ||
                string.IsNullOrWhiteSpace(txt_confirmpassword.Text) ||
                string.IsNullOrWhiteSpace(txt_EmailReg.Text))
            {
                MessageBox.Show("Please fill in all required fields.",
                                "Registration Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string username = txt_Username.Text.Trim();
            string password = txt_Password.Text;
            string confirm = txt_confirmpassword.Text;
            string email = txt_EmailReg.Text.Trim();

            // 2) Email validation
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.",
                                "Registration Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txt_EmailReg.Focus();
                return;
            }

            // 3) Password == confirmation
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match. Please re‑enter.",
                                "Registration Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txt_Password.Clear();
                txt_confirmpassword.Clear();
                txt_Password.Focus();
                return;
            }

            // 4) Password complexity: at least 1 uppercase, 1 digit, 1 special
            //    you can adjust the special‑chars class as needed
            const string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_\-+=\[{\]};:'"",<.>/?\\|`~]).+$";
            if (!Regex.IsMatch(password, pattern))
            {
                MessageBox.Show(
                  "Password must contain at least:\n" +
                  "- One uppercase letter (A–Z)\n" +
                  "- One digit (0–9)\n" +
                  "- One special character (!@#$%^&*, etc.)",
                  "Weak Password",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );
                txt_Password.Clear();
                txt_confirmpassword.Clear();
                txt_Password.Focus();
                return;
            }

            // 5) User type selected?
            if (combobox_usertypereg.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user type.",
                                "Registration Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            string usertype = combobox_usertypereg.SelectedItem.ToString();
            const string registerQuery =
              "INSERT INTO tbl_users ([username],[password],[usertype],[email]) " +
              "VALUES (?,?,?,?)";

            try
            {
                // wrap the main connection in a using so it always disposes/closes
                using (var conMain = new OleDbConnection(con.ConnectionString))
                {
                    conMain.Open();
                    using (var cmd = new OleDbCommand(registerQuery, conMain))
                    {
                        cmd.Parameters.AddWithValue("?", username);
                        cmd.Parameters.AddWithValue("?", password);
                        cmd.Parameters.AddWithValue("?", usertype);
                        cmd.Parameters.AddWithValue("?", email);
                        cmd.ExecuteNonQuery();
                    }

                    // if this was an account‑request, update its status
                    if (_requestId > 0)
                    {
                        const string upd =
                          "UPDATE tbl_requests SET Status='Approved' WHERE RequestID = ?";
                        using (var cmd2 = new OleDbCommand(upd, conMain))
                        {
                            cmd2.Parameters.AddWithValue("?", _requestId);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show(
                  "User created and request marked approved.",
                  "Success",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                  "Error during registration:\n" + ex.Message,
                  "Database Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Showpassword.Checked)
            {
                txt_Password.PasswordChar = '\0';
                txt_confirmpassword.PasswordChar = '\0';
            }

            else
            {
                txt_Password.PasswordChar = '*';
                txt_confirmpassword.PasswordChar = '*';
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_confirmpassword.Text = "";
            combobox_usertypereg.Text = "";
            txt_Username.Focus();
            txt_EmailReg.Text = "";
        }

    }
}
