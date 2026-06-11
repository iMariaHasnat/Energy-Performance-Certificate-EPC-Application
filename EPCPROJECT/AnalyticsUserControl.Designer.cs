namespace EPCPROJECT
{
    partial class AnalyticsUserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_analytics = new System.Windows.Forms.Label();
            this.btn_Analyticsimport = new System.Windows.Forms.Button();
            this.txt_city1 = new System.Windows.Forms.TextBox();
            this.lbl_city1 = new System.Windows.Forms.Label();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.cmbBox_Rating = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_toDate = new System.Windows.Forms.DateTimePicker();
            this.btn_showGraph = new System.Windows.Forms.Button();
            this.dataGridView_Analytics = new System.Windows.Forms.DataGridView();
            this.chart_EPC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtp_fromDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_fromdate = new System.Windows.Forms.Label();
            this.lbl_city2 = new System.Windows.Forms.Label();
            this.txt_city2 = new System.Windows.Forms.TextBox();
            this.btn_downloadGraph = new System.Windows.Forms.Button();
            this.btn_filtermoreData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Analytics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_EPC)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_analytics
            // 
            this.lbl_analytics.AutoSize = true;
            this.lbl_analytics.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_analytics.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_analytics.Location = new System.Drawing.Point(365, 44);
            this.lbl_analytics.Name = "lbl_analytics";
            this.lbl_analytics.Size = new System.Drawing.Size(146, 33);
            this.lbl_analytics.TabIndex = 8;
            this.lbl_analytics.Text = "Analytics";
            // 
            // btn_Analyticsimport
            // 
            this.btn_Analyticsimport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_Analyticsimport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Analyticsimport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Analyticsimport.ForeColor = System.Drawing.Color.White;
            this.btn_Analyticsimport.Location = new System.Drawing.Point(57, 98);
            this.btn_Analyticsimport.Name = "btn_Analyticsimport";
            this.btn_Analyticsimport.Size = new System.Drawing.Size(176, 46);
            this.btn_Analyticsimport.TabIndex = 9;
            this.btn_Analyticsimport.Text = "Import Data";
            this.btn_Analyticsimport.UseVisualStyleBackColor = false;
            this.btn_Analyticsimport.Click += new System.EventHandler(this.btn_Analyticsimport_Click);
            // 
            // txt_city1
            // 
            this.txt_city1.Location = new System.Drawing.Point(175, 160);
            this.txt_city1.Multiline = true;
            this.txt_city1.Name = "txt_city1";
            this.txt_city1.Size = new System.Drawing.Size(233, 27);
            this.txt_city1.TabIndex = 10;
            this.txt_city1.TextChanged += new System.EventHandler(this.txt_city_TextChanged);
            // 
            // lbl_city1
            // 
            this.lbl_city1.AutoSize = true;
            this.lbl_city1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city1.ForeColor = System.Drawing.Color.Gray;
            this.lbl_city1.Location = new System.Drawing.Point(53, 163);
            this.lbl_city1.Name = "lbl_city1";
            this.lbl_city1.Size = new System.Drawing.Size(81, 24);
            this.lbl_city1.TabIndex = 25;
            this.lbl_city1.Text = "City 1:";
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rating.ForeColor = System.Drawing.Color.Gray;
            this.lbl_rating.Location = new System.Drawing.Point(53, 355);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(84, 24);
            this.lbl_rating.TabIndex = 28;
            this.lbl_rating.Text = "Rating:";
            // 
            // cmbBox_Rating
            // 
            this.cmbBox_Rating.FormattingEnabled = true;
            this.cmbBox_Rating.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.cmbBox_Rating.Location = new System.Drawing.Point(175, 358);
            this.cmbBox_Rating.Name = "cmbBox_Rating";
            this.cmbBox_Rating.Size = new System.Drawing.Size(233, 21);
            this.cmbBox_Rating.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(53, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "To: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtp_toDate
            // 
            this.dtp_toDate.Location = new System.Drawing.Point(175, 313);
            this.dtp_toDate.Name = "dtp_toDate";
            this.dtp_toDate.Size = new System.Drawing.Size(233, 20);
            this.dtp_toDate.TabIndex = 31;
            // 
            // btn_showGraph
            // 
            this.btn_showGraph.BackColor = System.Drawing.Color.White;
            this.btn_showGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showGraph.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_showGraph.Location = new System.Drawing.Point(453, 98);
            this.btn_showGraph.Name = "btn_showGraph";
            this.btn_showGraph.Size = new System.Drawing.Size(166, 46);
            this.btn_showGraph.TabIndex = 32;
            this.btn_showGraph.Text = "Show Graph";
            this.btn_showGraph.UseVisualStyleBackColor = false;
            this.btn_showGraph.Click += new System.EventHandler(this.btn_showGraph_Click);
            // 
            // dataGridView_Analytics
            // 
            this.dataGridView_Analytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Analytics.Location = new System.Drawing.Point(57, 404);
            this.dataGridView_Analytics.Name = "dataGridView_Analytics";
            this.dataGridView_Analytics.Size = new System.Drawing.Size(351, 149);
            this.dataGridView_Analytics.TabIndex = 33;
            // 
            // chart_EPC
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_EPC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_EPC.Legends.Add(legend1);
            this.chart_EPC.Location = new System.Drawing.Point(453, 163);
            this.chart_EPC.Name = "chart_EPC";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_EPC.Series.Add(series1);
            this.chart_EPC.Size = new System.Drawing.Size(336, 390);
            this.chart_EPC.TabIndex = 34;
            this.chart_EPC.Text = "chart_EPC";
            // 
            // dtp_fromDate
            // 
            this.dtp_fromDate.Location = new System.Drawing.Point(175, 265);
            this.dtp_fromDate.Name = "dtp_fromDate";
            this.dtp_fromDate.Size = new System.Drawing.Size(233, 20);
            this.dtp_fromDate.TabIndex = 36;
            // 
            // lbl_fromdate
            // 
            this.lbl_fromdate.AutoSize = true;
            this.lbl_fromdate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fromdate.ForeColor = System.Drawing.Color.Gray;
            this.lbl_fromdate.Location = new System.Drawing.Point(53, 261);
            this.lbl_fromdate.Name = "lbl_fromdate";
            this.lbl_fromdate.Size = new System.Drawing.Size(79, 24);
            this.lbl_fromdate.TabIndex = 35;
            this.lbl_fromdate.Text = "From: ";
            // 
            // lbl_city2
            // 
            this.lbl_city2.AutoSize = true;
            this.lbl_city2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city2.ForeColor = System.Drawing.Color.Gray;
            this.lbl_city2.Location = new System.Drawing.Point(53, 213);
            this.lbl_city2.Name = "lbl_city2";
            this.lbl_city2.Size = new System.Drawing.Size(81, 24);
            this.lbl_city2.TabIndex = 38;
            this.lbl_city2.Text = "City 2:";
            // 
            // txt_city2
            // 
            this.txt_city2.Location = new System.Drawing.Point(175, 210);
            this.txt_city2.Multiline = true;
            this.txt_city2.Name = "txt_city2";
            this.txt_city2.Size = new System.Drawing.Size(233, 27);
            this.txt_city2.TabIndex = 37;
            // 
            // btn_downloadGraph
            // 
            this.btn_downloadGraph.BackColor = System.Drawing.Color.White;
            this.btn_downloadGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_downloadGraph.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_downloadGraph.Location = new System.Drawing.Point(625, 98);
            this.btn_downloadGraph.Name = "btn_downloadGraph";
            this.btn_downloadGraph.Size = new System.Drawing.Size(166, 46);
            this.btn_downloadGraph.TabIndex = 39;
            this.btn_downloadGraph.Text = "Download Chart";
            this.btn_downloadGraph.UseVisualStyleBackColor = false;
            this.btn_downloadGraph.Click += new System.EventHandler(this.btn_downloadGraph_Click);
            // 
            // btn_filtermoreData
            // 
            this.btn_filtermoreData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.btn_filtermoreData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtermoreData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtermoreData.ForeColor = System.Drawing.Color.White;
            this.btn_filtermoreData.Location = new System.Drawing.Point(239, 98);
            this.btn_filtermoreData.Name = "btn_filtermoreData";
            this.btn_filtermoreData.Size = new System.Drawing.Size(169, 46);
            this.btn_filtermoreData.TabIndex = 40;
            this.btn_filtermoreData.Text = "Filter More Data";
            this.btn_filtermoreData.UseVisualStyleBackColor = false;
            this.btn_filtermoreData.Click += new System.EventHandler(this.btn_filtermoreData_Click);
            // 
            // AnalyticsUserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_filtermoreData);
            this.Controls.Add(this.btn_downloadGraph);
            this.Controls.Add(this.lbl_city2);
            this.Controls.Add(this.txt_city2);
            this.Controls.Add(this.dtp_fromDate);
            this.Controls.Add(this.lbl_fromdate);
            this.Controls.Add(this.chart_EPC);
            this.Controls.Add(this.dataGridView_Analytics);
            this.Controls.Add(this.btn_showGraph);
            this.Controls.Add(this.dtp_toDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBox_Rating);
            this.Controls.Add(this.lbl_rating);
            this.Controls.Add(this.lbl_city1);
            this.Controls.Add(this.txt_city1);
            this.Controls.Add(this.btn_Analyticsimport);
            this.Controls.Add(this.lbl_analytics);
            this.Name = "AnalyticsUserControl3";
            this.Size = new System.Drawing.Size(853, 586);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Analytics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_EPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_analytics;
        private System.Windows.Forms.Button btn_Analyticsimport;
        private System.Windows.Forms.TextBox txt_city1;
        private System.Windows.Forms.Label lbl_city1;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.ComboBox cmbBox_Rating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_toDate;
        private System.Windows.Forms.Button btn_showGraph;
        private System.Windows.Forms.DataGridView dataGridView_Analytics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_EPC;
        private System.Windows.Forms.DateTimePicker dtp_fromDate;
        private System.Windows.Forms.Label lbl_fromdate;
        private System.Windows.Forms.Label lbl_city2;
        private System.Windows.Forms.TextBox txt_city2;
        private System.Windows.Forms.Button btn_downloadGraph;
        private System.Windows.Forms.Button btn_filtermoreData;
    }
}
