namespace EPCPROJECT
{
    partial class PieChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_piechartTitle = new System.Windows.Forms.Label();
            this.lbl_piechartCross = new System.Windows.Forms.Label();
            this.lbl_piechartCity = new System.Windows.Forms.Label();
            this.txt_piechartCity = new System.Windows.Forms.TextBox();
            this.dtp_piechartTo = new System.Windows.Forms.DateTimePicker();
            this.dtp_piechartFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_piechartTo = new System.Windows.Forms.Label();
            this.lbl_piechartFrom = new System.Windows.Forms.Label();
            this.btn_distribution = new System.Windows.Forms.Button();
            this.btn_piechartImport = new System.Windows.Forms.Button();
            this.chart_pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_downloadpie = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(132)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.lbl_piechartTitle);
            this.panel1.Controls.Add(this.lbl_piechartCross);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 42);
            this.panel1.TabIndex = 1;
            // 
            // lbl_piechartTitle
            // 
            this.lbl_piechartTitle.AutoSize = true;
            this.lbl_piechartTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_piechartTitle.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_piechartTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_piechartTitle.Location = new System.Drawing.Point(12, 7);
            this.lbl_piechartTitle.Name = "lbl_piechartTitle";
            this.lbl_piechartTitle.Size = new System.Drawing.Size(198, 27);
            this.lbl_piechartTitle.TabIndex = 12;
            this.lbl_piechartTitle.Text = "Print Pie Chart";
            // 
            // lbl_piechartCross
            // 
            this.lbl_piechartCross.AutoSize = true;
            this.lbl_piechartCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_piechartCross.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_piechartCross.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_piechartCross.Location = new System.Drawing.Point(805, 7);
            this.lbl_piechartCross.Name = "lbl_piechartCross";
            this.lbl_piechartCross.Size = new System.Drawing.Size(29, 27);
            this.lbl_piechartCross.TabIndex = 11;
            this.lbl_piechartCross.Text = "X";
            this.lbl_piechartCross.Click += new System.EventHandler(this.lbl_piechartCross_Click);
            // 
            // lbl_piechartCity
            // 
            this.lbl_piechartCity.AutoSize = true;
            this.lbl_piechartCity.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_piechartCity.ForeColor = System.Drawing.Color.Gray;
            this.lbl_piechartCity.Location = new System.Drawing.Point(41, 156);
            this.lbl_piechartCity.Name = "lbl_piechartCity";
            this.lbl_piechartCity.Size = new System.Drawing.Size(121, 24);
            this.lbl_piechartCity.TabIndex = 41;
            this.lbl_piechartCity.Text = "Enter City";
            // 
            // txt_piechartCity
            // 
            this.txt_piechartCity.Location = new System.Drawing.Point(190, 153);
            this.txt_piechartCity.Multiline = true;
            this.txt_piechartCity.Name = "txt_piechartCity";
            this.txt_piechartCity.Size = new System.Drawing.Size(176, 27);
            this.txt_piechartCity.TabIndex = 42;
            // 
            // dtp_piechartTo
            // 
            this.dtp_piechartTo.Location = new System.Drawing.Point(127, 302);
            this.dtp_piechartTo.Name = "dtp_piechartTo";
            this.dtp_piechartTo.Size = new System.Drawing.Size(239, 20);
            this.dtp_piechartTo.TabIndex = 50;
            // 
            // dtp_piechartFrom
            // 
            this.dtp_piechartFrom.Location = new System.Drawing.Point(127, 233);
            this.dtp_piechartFrom.Name = "dtp_piechartFrom";
            this.dtp_piechartFrom.Size = new System.Drawing.Size(239, 20);
            this.dtp_piechartFrom.TabIndex = 49;
            // 
            // lbl_piechartTo
            // 
            this.lbl_piechartTo.AutoSize = true;
            this.lbl_piechartTo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_piechartTo.ForeColor = System.Drawing.Color.Gray;
            this.lbl_piechartTo.Location = new System.Drawing.Point(41, 299);
            this.lbl_piechartTo.Name = "lbl_piechartTo";
            this.lbl_piechartTo.Size = new System.Drawing.Size(52, 24);
            this.lbl_piechartTo.TabIndex = 48;
            this.lbl_piechartTo.Text = "To: ";
            // 
            // lbl_piechartFrom
            // 
            this.lbl_piechartFrom.AutoSize = true;
            this.lbl_piechartFrom.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_piechartFrom.ForeColor = System.Drawing.Color.Gray;
            this.lbl_piechartFrom.Location = new System.Drawing.Point(41, 226);
            this.lbl_piechartFrom.Name = "lbl_piechartFrom";
            this.lbl_piechartFrom.Size = new System.Drawing.Size(79, 24);
            this.lbl_piechartFrom.TabIndex = 47;
            this.lbl_piechartFrom.Text = "From: ";
            // 
            // btn_distribution
            // 
            this.btn_distribution.BackColor = System.Drawing.Color.Transparent;
            this.btn_distribution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_distribution.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_distribution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(154)))), ((int)(((byte)(110)))));
            this.btn_distribution.Location = new System.Drawing.Point(45, 422);
            this.btn_distribution.Name = "btn_distribution";
            this.btn_distribution.Size = new System.Drawing.Size(321, 46);
            this.btn_distribution.TabIndex = 51;
            this.btn_distribution.Text = "Show Distribution";
            this.btn_distribution.UseVisualStyleBackColor = false;
            this.btn_distribution.Click += new System.EventHandler(this.btn_distribution_Click);
            // 
            // btn_piechartImport
            // 
            this.btn_piechartImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(154)))), ((int)(((byte)(110)))));
            this.btn_piechartImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_piechartImport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_piechartImport.ForeColor = System.Drawing.Color.Transparent;
            this.btn_piechartImport.Location = new System.Drawing.Point(37, 69);
            this.btn_piechartImport.Name = "btn_piechartImport";
            this.btn_piechartImport.Size = new System.Drawing.Size(777, 46);
            this.btn_piechartImport.TabIndex = 52;
            this.btn_piechartImport.Text = "Import Data";
            this.btn_piechartImport.UseVisualStyleBackColor = false;
            this.btn_piechartImport.Click += new System.EventHandler(this.btn_piechartImport_Click);
            // 
            // chart_pie
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_pie.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_pie.Legends.Add(legend3);
            this.chart_pie.Location = new System.Drawing.Point(424, 153);
            this.chart_pie.Name = "chart_pie";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_pie.Series.Add(series3);
            this.chart_pie.Size = new System.Drawing.Size(390, 377);
            this.chart_pie.TabIndex = 53;
            this.chart_pie.Text = "chart1";
            // 
            // btn_downloadpie
            // 
            this.btn_downloadpie.BackColor = System.Drawing.Color.Transparent;
            this.btn_downloadpie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_downloadpie.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadpie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(132)))), ((int)(((byte)(90)))));
            this.btn_downloadpie.Location = new System.Drawing.Point(45, 484);
            this.btn_downloadpie.Name = "btn_downloadpie";
            this.btn_downloadpie.Size = new System.Drawing.Size(321, 46);
            this.btn_downloadpie.TabIndex = 54;
            this.btn_downloadpie.Text = "Download Pie Chart";
            this.btn_downloadpie.UseVisualStyleBackColor = false;
            this.btn_downloadpie.Click += new System.EventHandler(this.btn_downloadpie_Click);
            // 
            // PieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 586);
            this.Controls.Add(this.btn_downloadpie);
            this.Controls.Add(this.chart_pie);
            this.Controls.Add(this.btn_piechartImport);
            this.Controls.Add(this.btn_distribution);
            this.Controls.Add(this.dtp_piechartTo);
            this.Controls.Add(this.dtp_piechartFrom);
            this.Controls.Add(this.lbl_piechartTo);
            this.Controls.Add(this.lbl_piechartFrom);
            this.Controls.Add(this.txt_piechartCity);
            this.Controls.Add(this.lbl_piechartCity);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PieChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PieChart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_piechartTitle;
        private System.Windows.Forms.Label lbl_piechartCross;
        private System.Windows.Forms.Label lbl_piechartCity;
        private System.Windows.Forms.TextBox txt_piechartCity;
        private System.Windows.Forms.DateTimePicker dtp_piechartTo;
        private System.Windows.Forms.DateTimePicker dtp_piechartFrom;
        private System.Windows.Forms.Label lbl_piechartTo;
        private System.Windows.Forms.Label lbl_piechartFrom;
        private System.Windows.Forms.Button btn_distribution;
        private System.Windows.Forms.Button btn_piechartImport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pie;
        private System.Windows.Forms.Button btn_downloadpie;
    }
}