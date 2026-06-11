namespace EPCPROJECT
{
    partial class FilterMoreData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_filtermoreDCross = new System.Windows.Forms.Label();
            this.lbl_filtermoreDtitle = new System.Windows.Forms.Label();
            this.btn_FilterImportData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_downloadData = new System.Windows.Forms.Button();
            this.lbl_fmdRating = new System.Windows.Forms.Label();
            this.txt_fmdRating = new System.Windows.Forms.TextBox();
            this.lbl_fmdCity = new System.Windows.Forms.Label();
            this.txt_fmdCity = new System.Windows.Forms.TextBox();
            this.lbl_fmdTo = new System.Windows.Forms.Label();
            this.lbl_fmdFrom = new System.Windows.Forms.Label();
            this.dtp_fmdFrom = new System.Windows.Forms.DateTimePicker();
            this.dtp_fmdTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_NumberofProperties = new System.Windows.Forms.Label();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_pieChart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.lbl_filtermoreDtitle);
            this.panel1.Controls.Add(this.lbl_filtermoreDCross);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 42);
            this.panel1.TabIndex = 0;
            // 
            // lbl_filtermoreDCross
            // 
            this.lbl_filtermoreDCross.AutoSize = true;
            this.lbl_filtermoreDCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_filtermoreDCross.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtermoreDCross.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_filtermoreDCross.Location = new System.Drawing.Point(818, 7);
            this.lbl_filtermoreDCross.Name = "lbl_filtermoreDCross";
            this.lbl_filtermoreDCross.Size = new System.Drawing.Size(29, 27);
            this.lbl_filtermoreDCross.TabIndex = 11;
            this.lbl_filtermoreDCross.Text = "X";
            this.lbl_filtermoreDCross.Click += new System.EventHandler(this.lbl_filtermoreDCross_Click);
            // 
            // lbl_filtermoreDtitle
            // 
            this.lbl_filtermoreDtitle.AutoSize = true;
            this.lbl_filtermoreDtitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_filtermoreDtitle.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtermoreDtitle.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_filtermoreDtitle.Location = new System.Drawing.Point(12, 7);
            this.lbl_filtermoreDtitle.Name = "lbl_filtermoreDtitle";
            this.lbl_filtermoreDtitle.Size = new System.Drawing.Size(205, 27);
            this.lbl_filtermoreDtitle.TabIndex = 12;
            this.lbl_filtermoreDtitle.Text = "Filter EPC Data";
            // 
            // btn_FilterImportData
            // 
            this.btn_FilterImportData.BackColor = System.Drawing.Color.Transparent;
            this.btn_FilterImportData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FilterImportData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FilterImportData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.btn_FilterImportData.Location = new System.Drawing.Point(27, 67);
            this.btn_FilterImportData.Name = "btn_FilterImportData";
            this.btn_FilterImportData.Size = new System.Drawing.Size(176, 46);
            this.btn_FilterImportData.TabIndex = 10;
            this.btn_FilterImportData.Text = "Import Data";
            this.btn_FilterImportData.UseVisualStyleBackColor = false;
            this.btn_FilterImportData.Click += new System.EventHandler(this.btn_FilterImportData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 269);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_downloadData
            // 
            this.btn_downloadData.BackColor = System.Drawing.Color.Transparent;
            this.btn_downloadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_downloadData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.btn_downloadData.Location = new System.Drawing.Point(648, 67);
            this.btn_downloadData.Name = "btn_downloadData";
            this.btn_downloadData.Size = new System.Drawing.Size(176, 46);
            this.btn_downloadData.TabIndex = 12;
            this.btn_downloadData.Text = "Download Data";
            this.btn_downloadData.UseVisualStyleBackColor = false;
            // 
            // lbl_fmdRating
            // 
            this.lbl_fmdRating.AutoSize = true;
            this.lbl_fmdRating.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fmdRating.ForeColor = System.Drawing.Color.Gray;
            this.lbl_fmdRating.Location = new System.Drawing.Point(23, 186);
            this.lbl_fmdRating.Name = "lbl_fmdRating";
            this.lbl_fmdRating.Size = new System.Drawing.Size(78, 24);
            this.lbl_fmdRating.TabIndex = 42;
            this.lbl_fmdRating.Text = "Rating";
            // 
            // txt_fmdRating
            // 
            this.txt_fmdRating.Location = new System.Drawing.Point(166, 183);
            this.txt_fmdRating.Multiline = true;
            this.txt_fmdRating.Name = "txt_fmdRating";
            this.txt_fmdRating.Size = new System.Drawing.Size(233, 27);
            this.txt_fmdRating.TabIndex = 41;
            // 
            // lbl_fmdCity
            // 
            this.lbl_fmdCity.AutoSize = true;
            this.lbl_fmdCity.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fmdCity.ForeColor = System.Drawing.Color.Gray;
            this.lbl_fmdCity.Location = new System.Drawing.Point(23, 136);
            this.lbl_fmdCity.Name = "lbl_fmdCity";
            this.lbl_fmdCity.Size = new System.Drawing.Size(121, 24);
            this.lbl_fmdCity.TabIndex = 40;
            this.lbl_fmdCity.Text = "Enter City";
            // 
            // txt_fmdCity
            // 
            this.txt_fmdCity.Location = new System.Drawing.Point(166, 133);
            this.txt_fmdCity.Multiline = true;
            this.txt_fmdCity.Name = "txt_fmdCity";
            this.txt_fmdCity.Size = new System.Drawing.Size(233, 27);
            this.txt_fmdCity.TabIndex = 39;
            // 
            // lbl_fmdTo
            // 
            this.lbl_fmdTo.AutoSize = true;
            this.lbl_fmdTo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fmdTo.ForeColor = System.Drawing.Color.Gray;
            this.lbl_fmdTo.Location = new System.Drawing.Point(499, 183);
            this.lbl_fmdTo.Name = "lbl_fmdTo";
            this.lbl_fmdTo.Size = new System.Drawing.Size(52, 24);
            this.lbl_fmdTo.TabIndex = 44;
            this.lbl_fmdTo.Text = "To: ";
            // 
            // lbl_fmdFrom
            // 
            this.lbl_fmdFrom.AutoSize = true;
            this.lbl_fmdFrom.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fmdFrom.ForeColor = System.Drawing.Color.Gray;
            this.lbl_fmdFrom.Location = new System.Drawing.Point(499, 133);
            this.lbl_fmdFrom.Name = "lbl_fmdFrom";
            this.lbl_fmdFrom.Size = new System.Drawing.Size(79, 24);
            this.lbl_fmdFrom.TabIndex = 43;
            this.lbl_fmdFrom.Text = "From: ";
            // 
            // dtp_fmdFrom
            // 
            this.dtp_fmdFrom.Location = new System.Drawing.Point(585, 140);
            this.dtp_fmdFrom.Name = "dtp_fmdFrom";
            this.dtp_fmdFrom.Size = new System.Drawing.Size(239, 20);
            this.dtp_fmdFrom.TabIndex = 45;
            // 
            // dtp_fmdTo
            // 
            this.dtp_fmdTo.Location = new System.Drawing.Point(585, 186);
            this.dtp_fmdTo.Name = "dtp_fmdTo";
            this.dtp_fmdTo.Size = new System.Drawing.Size(239, 20);
            this.dtp_fmdTo.TabIndex = 46;
            // 
            // lbl_NumberofProperties
            // 
            this.lbl_NumberofProperties.AutoSize = true;
            this.lbl_NumberofProperties.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberofProperties.ForeColor = System.Drawing.Color.Gray;
            this.lbl_NumberofProperties.Location = new System.Drawing.Point(23, 251);
            this.lbl_NumberofProperties.Name = "lbl_NumberofProperties";
            this.lbl_NumberofProperties.Size = new System.Drawing.Size(254, 24);
            this.lbl_NumberofProperties.TabIndex = 47;
            this.lbl_NumberofProperties.Text = "Number of properties: ";
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.Transparent;
            this.btn_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.btn_Filter.Location = new System.Drawing.Point(648, 229);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(176, 46);
            this.btn_Filter.TabIndex = 48;
            this.btn_Filter.Text = "Filter Data";
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_pieChart
            // 
            this.btn_pieChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.btn_pieChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pieChart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pieChart.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pieChart.Location = new System.Drawing.Point(223, 67);
            this.btn_pieChart.Name = "btn_pieChart";
            this.btn_pieChart.Size = new System.Drawing.Size(176, 46);
            this.btn_pieChart.TabIndex = 49;
            this.btn_pieChart.Text = "Print Pie Chart";
            this.btn_pieChart.UseVisualStyleBackColor = false;
            this.btn_pieChart.Click += new System.EventHandler(this.btn_pieChart_Click);
            // 
            // FilterMoreData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 586);
            this.Controls.Add(this.btn_pieChart);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.lbl_NumberofProperties);
            this.Controls.Add(this.dtp_fmdTo);
            this.Controls.Add(this.dtp_fmdFrom);
            this.Controls.Add(this.lbl_fmdTo);
            this.Controls.Add(this.lbl_fmdFrom);
            this.Controls.Add(this.lbl_fmdRating);
            this.Controls.Add(this.txt_fmdRating);
            this.Controls.Add(this.lbl_fmdCity);
            this.Controls.Add(this.txt_fmdCity);
            this.Controls.Add(this.btn_downloadData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_FilterImportData);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterMoreData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterMoreData";
            this.Load += new System.EventHandler(this.FilterMoreData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_filtermoreDCross;
        private System.Windows.Forms.Label lbl_filtermoreDtitle;
        private System.Windows.Forms.Button btn_FilterImportData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_downloadData;
        private System.Windows.Forms.Label lbl_fmdRating;
        private System.Windows.Forms.TextBox txt_fmdRating;
        private System.Windows.Forms.Label lbl_fmdCity;
        private System.Windows.Forms.TextBox txt_fmdCity;
        private System.Windows.Forms.Label lbl_fmdTo;
        private System.Windows.Forms.Label lbl_fmdFrom;
        private System.Windows.Forms.DateTimePicker dtp_fmdTo;
        private System.Windows.Forms.DateTimePicker dtp_fmdFrom;
        private System.Windows.Forms.Label lbl_NumberofProperties;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_pieChart;
    }
}