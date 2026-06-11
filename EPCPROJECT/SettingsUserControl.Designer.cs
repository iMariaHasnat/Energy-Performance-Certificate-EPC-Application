namespace EPCPROJECT
{
    partial class SettingsUserControl3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUserControl3));
            this.lbl_Settings = new System.Windows.Forms.Label();
            this.lbl_settingsProfile = new System.Windows.Forms.Label();
            this.btn_profileChange = new System.Windows.Forms.Button();
            this.picBox_profileChange = new System.Windows.Forms.PictureBox();
            this.panel_Profile = new System.Windows.Forms.Panel();
            this.panel_settingsContact = new System.Windows.Forms.Panel();
            this.txt_settingsEmail = new System.Windows.Forms.TextBox();
            this.lbl_settingsContact = new System.Windows.Forms.Label();
            this.btn_updatecontactSettings = new System.Windows.Forms.Button();
            this.panel_updatePword = new System.Windows.Forms.Panel();
            this.txt_confirmPword = new System.Windows.Forms.TextBox();
            this.txt_newPword = new System.Windows.Forms.TextBox();
            this.txt_currentPword = new System.Windows.Forms.TextBox();
            this.btn_changePword = new System.Windows.Forms.Button();
            this.lbl_confirmPword = new System.Windows.Forms.Label();
            this.lbl_newPword = new System.Windows.Forms.Label();
            this.lbl_currentPword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_profileChange)).BeginInit();
            this.panel_Profile.SuspendLayout();
            this.panel_settingsContact.SuspendLayout();
            this.panel_updatePword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Settings
            // 
            this.lbl_Settings.AutoSize = true;
            this.lbl_Settings.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Settings.Location = new System.Drawing.Point(361, 44);
            this.lbl_Settings.Name = "lbl_Settings";
            this.lbl_Settings.Size = new System.Drawing.Size(133, 33);
            this.lbl_Settings.TabIndex = 11;
            this.lbl_Settings.Text = "Settings";
            // 
            // lbl_settingsProfile
            // 
            this.lbl_settingsProfile.AutoSize = true;
            this.lbl_settingsProfile.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settingsProfile.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_settingsProfile.Location = new System.Drawing.Point(19, 12);
            this.lbl_settingsProfile.Name = "lbl_settingsProfile";
            this.lbl_settingsProfile.Size = new System.Drawing.Size(171, 24);
            this.lbl_settingsProfile.TabIndex = 25;
            this.lbl_settingsProfile.Text = "Profile Section";
            // 
            // btn_profileChange
            // 
            this.btn_profileChange.BackColor = System.Drawing.Color.White;
            this.btn_profileChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profileChange.FlatAppearance.BorderSize = 0;
            this.btn_profileChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profileChange.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profileChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_profileChange.Location = new System.Drawing.Point(21, 51);
            this.btn_profileChange.Name = "btn_profileChange";
            this.btn_profileChange.Size = new System.Drawing.Size(214, 42);
            this.btn_profileChange.TabIndex = 31;
            this.btn_profileChange.Text = "Change Profile";
            this.btn_profileChange.UseVisualStyleBackColor = false;
            this.btn_profileChange.Click += new System.EventHandler(this.btn_profileChange_Click);
            // 
            // picBox_profileChange
            // 
            this.picBox_profileChange.Image = ((System.Drawing.Image)(resources.GetObject("picBox_profileChange.Image")));
            this.picBox_profileChange.Location = new System.Drawing.Point(263, 51);
            this.picBox_profileChange.Name = "picBox_profileChange";
            this.picBox_profileChange.Size = new System.Drawing.Size(40, 40);
            this.picBox_profileChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_profileChange.TabIndex = 32;
            this.picBox_profileChange.TabStop = false;
            // 
            // panel_Profile
            // 
            this.panel_Profile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_Profile.Controls.Add(this.lbl_settingsProfile);
            this.panel_Profile.Controls.Add(this.picBox_profileChange);
            this.panel_Profile.Controls.Add(this.btn_profileChange);
            this.panel_Profile.Location = new System.Drawing.Point(58, 122);
            this.panel_Profile.Name = "panel_Profile";
            this.panel_Profile.Size = new System.Drawing.Size(326, 107);
            this.panel_Profile.TabIndex = 33;
            // 
            // panel_settingsContact
            // 
            this.panel_settingsContact.BackColor = System.Drawing.Color.Beige;
            this.panel_settingsContact.Controls.Add(this.txt_settingsEmail);
            this.panel_settingsContact.Controls.Add(this.lbl_settingsContact);
            this.panel_settingsContact.Controls.Add(this.btn_updatecontactSettings);
            this.panel_settingsContact.Location = new System.Drawing.Point(58, 257);
            this.panel_settingsContact.Name = "panel_settingsContact";
            this.panel_settingsContact.Size = new System.Drawing.Size(326, 171);
            this.panel_settingsContact.TabIndex = 34;
            // 
            // txt_settingsEmail
            // 
            this.txt_settingsEmail.BackColor = System.Drawing.Color.LightGray;
            this.txt_settingsEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_settingsEmail.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_settingsEmail.Location = new System.Drawing.Point(21, 52);
            this.txt_settingsEmail.Multiline = true;
            this.txt_settingsEmail.Name = "txt_settingsEmail";
            this.txt_settingsEmail.Size = new System.Drawing.Size(282, 39);
            this.txt_settingsEmail.TabIndex = 32;
            // 
            // lbl_settingsContact
            // 
            this.lbl_settingsContact.AutoSize = true;
            this.lbl_settingsContact.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settingsContact.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_settingsContact.Location = new System.Drawing.Point(19, 12);
            this.lbl_settingsContact.Name = "lbl_settingsContact";
            this.lbl_settingsContact.Size = new System.Drawing.Size(179, 24);
            this.lbl_settingsContact.TabIndex = 25;
            this.lbl_settingsContact.Text = "Contact Details";
            // 
            // btn_updatecontactSettings
            // 
            this.btn_updatecontactSettings.BackColor = System.Drawing.Color.White;
            this.btn_updatecontactSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updatecontactSettings.FlatAppearance.BorderSize = 0;
            this.btn_updatecontactSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatecontactSettings.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatecontactSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_updatecontactSettings.Location = new System.Drawing.Point(21, 107);
            this.btn_updatecontactSettings.Name = "btn_updatecontactSettings";
            this.btn_updatecontactSettings.Size = new System.Drawing.Size(282, 42);
            this.btn_updatecontactSettings.TabIndex = 31;
            this.btn_updatecontactSettings.Text = "Update Contact";
            this.btn_updatecontactSettings.UseVisualStyleBackColor = false;
            this.btn_updatecontactSettings.Click += new System.EventHandler(this.btn_updatecontactSettings_Click);
            // 
            // panel_updatePword
            // 
            this.panel_updatePword.BackColor = System.Drawing.Color.LightCyan;
            this.panel_updatePword.Controls.Add(this.txt_confirmPword);
            this.panel_updatePword.Controls.Add(this.txt_newPword);
            this.panel_updatePword.Controls.Add(this.txt_currentPword);
            this.panel_updatePword.Controls.Add(this.btn_changePword);
            this.panel_updatePword.Controls.Add(this.lbl_confirmPword);
            this.panel_updatePword.Controls.Add(this.lbl_newPword);
            this.panel_updatePword.Controls.Add(this.lbl_currentPword);
            this.panel_updatePword.Controls.Add(this.label1);
            this.panel_updatePword.Location = new System.Drawing.Point(413, 122);
            this.panel_updatePword.Name = "panel_updatePword";
            this.panel_updatePword.Size = new System.Drawing.Size(385, 306);
            this.panel_updatePword.TabIndex = 35;
            // 
            // txt_confirmPword
            // 
            this.txt_confirmPword.BackColor = System.Drawing.Color.LightGray;
            this.txt_confirmPword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmPword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmPword.Location = new System.Drawing.Point(181, 181);
            this.txt_confirmPword.Multiline = true;
            this.txt_confirmPword.Name = "txt_confirmPword";
            this.txt_confirmPword.Size = new System.Drawing.Size(183, 29);
            this.txt_confirmPword.TabIndex = 37;
            // 
            // txt_newPword
            // 
            this.txt_newPword.BackColor = System.Drawing.Color.LightGray;
            this.txt_newPword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_newPword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPword.Location = new System.Drawing.Point(179, 122);
            this.txt_newPword.Multiline = true;
            this.txt_newPword.Name = "txt_newPword";
            this.txt_newPword.Size = new System.Drawing.Size(183, 29);
            this.txt_newPword.TabIndex = 36;
            // 
            // txt_currentPword
            // 
            this.txt_currentPword.BackColor = System.Drawing.Color.LightGray;
            this.txt_currentPword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_currentPword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentPword.Location = new System.Drawing.Point(179, 63);
            this.txt_currentPword.Multiline = true;
            this.txt_currentPword.Name = "txt_currentPword";
            this.txt_currentPword.Size = new System.Drawing.Size(183, 29);
            this.txt_currentPword.TabIndex = 33;
            // 
            // btn_changePword
            // 
            this.btn_changePword.BackColor = System.Drawing.Color.White;
            this.btn_changePword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changePword.FlatAppearance.BorderSize = 0;
            this.btn_changePword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePword.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_changePword.Location = new System.Drawing.Point(23, 242);
            this.btn_changePword.Name = "btn_changePword";
            this.btn_changePword.Size = new System.Drawing.Size(341, 42);
            this.btn_changePword.TabIndex = 33;
            this.btn_changePword.Text = "Change Password";
            this.btn_changePword.UseVisualStyleBackColor = false;
            this.btn_changePword.Click += new System.EventHandler(this.btn_changePword_Click);
            // 
            // lbl_confirmPword
            // 
            this.lbl_confirmPword.AutoSize = true;
            this.lbl_confirmPword.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPword.ForeColor = System.Drawing.Color.Black;
            this.lbl_confirmPword.Location = new System.Drawing.Point(19, 187);
            this.lbl_confirmPword.Name = "lbl_confirmPword";
            this.lbl_confirmPword.Size = new System.Drawing.Size(156, 23);
            this.lbl_confirmPword.TabIndex = 35;
            this.lbl_confirmPword.Text = "Confirm Password";
            // 
            // lbl_newPword
            // 
            this.lbl_newPword.AutoSize = true;
            this.lbl_newPword.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPword.ForeColor = System.Drawing.Color.Black;
            this.lbl_newPword.Location = new System.Drawing.Point(19, 124);
            this.lbl_newPword.Name = "lbl_newPword";
            this.lbl_newPword.Size = new System.Drawing.Size(126, 23);
            this.lbl_newPword.TabIndex = 34;
            this.lbl_newPword.Text = "New Password";
            // 
            // lbl_currentPword
            // 
            this.lbl_currentPword.AutoSize = true;
            this.lbl_currentPword.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentPword.ForeColor = System.Drawing.Color.Black;
            this.lbl_currentPword.Location = new System.Drawing.Point(19, 68);
            this.lbl_currentPword.Name = "lbl_currentPword";
            this.lbl_currentPword.Size = new System.Drawing.Size(151, 23);
            this.lbl_currentPword.TabIndex = 33;
            this.lbl_currentPword.Text = "Current Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Update Password";
            // 
            // SettingsUserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_updatePword);
            this.Controls.Add(this.panel_settingsContact);
            this.Controls.Add(this.panel_Profile);
            this.Controls.Add(this.lbl_Settings);
            this.Name = "SettingsUserControl3";
            this.Size = new System.Drawing.Size(853, 586);
            this.Load += new System.EventHandler(this.SettingsUserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_profileChange)).EndInit();
            this.panel_Profile.ResumeLayout(false);
            this.panel_Profile.PerformLayout();
            this.panel_settingsContact.ResumeLayout(false);
            this.panel_settingsContact.PerformLayout();
            this.panel_updatePword.ResumeLayout(false);
            this.panel_updatePword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Settings;
        private System.Windows.Forms.Label lbl_settingsProfile;
        private System.Windows.Forms.Button btn_profileChange;
        private System.Windows.Forms.PictureBox picBox_profileChange;
        private System.Windows.Forms.Panel panel_Profile;
        private System.Windows.Forms.Panel panel_settingsContact;
        private System.Windows.Forms.Label lbl_settingsContact;
        private System.Windows.Forms.Button btn_updatecontactSettings;
        private System.Windows.Forms.TextBox txt_settingsEmail;
        private System.Windows.Forms.Panel panel_updatePword;
        private System.Windows.Forms.Label lbl_currentPword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_confirmPword;
        private System.Windows.Forms.TextBox txt_newPword;
        private System.Windows.Forms.TextBox txt_currentPword;
        private System.Windows.Forms.Button btn_changePword;
        private System.Windows.Forms.Label lbl_confirmPword;
        private System.Windows.Forms.Label lbl_newPword;
    }
}
