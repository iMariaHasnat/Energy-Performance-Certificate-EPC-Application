namespace EPCPROJECT
{
    partial class Register
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.chk_Showpassword = new System.Windows.Forms.CheckBox();
            this.txt_confirmpassword = new System.Windows.Forms.TextBox();
            this.lbl_confirmpassword = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combobox_usertypereg = new System.Windows.Forms.ComboBox();
            this.lbl_crossreg = new System.Windows.Forms.Label();
            this.txt_EmailReg = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_getstarted
            // 
            this.lbl_getstarted.AutoSize = true;
            this.lbl_getstarted.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getstarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.lbl_getstarted.Location = new System.Drawing.Point(76, 51);
            this.lbl_getstarted.Name = "lbl_getstarted";
            this.lbl_getstarted.Size = new System.Drawing.Size(213, 33);
            this.lbl_getstarted.TabIndex = 12;
            this.lbl_getstarted.Text = "Register Here";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.White;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_Clear.Location = new System.Drawing.Point(82, 737);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(387, 49);
            this.btn_Clear.TabIndex = 32;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(82, 664);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(387, 49);
            this.btn_register.TabIndex = 31;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // chk_Showpassword
            // 
            this.chk_Showpassword.AutoSize = true;
            this.chk_Showpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_Showpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_Showpassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Showpassword.ForeColor = System.Drawing.Color.Gray;
            this.chk_Showpassword.Location = new System.Drawing.Point(326, 622);
            this.chk_Showpassword.Name = "chk_Showpassword";
            this.chk_Showpassword.Size = new System.Drawing.Size(143, 25);
            this.chk_Showpassword.TabIndex = 30;
            this.chk_Showpassword.Text = "Show Password";
            this.chk_Showpassword.UseVisualStyleBackColor = true;
            this.chk_Showpassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.BackColor = System.Drawing.Color.LightGray;
            this.txt_confirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmpassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmpassword.Location = new System.Drawing.Point(82, 374);
            this.txt_confirmpassword.Multiline = true;
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.PasswordChar = '*';
            this.txt_confirmpassword.Size = new System.Drawing.Size(387, 39);
            this.txt_confirmpassword.TabIndex = 29;
            // 
            // lbl_confirmpassword
            // 
            this.lbl_confirmpassword.AutoSize = true;
            this.lbl_confirmpassword.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmpassword.ForeColor = System.Drawing.Color.Gray;
            this.lbl_confirmpassword.Location = new System.Drawing.Point(78, 337);
            this.lbl_confirmpassword.Name = "lbl_confirmpassword";
            this.lbl_confirmpassword.Size = new System.Drawing.Size(207, 24);
            this.lbl_confirmpassword.TabIndex = 28;
            this.lbl_confirmpassword.Text = "Confirm Password";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.LightGray;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(82, 268);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(387, 39);
            this.txt_Password.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(78, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.LightGray;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(82, 160);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(387, 39);
            this.txt_Username.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(78, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(78, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "User Type";
            // 
            // combobox_usertypereg
            // 
            this.combobox_usertypereg.FormattingEnabled = true;
            this.combobox_usertypereg.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.combobox_usertypereg.Location = new System.Drawing.Point(82, 479);
            this.combobox_usertypereg.Name = "combobox_usertypereg";
            this.combobox_usertypereg.Size = new System.Drawing.Size(387, 25);
            this.combobox_usertypereg.TabIndex = 36;
            // 
            // lbl_crossreg
            // 
            this.lbl_crossreg.AutoSize = true;
            this.lbl_crossreg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_crossreg.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crossreg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_crossreg.Location = new System.Drawing.Point(518, 9);
            this.lbl_crossreg.Name = "lbl_crossreg";
            this.lbl_crossreg.Size = new System.Drawing.Size(25, 24);
            this.lbl_crossreg.TabIndex = 37;
            this.lbl_crossreg.Text = "X";
            this.lbl_crossreg.Click += new System.EventHandler(this.lbl_crossreg_Click);
            // 
            // txt_EmailReg
            // 
            this.txt_EmailReg.BackColor = System.Drawing.Color.LightGray;
            this.txt_EmailReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_EmailReg.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmailReg.Location = new System.Drawing.Point(82, 565);
            this.txt_EmailReg.Multiline = true;
            this.txt_EmailReg.Name = "txt_EmailReg";
            this.txt_EmailReg.Size = new System.Drawing.Size(387, 39);
            this.txt_EmailReg.TabIndex = 39;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Gray;
            this.lbl_email.Location = new System.Drawing.Point(78, 528);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(68, 24);
            this.lbl_email.TabIndex = 38;
            this.lbl_email.Text = "Email";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(550, 828);
            this.Controls.Add(this.txt_EmailReg);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_crossreg);
            this.Controls.Add(this.combobox_usertypereg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.chk_Showpassword);
            this.Controls.Add(this.txt_confirmpassword);
            this.Controls.Add(this.lbl_confirmpassword);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_getstarted);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_getstarted;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.CheckBox chk_Showpassword;
        private System.Windows.Forms.TextBox txt_confirmpassword;
        private System.Windows.Forms.Label lbl_confirmpassword;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combobox_usertypereg;
        private System.Windows.Forms.Label lbl_crossreg;
        private System.Windows.Forms.TextBox txt_EmailReg;
        private System.Windows.Forms.Label lbl_email;
    }
}