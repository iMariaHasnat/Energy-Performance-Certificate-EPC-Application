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
    public partial class helpandcontact : Form
    {
        // Connection string pointing to your Access database containing tbl_helpfrm
        private readonly string connectionString =
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "db_users.mdb")}";

        private const string PlaceholderUsername = "Enter your username";
        private const string PlaceholderEmail = "Enter your email address";
        private const string PlaceholderSubject = "Enter subject";
        private const string PlaceholderMessage = "Enter your message";
        public helpandcontact()
        {
            InitializeComponent();

            // Prevent duplicate event subscriptions
            btn_sndmsg.Click -= btn_sndmsg_Click;
            btn_sndmsg.Click += btn_sndmsg_Click;

            // Setup placeholders for textboxes
            SetupPlaceholder(txt_helpUsername, PlaceholderUsername);
            SetupPlaceholder(txt_emailadd, PlaceholderEmail);
            SetupPlaceholder(txt_subject, PlaceholderSubject);
            SetupPlaceholder(txt_msg, PlaceholderMessage);
        }

        private void SetupPlaceholder(TextBox tb, string placeholder)
        {
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;

            tb.GotFocus += (s, e) =>
            {
                if (tb.Text == placeholder && tb.ForeColor == Color.Gray)
                {
                    tb.Text = string.Empty;
                    tb.ForeColor = Color.Black;
                }
            };

            tb.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                }
            };
        }


        private void lbl_helpcross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpandcontact_Load(object sender, EventArgs e)
        {
            comboBox_category.Items.AddRange(new[] { "General", "Bug Report", "Feature Request" });

        }

        private void btn_sndmsg_Click(object sender, EventArgs e)
        {
            // Gather inputs, ignoring placeholders
            string username = (txt_helpUsername.ForeColor == Color.Gray) ? string.Empty : txt_helpUsername.Text.Trim();
            string email = (txt_emailadd.ForeColor == Color.Gray) ? string.Empty : txt_emailadd.Text.Trim();
            string subject = (txt_subject.ForeColor == Color.Gray) ? string.Empty : txt_subject.Text.Trim();
            string category = comboBox_category.SelectedItem?.ToString().Trim() ?? string.Empty;
            string messageDesc = (txt_msg.ForeColor == Color.Gray) ? string.Empty : txt_msg.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(category) ||
                string.IsNullOrEmpty(messageDesc))
            {
                MessageBox.Show(
                    "Please fill in all fields before sending your message.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (var con = new OleDbConnection(connectionString))
                using (var cmd = new OleDbCommand(
                    "INSERT INTO tbl_helpfrm ([username],[email_address],[subject],[category],[message desc]) VALUES (?,?,?,?,?)", con))
                {
                    // Positional parameters for OleDb
                    cmd.Parameters.AddWithValue("?", username);
                    cmd.Parameters.AddWithValue("?", email);
                    cmd.Parameters.AddWithValue("?", subject);
                    cmd.Parameters.AddWithValue("?", category);
                    cmd.Parameters.AddWithValue("?", messageDesc);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show(
                            "Your message has been sent. We will get back to you shortly!",
                            "Message Sent",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Failed to send your message. Please try again.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while sending your message: {ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }   
    }

