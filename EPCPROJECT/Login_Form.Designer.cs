namespace EPCPROJECT
{
    partial class Login_Form
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
            this.lbl_getstarted = new System.Windows.Forms.Label();
            this.lbl_createacc = new System.Windows.Forms.Label();
            this.lbl_donthaveanacc = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.combobox_usertypelogin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_crosslog = new System.Windows.Forms.Label();
            this.chk_showpassword = new System.Windows.Forms.CheckBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_forgotpword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_getstarted
            // 
            this.lbl_getstarted.AutoSize = true;
            this.lbl_getstarted.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getstarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lbl_getstarted.Location = new System.Drawing.Point(67, 109);
            this.lbl_getstarted.Name = "lbl_getstarted";
            this.lbl_getstarted.Size = new System.Drawing.Size(230, 33);
            this.lbl_getstarted.TabIndex = 0;
            this.lbl_getstarted.Text = "Welcome Back!";
            // 
            // lbl_createacc
            // 
            this.lbl_createacc.AutoSize = true;
            this.lbl_createacc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_createacc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_createacc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lbl_createacc.Location = new System.Drawing.Point(146, 809);
            this.lbl_createacc.Name = "lbl_createacc";
            this.lbl_createacc.Size = new System.Drawing.Size(214, 24);
            this.lbl_createacc.TabIndex = 32;
            this.lbl_createacc.Text = "Create an Account";
            this.lbl_createacc.Click += new System.EventHandler(this.lbl_createacc_Click);
            // 
            // lbl_donthaveanacc
            // 
            this.lbl_donthaveanacc.AutoSize = true;
            this.lbl_donthaveanacc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_donthaveanacc.ForeColor = System.Drawing.Color.Gray;
            this.lbl_donthaveanacc.Location = new System.Drawing.Point(124, 767);
            this.lbl_donthaveanacc.Name = "lbl_donthaveanacc";
            this.lbl_donthaveanacc.Size = new System.Drawing.Size(272, 24);
            this.lbl_donthaveanacc.TabIndex = 31;
            this.lbl_donthaveanacc.Text = "Don\'t Have an Account?";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(74, 601);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(387, 49);
            this.btn_login.TabIndex = 29;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.LightGray;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(76, 333);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(387, 39);
            this.txt_password.TabIndex = 27;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Gray;
            this.lbl_password.Location = new System.Drawing.Point(72, 296);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(114, 24);
            this.lbl_password.TabIndex = 26;
            this.lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.LightGray;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(76, 225);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(387, 39);
            this.txt_username.TabIndex = 25;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Gray;
            this.lbl_username.Location = new System.Drawing.Point(72, 188);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(117, 24);
            this.lbl_username.TabIndex = 24;
            this.lbl_username.Text = "Username";
            // 
            // combobox_usertypelogin
            // 
            this.combobox_usertypelogin.FormattingEnabled = true;
            this.combobox_usertypelogin.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.combobox_usertypelogin.Location = new System.Drawing.Point(79, 448);
            this.combobox_usertypelogin.Name = "combobox_usertypelogin";
            this.combobox_usertypelogin.Size = new System.Drawing.Size(387, 21);
            this.combobox_usertypelogin.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(75, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "User Type";
            // 
            // lbl_crosslog
            // 
            this.lbl_crosslog.AutoSize = true;
            this.lbl_crosslog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_crosslog.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crosslog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_crosslog.Location = new System.Drawing.Point(502, 9);
            this.lbl_crosslog.Name = "lbl_crosslog";
            this.lbl_crosslog.Size = new System.Drawing.Size(25, 24);
            this.lbl_crosslog.TabIndex = 34;
            this.lbl_crosslog.Text = "X";
            this.lbl_crosslog.Click += new System.EventHandler(this.lbl_crosslog_Click);
            // 
            // chk_showpassword
            // 
            this.chk_showpassword.AutoSize = true;
            this.chk_showpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_showpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_showpassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_showpassword.ForeColor = System.Drawing.Color.Gray;
            this.chk_showpassword.Location = new System.Drawing.Point(321, 502);
            this.chk_showpassword.Name = "chk_showpassword";
            this.chk_showpassword.Size = new System.Drawing.Size(143, 25);
            this.chk_showpassword.TabIndex = 28;
            this.chk_showpassword.Text = "Show Password";
            this.chk_showpassword.UseVisualStyleBackColor = true;
            this.chk_showpassword.CheckedChanged += new System.EventHandler(this.chk_showpassword_CheckedChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_clear.Location = new System.Drawing.Point(74, 674);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(387, 42);
            this.btn_clear.TabIndex = 30;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_forgotpword
            // 
            this.lbl_forgotpword.AutoSize = true;
            this.lbl_forgotpword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forgotpword.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgotpword.ForeColor = System.Drawing.Color.Gray;
            this.lbl_forgotpword.Location = new System.Drawing.Point(76, 540);
            this.lbl_forgotpword.Name = "lbl_forgotpword";
            this.lbl_forgotpword.Size = new System.Drawing.Size(192, 24);
            this.lbl_forgotpword.TabIndex = 33;
            this.lbl_forgotpword.Text = "Forgot Password";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(539, 923);
            this.Controls.Add(this.combobox_usertypelogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_crosslog);
            this.Controls.Add(this.lbl_forgotpword);
            this.Controls.Add(this.lbl_createacc);
            this.Controls.Add(this.lbl_donthaveanacc);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.chk_showpassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_getstarted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_getstarted;
        private System.Windows.Forms.Label lbl_createacc;
        private System.Windows.Forms.Label lbl_donthaveanacc;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.ComboBox combobox_usertypelogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_crosslog;
        private System.Windows.Forms.CheckBox chk_showpassword;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_forgotpword;
    }
}