using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EPCPROJECT
{
    public partial class OldEpcFiles : Form
    {
        public OldEpcFiles()
        {
            InitializeComponent();
            dataGridViewOldFiles.CellContentClick += dataGridViewOldFiles_CellContentClick;
        }
        private void OldEpcFiles_Load_1(object sender, EventArgs e)
        {

            dataGridViewOldFiles.AllowUserToAddRows = false;

            if (!File.Exists("uploaded_files.txt")) return;

            dataGridViewOldFiles.Columns.Clear();
            dataGridViewOldFiles.Rows.Clear();

            dataGridViewOldFiles.Columns.Add("FileName", "File Name");
            dataGridViewOldFiles.Columns.Add("Timestamp", "Imported On");

            // Add Download button
            DataGridViewButtonColumn downloadBtn = new DataGridViewButtonColumn();
            downloadBtn.Text = "Download";
            downloadBtn.UseColumnTextForButtonValue = true;
            downloadBtn.Name = "Download";
            dataGridViewOldFiles.Columns.Add(downloadBtn);

            // Add Delete button
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.Text = "Delete";
            deleteBtn.UseColumnTextForButtonValue = true;
            deleteBtn.Name = "Delete";
            dataGridViewOldFiles.Columns.Add(deleteBtn);

            var lines = File.ReadAllLines("uploaded_files.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string name = parts[0];
                    string path = parts[1];
                    string time = parts[2];

                    int rowIndex = dataGridViewOldFiles.Rows.Add(name, time);
                    dataGridViewOldFiles.Rows[rowIndex].Tag = path;
                }
            }

        }

        private void dataGridViewOldFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check for header clicks or invalid rows
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewOldFiles.Rows.Count)
                return;

            var row = dataGridViewOldFiles.Rows[e.RowIndex];
            var filePath = row.Tag as string;

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("File path not found for this entry.");
                return;
            }

            if (e.ColumnIndex == dataGridViewOldFiles.Columns["Download"].Index)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = Path.GetFileName(filePath);
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(filePath, saveDialog.FileName, true);
                        MessageBox.Show("File downloaded successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error downloading file: " + ex.Message);
                    }
                }
            }

            if (e.ColumnIndex == dataGridViewOldFiles.Columns["Delete"].Index)
            {
                var confirm = MessageBox.Show("Delete this file from the list?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        var allLines = File.Exists("uploaded_files.txt")
                            ? File.ReadAllLines("uploaded_files.txt").ToList()
                            : new List<string>();

                        allLines = allLines.Where(line => !line.Contains(filePath)).ToList();
                        File.WriteAllLines("uploaded_files.txt", allLines);

                        // Safely remove the row
                        dataGridViewOldFiles.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting file: " + ex.Message);
                    }

                    // Optional: Debug
                    // MessageBox.Show($"Debug: path = {filePath ?? "null"}");
                }
            }
            }

        private void lbl_oldEPCsCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }


