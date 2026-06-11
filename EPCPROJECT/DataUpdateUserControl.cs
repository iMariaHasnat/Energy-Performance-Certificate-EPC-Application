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
using ExcelDataReader;
using System.Data.OleDb;

namespace EPCPROJECT
{
    public partial class DataUpdateControl3 : UserControl
    {
        private DataTable importedData;


        private string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\db_users.mdb";
        public DataUpdateControl3()
        {
            InitializeComponent();

        }

        // This button click event handles importing the Excel data.
        private void btn_import_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });

                        // I want to read the first sheet
                        DataTable dt = result.Tables[0];
                        dataGridView_recentepc.DataSource = dt;
                    }
                }

                string fileName = Path.GetFileName(filePath);
                string timestamp = DateTime.Now.ToString();
                string entry = $"{fileName}|{filePath}|{timestamp}";
                File.AppendAllText("uploaded_files.txt", entry + Environment.NewLine);

                // Show the success message to the admin.
                MessageBox.Show("Data imported successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) ;

            }
        }


        private void btn_oldepcfiles_Click(object sender, EventArgs e)
        {
            OldEpcFiles old = new OldEpcFiles();
            old.Show();
        }

        private void dataGridView_recentepc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void InsertNotification(string message, string createdBy)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    // Use exact field names as defined in your table.
                    // I renamed the date field to NotificationDateTime.
                    string query = "INSERT INTO tbl_notifs ([Message], [NotificationDateTime], [CreatedBy], [IsRead]) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        // Instead of AddWithValue, add parameters with explicit types:

                        // [Message]: Short Text → use OleDbType.VarWChar
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = message;

                        // [NotificationDateTime]: Date/Time → use OleDbType.Date
                        cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;

                        // [CreatedBy]: Short Text → use OleDbType.VarWChar
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = createdBy;

                        // [IsRead]: Yes/No → use OleDbType.Boolean
                        cmd.Parameters.Add("?", OleDbType.Boolean).Value = false;

                        int rowsAffected = cmd.ExecuteNonQuery();
                        //MessageBox.Show("Rows affected: " + rowsAffected);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting notification: " + ex.Message,
                                "Notification Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }




        private void btn_sendNotif_Click(object sender, EventArgs e)
        {
            // 1. Create the notification message you want employees to see
            string notificationMessage = "New EPC data update is available!";

            // 2. Insert the notification into your tbl_notifs
            //    If the currently logged in user is an admin, you might do:
            InsertNotification(notificationMessage, Login_Form.usernameLocal);

            // 3. Optional: show a confirmation to the admin
            MessageBox.Show("Notification has been sent to employees!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
