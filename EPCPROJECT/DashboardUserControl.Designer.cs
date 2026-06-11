namespace EPCPROJECT
{
    partial class DashboardUserControl3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUserControl3));
            this.lbl_dataupdate = new System.Windows.Forms.Label();
            this.lbl_totalusers = new System.Windows.Forms.Label();
            this.txt_totalusers = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_dashbManageUsers = new System.Windows.Forms.Button();
            this.btn_dashbImportEPC = new System.Windows.Forms.Button();
            this.btn_dashbViewNotifs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dataupdate
            // 
            this.lbl_dataupdate.AutoSize = true;
            this.lbl_dataupdate.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataupdate.ForeColor = System.Drawing.Color.White;
            this.lbl_dataupdate.Location = new System.Drawing.Point(278, 44);
            this.lbl_dataupdate.Name = "lbl_dataupdate";
            this.lbl_dataupdate.Size = new System.Drawing.Size(285, 33);
            this.lbl_dataupdate.TabIndex = 7;
            this.lbl_dataupdate.Text = "Dashboard / Home";
            // 
            // lbl_totalusers
            // 
            this.lbl_totalusers.AutoSize = true;
            this.lbl_totalusers.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalusers.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_totalusers.Location = new System.Drawing.Point(57, 143);
            this.lbl_totalusers.Name = "lbl_totalusers";
            this.lbl_totalusers.Size = new System.Drawing.Size(149, 24);
            this.lbl_totalusers.TabIndex = 25;
            this.lbl_totalusers.Text = "Total Users: ";
            // 
            // txt_totalusers
            // 
            this.txt_totalusers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_totalusers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_totalusers.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalusers.Location = new System.Drawing.Point(61, 184);
            this.txt_totalusers.Multiline = true;
            this.txt_totalusers.Name = "txt_totalusers";
            this.txt_totalusers.ReadOnly = true;
            this.txt_totalusers.Size = new System.Drawing.Size(303, 39);
            this.txt_totalusers.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(432, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btn_dashbManageUsers
            // 
            this.btn_dashbManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(65)))));
            this.btn_dashbManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashbManageUsers.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashbManageUsers.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dashbManageUsers.Location = new System.Drawing.Point(61, 294);
            this.btn_dashbManageUsers.Name = "btn_dashbManageUsers";
            this.btn_dashbManageUsers.Size = new System.Drawing.Size(303, 42);
            this.btn_dashbManageUsers.TabIndex = 31;
            this.btn_dashbManageUsers.Text = "Manage Users";
            this.btn_dashbManageUsers.UseVisualStyleBackColor = false;
            this.btn_dashbManageUsers.Click += new System.EventHandler(this.btn_dashbManageUsers_Click);
            // 
            // btn_dashbImportEPC
            // 
            this.btn_dashbImportEPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(162)))), ((int)(((byte)(41)))));
            this.btn_dashbImportEPC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashbImportEPC.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashbImportEPC.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dashbImportEPC.Location = new System.Drawing.Point(61, 392);
            this.btn_dashbImportEPC.Name = "btn_dashbImportEPC";
            this.btn_dashbImportEPC.Size = new System.Drawing.Size(303, 42);
            this.btn_dashbImportEPC.TabIndex = 32;
            this.btn_dashbImportEPC.Text = "Import EPC Data";
            this.btn_dashbImportEPC.UseVisualStyleBackColor = false;
            this.btn_dashbImportEPC.Click += new System.EventHandler(this.btn_dashbImportEPC_Click);
            // 
            // btn_dashbViewNotifs
            // 
            this.btn_dashbViewNotifs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(26)))), ((int)(((byte)(22)))));
            this.btn_dashbViewNotifs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashbViewNotifs.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashbViewNotifs.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dashbViewNotifs.Location = new System.Drawing.Point(61, 486);
            this.btn_dashbViewNotifs.Name = "btn_dashbViewNotifs";
            this.btn_dashbViewNotifs.Size = new System.Drawing.Size(303, 42);
            this.btn_dashbViewNotifs.TabIndex = 33;
            this.btn_dashbViewNotifs.Text = "View Notifications";
            this.btn_dashbViewNotifs.UseVisualStyleBackColor = false;
            this.btn_dashbViewNotifs.Click += new System.EventHandler(this.btn_dashbViewNotifs_Click);
            // 
            // DashboardUserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_dashbViewNotifs);
            this.Controls.Add(this.btn_dashbImportEPC);
            this.Controls.Add(this.btn_dashbManageUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_totalusers);
            this.Controls.Add(this.lbl_totalusers);
            this.Controls.Add(this.lbl_dataupdate);
            this.Name = "DashboardUserControl3";
            this.Size = new System.Drawing.Size(853, 586);
            this.Load += new System.EventHandler(this.DashboardUserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dataupdate;
        private System.Windows.Forms.Label lbl_totalusers;
        private System.Windows.Forms.TextBox txt_totalusers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dashbManageUsers;
        private System.Windows.Forms.Button btn_dashbImportEPC;
        private System.Windows.Forms.Button btn_dashbViewNotifs;
    }
}
