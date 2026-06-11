namespace EPCPROJECT
{
    partial class RequestAccountForm
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
            this.lbl_reqfrmTitle = new System.Windows.Forms.Label();
            this.lbl_reqfrmCross = new System.Windows.Forms.Label();
            this.txt_ReqUsername = new System.Windows.Forms.TextBox();
            this.lbl_ReqUsername = new System.Windows.Forms.Label();
            this.txt_ReqEmail = new System.Windows.Forms.TextBox();
            this.lbl_ReqEmail = new System.Windows.Forms.Label();
            this.lbl_ReqUserType = new System.Windows.Forms.Label();
            this.cmb_ReqUserType = new System.Windows.Forms.ComboBox();
            this.btn_ReqCancel = new System.Windows.Forms.Button();
            this.btn_ReqSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_reqfrmTitle
            // 
            this.lbl_reqfrmTitle.AutoSize = true;
            this.lbl_reqfrmTitle.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqfrmTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lbl_reqfrmTitle.Location = new System.Drawing.Point(118, 97);
            this.lbl_reqfrmTitle.Name = "lbl_reqfrmTitle";
            this.lbl_reqfrmTitle.Size = new System.Drawing.Size(261, 33);
            this.lbl_reqfrmTitle.TabIndex = 1;
            this.lbl_reqfrmTitle.Text = "Request Account";
            // 
            // lbl_reqfrmCross
            // 
            this.lbl_reqfrmCross.AutoSize = true;
            this.lbl_reqfrmCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_reqfrmCross.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqfrmCross.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_reqfrmCross.Location = new System.Drawing.Point(486, 9);
            this.lbl_reqfrmCross.Name = "lbl_reqfrmCross";
            this.lbl_reqfrmCross.Size = new System.Drawing.Size(25, 24);
            this.lbl_reqfrmCross.TabIndex = 35;
            this.lbl_reqfrmCross.Text = "X";
            this.lbl_reqfrmCross.Click += new System.EventHandler(this.lbl_reqfrmCross_Click);
            // 
            // txt_ReqUsername
            // 
            this.txt_ReqUsername.BackColor = System.Drawing.Color.LightGray;
            this.txt_ReqUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ReqUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReqUsername.Location = new System.Drawing.Point(68, 240);
            this.txt_ReqUsername.Multiline = true;
            this.txt_ReqUsername.Name = "txt_ReqUsername";
            this.txt_ReqUsername.Size = new System.Drawing.Size(387, 39);
            this.txt_ReqUsername.TabIndex = 37;
            // 
            // lbl_ReqUsername
            // 
            this.lbl_ReqUsername.AutoSize = true;
            this.lbl_ReqUsername.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReqUsername.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ReqUsername.Location = new System.Drawing.Point(64, 203);
            this.lbl_ReqUsername.Name = "lbl_ReqUsername";
            this.lbl_ReqUsername.Size = new System.Drawing.Size(117, 24);
            this.lbl_ReqUsername.TabIndex = 36;
            this.lbl_ReqUsername.Text = "Username";
            // 
            // txt_ReqEmail
            // 
            this.txt_ReqEmail.BackColor = System.Drawing.Color.LightGray;
            this.txt_ReqEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ReqEmail.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReqEmail.Location = new System.Drawing.Point(68, 364);
            this.txt_ReqEmail.Multiline = true;
            this.txt_ReqEmail.Name = "txt_ReqEmail";
            this.txt_ReqEmail.Size = new System.Drawing.Size(387, 39);
            this.txt_ReqEmail.TabIndex = 39;
            // 
            // lbl_ReqEmail
            // 
            this.lbl_ReqEmail.AutoSize = true;
            this.lbl_ReqEmail.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReqEmail.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ReqEmail.Location = new System.Drawing.Point(64, 327);
            this.lbl_ReqEmail.Name = "lbl_ReqEmail";
            this.lbl_ReqEmail.Size = new System.Drawing.Size(68, 24);
            this.lbl_ReqEmail.TabIndex = 38;
            this.lbl_ReqEmail.Text = "Email";
            // 
            // lbl_ReqUserType
            // 
            this.lbl_ReqUserType.AutoSize = true;
            this.lbl_ReqUserType.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReqUserType.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ReqUserType.Location = new System.Drawing.Point(64, 448);
            this.lbl_ReqUserType.Name = "lbl_ReqUserType";
            this.lbl_ReqUserType.Size = new System.Drawing.Size(121, 24);
            this.lbl_ReqUserType.TabIndex = 40;
            this.lbl_ReqUserType.Text = "User Type";
            // 
            // cmb_ReqUserType
            // 
            this.cmb_ReqUserType.FormattingEnabled = true;
            this.cmb_ReqUserType.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cmb_ReqUserType.Location = new System.Drawing.Point(68, 485);
            this.cmb_ReqUserType.Name = "cmb_ReqUserType";
            this.cmb_ReqUserType.Size = new System.Drawing.Size(387, 21);
            this.cmb_ReqUserType.TabIndex = 41;
            // 
            // btn_ReqCancel
            // 
            this.btn_ReqCancel.BackColor = System.Drawing.Color.White;
            this.btn_ReqCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ReqCancel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReqCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_ReqCancel.Location = new System.Drawing.Point(68, 673);
            this.btn_ReqCancel.Name = "btn_ReqCancel";
            this.btn_ReqCancel.Size = new System.Drawing.Size(387, 42);
            this.btn_ReqCancel.TabIndex = 43;
            this.btn_ReqCancel.Text = "CANCEL";
            this.btn_ReqCancel.UseVisualStyleBackColor = false;
            // 
            // btn_ReqSubmit
            // 
            this.btn_ReqSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_ReqSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ReqSubmit.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReqSubmit.ForeColor = System.Drawing.Color.White;
            this.btn_ReqSubmit.Location = new System.Drawing.Point(68, 600);
            this.btn_ReqSubmit.Name = "btn_ReqSubmit";
            this.btn_ReqSubmit.Size = new System.Drawing.Size(387, 49);
            this.btn_ReqSubmit.TabIndex = 42;
            this.btn_ReqSubmit.Text = "Submit";
            this.btn_ReqSubmit.UseVisualStyleBackColor = false;
            this.btn_ReqSubmit.Click += new System.EventHandler(this.btn_ReqSubmit_Click);
            // 
            // RequestAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 884);
            this.Controls.Add(this.btn_ReqCancel);
            this.Controls.Add(this.btn_ReqSubmit);
            this.Controls.Add(this.cmb_ReqUserType);
            this.Controls.Add(this.lbl_ReqUserType);
            this.Controls.Add(this.txt_ReqEmail);
            this.Controls.Add(this.lbl_ReqEmail);
            this.Controls.Add(this.txt_ReqUsername);
            this.Controls.Add(this.lbl_ReqUsername);
            this.Controls.Add(this.lbl_reqfrmCross);
            this.Controls.Add(this.lbl_reqfrmTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_reqfrmTitle;
        private System.Windows.Forms.Label lbl_reqfrmCross;
        private System.Windows.Forms.TextBox txt_ReqUsername;
        private System.Windows.Forms.Label lbl_ReqUsername;
        private System.Windows.Forms.TextBox txt_ReqEmail;
        private System.Windows.Forms.Label lbl_ReqEmail;
        private System.Windows.Forms.Label lbl_ReqUserType;
        private System.Windows.Forms.ComboBox cmb_ReqUserType;
        private System.Windows.Forms.Button btn_ReqCancel;
        private System.Windows.Forms.Button btn_ReqSubmit;
    }
}