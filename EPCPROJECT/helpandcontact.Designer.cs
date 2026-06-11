namespace EPCPROJECT
{
    partial class helpandcontact
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
            this.lbl_helpcross = new System.Windows.Forms.Label();
            this.lbl_helpform = new System.Windows.Forms.Label();
            this.lbl_topdesc = new System.Windows.Forms.Label();
            this.txt_helpUsername = new System.Windows.Forms.TextBox();
            this.txt_emailadd = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_sndmsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_helpcross
            // 
            this.lbl_helpcross.AutoSize = true;
            this.lbl_helpcross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_helpcross.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_helpcross.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_helpcross.Location = new System.Drawing.Point(623, 9);
            this.lbl_helpcross.Name = "lbl_helpcross";
            this.lbl_helpcross.Size = new System.Drawing.Size(25, 24);
            this.lbl_helpcross.TabIndex = 35;
            this.lbl_helpcross.Text = "X";
            this.lbl_helpcross.Click += new System.EventHandler(this.lbl_helpcross_Click);
            // 
            // lbl_helpform
            // 
            this.lbl_helpform.AutoSize = true;
            this.lbl_helpform.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_helpform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lbl_helpform.Location = new System.Drawing.Point(178, 76);
            this.lbl_helpform.Name = "lbl_helpform";
            this.lbl_helpform.Size = new System.Drawing.Size(293, 33);
            this.lbl_helpform.TabIndex = 36;
            this.lbl_helpform.Text = "Help/Contact Form";
            // 
            // lbl_topdesc
            // 
            this.lbl_topdesc.AutoSize = true;
            this.lbl_topdesc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_topdesc.ForeColor = System.Drawing.Color.Gray;
            this.lbl_topdesc.Location = new System.Drawing.Point(54, 158);
            this.lbl_topdesc.Name = "lbl_topdesc";
            this.lbl_topdesc.Size = new System.Drawing.Size(544, 96);
            this.lbl_topdesc.TabIndex = 37;
            this.lbl_topdesc.Text = "If you have any questions or need help, please \r\nfill out the form below. \r\n\r\nWe " +
    "do our best to respond within 1 business day.\r\n";
            // 
            // txt_helpUsername
            // 
            this.txt_helpUsername.BackColor = System.Drawing.Color.White;
            this.txt_helpUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_helpUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_helpUsername.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_helpUsername.Location = new System.Drawing.Point(58, 303);
            this.txt_helpUsername.Multiline = true;
            this.txt_helpUsername.Name = "txt_helpUsername";
            this.txt_helpUsername.Size = new System.Drawing.Size(540, 56);
            this.txt_helpUsername.TabIndex = 38;
            // 
            // txt_emailadd
            // 
            this.txt_emailadd.BackColor = System.Drawing.Color.White;
            this.txt_emailadd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_emailadd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.txt_emailadd.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_emailadd.Location = new System.Drawing.Point(60, 401);
            this.txt_emailadd.Multiline = true;
            this.txt_emailadd.Name = "txt_emailadd";
            this.txt_emailadd.Size = new System.Drawing.Size(540, 56);
            this.txt_emailadd.TabIndex = 39;
            // 
            // txt_subject
            // 
            this.txt_subject.BackColor = System.Drawing.Color.White;
            this.txt_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_subject.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.txt_subject.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_subject.Location = new System.Drawing.Point(58, 494);
            this.txt_subject.Multiline = true;
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(540, 56);
            this.txt_subject.TabIndex = 40;
            // 
            // comboBox_category
            // 
            this.comboBox_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(58, 587);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(542, 21);
            this.comboBox_category.TabIndex = 41;
            // 
            // txt_msg
            // 
            this.txt_msg.BackColor = System.Drawing.Color.White;
            this.txt_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_msg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.txt_msg.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_msg.Location = new System.Drawing.Point(58, 640);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(540, 109);
            this.txt_msg.TabIndex = 42;
            // 
            // btn_sndmsg
            // 
            this.btn_sndmsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_sndmsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sndmsg.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sndmsg.ForeColor = System.Drawing.Color.White;
            this.btn_sndmsg.Location = new System.Drawing.Point(136, 793);
            this.btn_sndmsg.Name = "btn_sndmsg";
            this.btn_sndmsg.Size = new System.Drawing.Size(387, 60);
            this.btn_sndmsg.TabIndex = 43;
            this.btn_sndmsg.Text = "Send Message";
            this.btn_sndmsg.UseVisualStyleBackColor = false;
            this.btn_sndmsg.Click += new System.EventHandler(this.btn_sndmsg_Click);
            // 
            // helpandcontact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(660, 923);
            this.Controls.Add(this.btn_sndmsg);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_emailadd);
            this.Controls.Add(this.txt_helpUsername);
            this.Controls.Add(this.lbl_topdesc);
            this.Controls.Add(this.lbl_helpform);
            this.Controls.Add(this.lbl_helpcross);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "helpandcontact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "helpandcontact";
            this.Load += new System.EventHandler(this.helpandcontact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_helpcross;
        private System.Windows.Forms.Label lbl_helpform;
        private System.Windows.Forms.Label lbl_topdesc;
        private System.Windows.Forms.TextBox txt_helpUsername;
        private System.Windows.Forms.TextBox txt_emailadd;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_sndmsg;
    }
}