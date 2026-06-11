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
    public partial class RequestAccountForm : Form
    {
        private readonly string _connStr =
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\db_users.mdb";

        public RequestAccountForm()
        {
            InitializeComponent();

            // Only populate once:
            cmb_ReqUserType.Items.Clear();
            cmb_ReqUserType.Items.Add("Employee");
            cmb_ReqUserType.Items.Add("Admin");
            cmb_ReqUserType.SelectedIndex = 0;

            // Make sure you only wire the Submit click once!
            // If you already hooked this up in the Designer, remove the next line:
            //btn_ReqSubmit.Click += btn_ReqSubmit_Click;

            // Cancel
            btn_ReqCancel.Click += (s, e) => Close();
        }

        private void lbl_reqfrmCross_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ReqSubmit_Click(object sender, EventArgs e)
        {
            // 1) Trim & validate inputs
            var user = txt_ReqUsername.Text.Trim();
            var email = txt_ReqEmail.Text.Trim();
            var type = cmb_ReqUserType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(user) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(type))
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2) Email format check
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show(
                    "Please enter a valid email address (e.g. user@example.com).",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txt_ReqEmail.Focus();
                return;
            }

            // 3) Insert into tbl_requests
            const string sql = @"
        INSERT INTO tbl_requests
          (Username, Email, UserType, RequestDate, Status)
        VALUES (?, ?, ?, ?, 'Pending')";
            try
            {
                using (var con = new OleDbConnection(_connStr))
                using (var cmd = new OleDbCommand(sql, con))
                {
                    cmd.Parameters.Add("Username", OleDbType.VarChar).Value = user;
                    cmd.Parameters.Add("Email", OleDbType.VarChar).Value = email;
                    cmd.Parameters.Add("UserType", OleDbType.VarChar).Value = type;
                    cmd.Parameters.Add("RequestDate", OleDbType.Date).Value = DateTime.Now;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                // 4) Notify any open Admin dashboards via toast
                string toastMsg = $"New account request from {user}";
                foreach (var admin in Application.OpenForms.OfType<admin_thirdDashboard>())
                {
                    var toast = new AccsReqsToastForm(toastMsg);
                    toast.Show();
                }

                // 5) Confirm to the requester
                MessageBox.Show(
                    "Your request has been sent. Admin will review it shortly.",
                    "Request Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error submitting request:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

