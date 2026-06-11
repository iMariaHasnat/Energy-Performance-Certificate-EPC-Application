namespace EPCPROJECT
{
    partial class EmployeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            this.panel_empTopbar = new System.Windows.Forms.Panel();
            this.lbl_empCross = new System.Windows.Forms.Label();
            this.lbl_secadToptitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBox_empAnalytics = new System.Windows.Forms.PictureBox();
            this.pictBox_empSettings = new System.Windows.Forms.PictureBox();
            this.btn_empSettings = new System.Windows.Forms.Button();
            this.picBox_empNotifs = new System.Windows.Forms.PictureBox();
            this.btn_empNotifs = new System.Windows.Forms.Button();
            this.picBox_Analytics = new System.Windows.Forms.PictureBox();
            this.btn_empAnalytics = new System.Windows.Forms.Button();
            this.btn_empData = new System.Windows.Forms.Button();
            this.pic_empHome = new System.Windows.Forms.PictureBox();
            this.btn_empDashboard = new System.Windows.Forms.Button();
            this.panel_empIcon = new System.Windows.Forms.Panel();
            this.lbl_empUsername = new System.Windows.Forms.Label();
            this.picBox_empUserIcon = new System.Windows.Forms.PictureBox();
            this.btn_empHelp = new System.Windows.Forms.Button();
            this.txtBox_empSearch = new System.Windows.Forms.TextBox();
            this.lbl_empMaintitle = new System.Windows.Forms.Label();
            this.picBox_empHelp = new System.Windows.Forms.PictureBox();
            this.empDashboardUserControl1 = new EPCPROJECT.EmpDashboardUserControl();
            this.empData1 = new EPCPROJECT.EmpData();
            this.analyticsUserControl31 = new EPCPROJECT.AnalyticsUserControl3();
            this.empNotifications1 = new EPCPROJECT.EmpNotifications();
            this.settingsUserControl31 = new EPCPROJECT.SettingsUserControl3();
            this.panel_empTopbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_empAnalytics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_empSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_empNotifs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Analytics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_empHome)).BeginInit();
            this.panel_empIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_empUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_empHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_empTopbar
            // 
            this.panel_empTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panel_empTopbar.Controls.Add(this.lbl_empCross);
            this.panel_empTopbar.Controls.Add(this.lbl_secadToptitle);
            this.panel_empTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_empTopbar.Location = new System.Drawing.Point(0, 0);
            this.panel_empTopbar.Name = "panel_empTopbar";
            this.panel_empTopbar.Size = new System.Drawing.Size(1125, 42);
            this.panel_empTopbar.TabIndex = 0;
            // 
            // lbl_empCross
            // 
            this.lbl_empCross.AutoSize = true;
            this.lbl_empCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_empCross.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empCross.ForeColor = System.Drawing.Color.White;
            this.lbl_empCross.Location = new System.Drawing.Point(1089, 5);
            this.lbl_empCross.Name = "lbl_empCross";
            this.lbl_empCross.Size = new System.Drawing.Size(27, 30);
            this.lbl_empCross.TabIndex = 4;
            this.lbl_empCross.Text = "X";
            this.lbl_empCross.Click += new System.EventHandler(this.lbl_empCross_Click);
            // 
            // lbl_secadToptitle
            // 
            this.lbl_secadToptitle.AutoSize = true;
            this.lbl_secadToptitle.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secadToptitle.ForeColor = System.Drawing.Color.White;
            this.lbl_secadToptitle.Location = new System.Drawing.Point(5, 6);
            this.lbl_secadToptitle.Name = "lbl_secadToptitle";
            this.lbl_secadToptitle.Size = new System.Drawing.Size(303, 30);
            this.lbl_secadToptitle.TabIndex = 3;
            this.lbl_secadToptitle.Text = "EPC FILTERING APPLICATION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.picBox_empAnalytics);
            this.panel1.Controls.Add(this.pictBox_empSettings);
            this.panel1.Controls.Add(this.btn_empSettings);
            this.panel1.Controls.Add(this.picBox_empNotifs);
            this.panel1.Controls.Add(this.btn_empNotifs);
            this.panel1.Controls.Add(this.picBox_Analytics);
            this.panel1.Controls.Add(this.btn_empAnalytics);
            this.panel1.Controls.Add(this.btn_empData);
            this.panel1.Controls.Add(this.pic_empHome);
            this.panel1.Controls.Add(this.btn_empDashboard);
            this.panel1.Controls.Add(this.panel_empIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 741);
            this.panel1.TabIndex = 1;
            // 
            // picBox_empAnalytics
            // 
            this.picBox_empAnalytics.BackColor = System.Drawing.Color.Transparent;
            this.picBox_empAnalytics.Image = ((System.Drawing.Image)(resources.GetObject("picBox_empAnalytics.Image")));
            this.picBox_empAnalytics.Location = new System.Drawing.Point(161, 367);
            this.picBox_empAnalytics.Name = "picBox_empAnalytics";
            this.picBox_empAnalytics.Size = new System.Drawing.Size(30, 30);
            this.picBox_empAnalytics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_empAnalytics.TabIndex = 14;
            this.picBox_empAnalytics.TabStop = false;
            // 
            // pictBox_empSettings
            // 
            this.pictBox_empSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictBox_empSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictBox_empSettings.Image")));
            this.pictBox_empSettings.Location = new System.Drawing.Point(161, 560);
            this.pictBox_empSettings.Name = "pictBox_empSettings";
            this.pictBox_empSettings.Size = new System.Drawing.Size(30, 30);
            this.pictBox_empSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBox_empSettings.TabIndex = 13;
            this.pictBox_empSettings.TabStop = false;
            // 
            // btn_empSettings
            // 
            this.btn_empSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_empSettings.FlatAppearance.BorderSize = 0;
            this.btn_empSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empSettings.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_empSettings.ForeColor = System.Drawing.Color.White;
            this.btn_empSettings.Location = new System.Drawing.Point(0, 528);
            this.btn_empSettings.Name = "btn_empSettings";
            this.btn_empSettings.Size = new System.Drawing.Size(200, 96);
            this.btn_empSettings.TabIndex = 13;
            this.btn_empSettings.Text = "Settings";
            this.btn_empSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empSettings.UseVisualStyleBackColor = true;
            this.btn_empSettings.Click += new System.EventHandler(this.btn_empSettings_Click);
            this.btn_empSettings.Leave += new System.EventHandler(this.btn_empSettings_Leave);
            // 
            // picBox_empNotifs
            // 
            this.picBox_empNotifs.BackColor = System.Drawing.Color.Transparent;
            this.picBox_empNotifs.Image = ((System.Drawing.Image)(resources.GetObject("picBox_empNotifs.Image")));
            this.picBox_empNotifs.Location = new System.Drawing.Point(161, 465);
            this.picBox_empNotifs.Name = "picBox_empNotifs";
            this.picBox_empNotifs.Size = new System.Drawing.Size(30, 30);
            this.picBox_empNotifs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_empNotifs.TabIndex = 11;
            this.picBox_empNotifs.TabStop = false;
            // 
            // btn_empNotifs
            // 
            this.btn_empNotifs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empNotifs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_empNotifs.FlatAppearance.BorderSize = 0;
            this.btn_empNotifs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empNotifs.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_empNotifs.ForeColor = System.Drawing.Color.White;
            this.btn_empNotifs.Location = new System.Drawing.Point(0, 432);
            this.btn_empNotifs.Name = "btn_empNotifs";
            this.btn_empNotifs.Size = new System.Drawing.Size(200, 96);
            this.btn_empNotifs.TabIndex = 12;
            this.btn_empNotifs.Text = "Notifications";
            this.btn_empNotifs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empNotifs.UseVisualStyleBackColor = true;
            this.btn_empNotifs.Click += new System.EventHandler(this.btn_empNotifs_Click);
            this.btn_empNotifs.Leave += new System.EventHandler(this.btn_empNotifs_Leave);
            // 
            // picBox_Analytics
            // 
            this.picBox_Analytics.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Analytics.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Analytics.Image")));
            this.picBox_Analytics.Location = new System.Drawing.Point(161, 273);
            this.picBox_Analytics.Name = "picBox_Analytics";
            this.picBox_Analytics.Size = new System.Drawing.Size(30, 30);
            this.picBox_Analytics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Analytics.TabIndex = 10;
            this.picBox_Analytics.TabStop = false;
            // 
            // btn_empAnalytics
            // 
            this.btn_empAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_empAnalytics.FlatAppearance.BorderSize = 0;
            this.btn_empAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empAnalytics.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_empAnalytics.ForeColor = System.Drawing.Color.White;
            this.btn_empAnalytics.Location = new System.Drawing.Point(0, 336);
            this.btn_empAnalytics.Name = "btn_empAnalytics";
            this.btn_empAnalytics.Size = new System.Drawing.Size(200, 96);
            this.btn_empAnalytics.TabIndex = 9;
            this.btn_empAnalytics.Text = "Analytics";
            this.btn_empAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empAnalytics.UseVisualStyleBackColor = true;
            this.btn_empAnalytics.Click += new System.EventHandler(this.btn_empAnalytics_Click);
            this.btn_empAnalytics.Leave += new System.EventHandler(this.btn_empAnalytics_Leave);
            // 
            // btn_empData
            // 
            this.btn_empData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_empData.FlatAppearance.BorderSize = 0;
            this.btn_empData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empData.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_empData.ForeColor = System.Drawing.Color.White;
            this.btn_empData.Location = new System.Drawing.Point(0, 240);
            this.btn_empData.Name = "btn_empData";
            this.btn_empData.Size = new System.Drawing.Size(200, 96);
            this.btn_empData.TabIndex = 8;
            this.btn_empData.Text = "Data";
            this.btn_empData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empData.UseVisualStyleBackColor = true;
            this.btn_empData.Click += new System.EventHandler(this.btn_empData_Click);
            this.btn_empData.Leave += new System.EventHandler(this.btn_empData_Leave);
            // 
            // pic_empHome
            // 
            this.pic_empHome.BackColor = System.Drawing.Color.Transparent;
            this.pic_empHome.Image = ((System.Drawing.Image)(resources.GetObject("pic_empHome.Image")));
            this.pic_empHome.Location = new System.Drawing.Point(161, 178);
            this.pic_empHome.Name = "pic_empHome";
            this.pic_empHome.Size = new System.Drawing.Size(30, 30);
            this.pic_empHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_empHome.TabIndex = 7;
            this.pic_empHome.TabStop = false;
            // 
            // btn_empDashboard
            // 
            this.btn_empDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_empDashboard.FlatAppearance.BorderSize = 0;
            this.btn_empDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empDashboard.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_empDashboard.ForeColor = System.Drawing.Color.White;
            this.btn_empDashboard.Location = new System.Drawing.Point(0, 144);
            this.btn_empDashboard.Name = "btn_empDashboard";
            this.btn_empDashboard.Size = new System.Drawing.Size(200, 96);
            this.btn_empDashboard.TabIndex = 1;
            this.btn_empDashboard.Text = "Dashboard / Home";
            this.btn_empDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empDashboard.UseVisualStyleBackColor = true;
            this.btn_empDashboard.Click += new System.EventHandler(this.btn_empDashboard_Click);
            this.btn_empDashboard.Leave += new System.EventHandler(this.btn_empDashboard_Leave);
            // 
            // panel_empIcon
            // 
            this.panel_empIcon.Controls.Add(this.lbl_empUsername);
            this.panel_empIcon.Controls.Add(this.picBox_empUserIcon);
            this.panel_empIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_empIcon.Location = new System.Drawing.Point(0, 0);
            this.panel_empIcon.Name = "panel_empIcon";
            this.panel_empIcon.Size = new System.Drawing.Size(200, 144);
            this.panel_empIcon.TabIndex = 0;
            // 
            // lbl_empUsername
            // 
            this.lbl_empUsername.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empUsername.ForeColor = System.Drawing.Color.White;
            this.lbl_empUsername.Location = new System.Drawing.Point(50, 103);
            this.lbl_empUsername.Name = "lbl_empUsername";
            this.lbl_empUsername.Size = new System.Drawing.Size(98, 21);
            this.lbl_empUsername.TabIndex = 4;
            this.lbl_empUsername.Text = "USERNAME";
            this.lbl_empUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_empUserIcon
            // 
            this.picBox_empUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBox_empUserIcon.Image")));
            this.picBox_empUserIcon.Location = new System.Drawing.Point(69, 22);
            this.picBox_empUserIcon.Name = "picBox_empUserIcon";
            this.picBox_empUserIcon.Size = new System.Drawing.Size(60, 60);
            this.picBox_empUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_empUserIcon.TabIndex = 3;
            this.picBox_empUserIcon.TabStop = false;
            // 
            // btn_empHelp
            // 
            this.btn_empHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empHelp.FlatAppearance.BorderSize = 0;
            this.btn_empHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empHelp.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empHelp.ForeColor = System.Drawing.Color.White;
            this.btn_empHelp.Location = new System.Drawing.Point(896, 117);
            this.btn_empHelp.Name = "btn_empHelp";
            this.btn_empHelp.Size = new System.Drawing.Size(200, 37);
            this.btn_empHelp.TabIndex = 14;
            this.btn_empHelp.Text = "Help / Contact";
            this.btn_empHelp.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_empHelp.UseVisualStyleBackColor = true;
            this.btn_empHelp.Click += new System.EventHandler(this.btn_empHelp_Click);
            this.btn_empHelp.Leave += new System.EventHandler(this.btn_empHelp_Leave);
            // 
            // txtBox_empSearch
            // 
            this.txtBox_empSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_empSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtBox_empSearch.Location = new System.Drawing.Point(778, 81);
            this.txtBox_empSearch.Multiline = true;
            this.txtBox_empSearch.Name = "txtBox_empSearch";
            this.txtBox_empSearch.Size = new System.Drawing.Size(318, 22);
            this.txtBox_empSearch.TabIndex = 6;
            this.txtBox_empSearch.Text = "Search ...";
            // 
            // lbl_empMaintitle
            // 
            this.lbl_empMaintitle.AutoSize = true;
            this.lbl_empMaintitle.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empMaintitle.ForeColor = System.Drawing.Color.White;
            this.lbl_empMaintitle.Location = new System.Drawing.Point(238, 73);
            this.lbl_empMaintitle.Name = "lbl_empMaintitle";
            this.lbl_empMaintitle.Size = new System.Drawing.Size(224, 30);
            this.lbl_empMaintitle.TabIndex = 5;
            this.lbl_empMaintitle.Text = "EMPLOYEE ACCOUNT";
            // 
            // picBox_empHelp
            // 
            this.picBox_empHelp.BackColor = System.Drawing.Color.Transparent;
            this.picBox_empHelp.Image = ((System.Drawing.Image)(resources.GetObject("picBox_empHelp.Image")));
            this.picBox_empHelp.Location = new System.Drawing.Point(1066, 121);
            this.picBox_empHelp.Name = "picBox_empHelp";
            this.picBox_empHelp.Size = new System.Drawing.Size(30, 30);
            this.picBox_empHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_empHelp.TabIndex = 15;
            this.picBox_empHelp.TabStop = false;
            // 
            // empDashboardUserControl1
            // 
            this.empDashboardUserControl1.Location = new System.Drawing.Point(243, 160);
            this.empDashboardUserControl1.Name = "empDashboardUserControl1";
            this.empDashboardUserControl1.Size = new System.Drawing.Size(853, 586);
            this.empDashboardUserControl1.TabIndex = 16;
            // 
            // empData1
            // 
            this.empData1.Location = new System.Drawing.Point(243, 160);
            this.empData1.Name = "empData1";
            this.empData1.Size = new System.Drawing.Size(853, 586);
            this.empData1.TabIndex = 17;
            // 
            // analyticsUserControl31
            // 
            this.analyticsUserControl31.Location = new System.Drawing.Point(243, 160);
            this.analyticsUserControl31.Name = "analyticsUserControl31";
            this.analyticsUserControl31.Size = new System.Drawing.Size(853, 586);
            this.analyticsUserControl31.TabIndex = 18;
            // 
            // empNotifications1
            // 
            this.empNotifications1.Location = new System.Drawing.Point(243, 160);
            this.empNotifications1.Name = "empNotifications1";
            this.empNotifications1.Size = new System.Drawing.Size(853, 586);
            this.empNotifications1.TabIndex = 19;
            // 
            // settingsUserControl31
            // 
            this.settingsUserControl31.Location = new System.Drawing.Point(243, 160);
            this.settingsUserControl31.Name = "settingsUserControl31";
            this.settingsUserControl31.Size = new System.Drawing.Size(853, 586);
            this.settingsUserControl31.TabIndex = 20;
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(181)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1125, 783);
            this.Controls.Add(this.settingsUserControl31);
            this.Controls.Add(this.empNotifications1);
            this.Controls.Add(this.analyticsUserControl31);
            this.Controls.Add(this.empData1);
            this.Controls.Add(this.empDashboardUserControl1);
            this.Controls.Add(this.picBox_empHelp);
            this.Controls.Add(this.btn_empHelp);
            this.Controls.Add(this.txtBox_empSearch);
            this.Controls.Add(this.lbl_empMaintitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_empTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDashboard";
            this.panel_empTopbar.ResumeLayout(false);
            this.panel_empTopbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_empAnalytics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_empSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_empNotifs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Analytics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_empHome)).EndInit();
            this.panel_empIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_empUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_empHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_empTopbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_secadToptitle;
        private System.Windows.Forms.PictureBox picBox_empUserIcon;
        private System.Windows.Forms.Panel panel_empIcon;
        private System.Windows.Forms.Label lbl_empUsername;
        private System.Windows.Forms.TextBox txtBox_empSearch;
        private System.Windows.Forms.Label lbl_empMaintitle;
        private System.Windows.Forms.Button btn_empDashboard;
        private System.Windows.Forms.PictureBox pic_empHome;
        private System.Windows.Forms.Button btn_empAnalytics;
        private System.Windows.Forms.Button btn_empData;
        private System.Windows.Forms.PictureBox pictBox_empSettings;
        private System.Windows.Forms.Button btn_empNotifs;
        private System.Windows.Forms.PictureBox picBox_empNotifs;
        private System.Windows.Forms.PictureBox picBox_empHelp;
        private System.Windows.Forms.Button btn_empHelp;
        private System.Windows.Forms.Label lbl_empCross;
        private System.Windows.Forms.Button btn_empSettings;
        private System.Windows.Forms.PictureBox picBox_Analytics;
        private System.Windows.Forms.PictureBox picBox_empAnalytics;
        private EmpDashboardUserControl empDashboardUserControl1;
        private EmpData empData1;
        private AnalyticsUserControl3 analyticsUserControl31;
        private EmpNotifications empNotifications1;
        private SettingsUserControl3 settingsUserControl31;
    }
}