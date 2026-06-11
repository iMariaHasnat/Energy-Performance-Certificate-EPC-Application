namespace EPCPROJECT
{
    partial class UserManagementUserControl3
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
            this.components = new System.ComponentModel.Container();
            this.lbl_usermanage = new System.Windows.Forms.Label();
            this.btn_registeruser = new System.Windows.Forms.Button();
            this.lbl_unameusermanage = new System.Windows.Forms.Label();
            this.txt_uname_usermanage = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_usertypeusermanage = new System.Windows.Forms.Label();
            this.txt_email_usermanage = new System.Windows.Forms.TextBox();
            this.lbl_emailusermanage = new System.Windows.Forms.Label();
            this.dataGridView_usermanage = new System.Windows.Forms.DataGridView();
            this.btn_searchUser = new System.Windows.Forms.Button();
            this.combobx_usertype_usermanage = new System.Windows.Forms.ComboBox();
            this.btn_updateUser = new System.Windows.Forms.Button();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.btn_SeeReqs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usermanage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_usermanage
            // 
            this.lbl_usermanage.AutoSize = true;
            this.lbl_usermanage.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usermanage.ForeColor = System.Drawing.Color.White;
            this.lbl_usermanage.Location = new System.Drawing.Point(295, 44);
            this.lbl_usermanage.Name = "lbl_usermanage";
            this.lbl_usermanage.Size = new System.Drawing.Size(271, 33);
            this.lbl_usermanage.TabIndex = 9;
            this.lbl_usermanage.Text = "User Management";
            // 
            // btn_registeruser
            // 
            this.btn_registeruser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_registeruser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registeruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registeruser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.btn_registeruser.ForeColor = System.Drawing.Color.White;
            this.btn_registeruser.Location = new System.Drawing.Point(564, 106);
            this.btn_registeruser.Name = "btn_registeruser";
            this.btn_registeruser.Size = new System.Drawing.Size(259, 41);
            this.btn_registeruser.TabIndex = 30;
            this.btn_registeruser.Text = "Register a New User";
            this.btn_registeruser.UseVisualStyleBackColor = false;
            this.btn_registeruser.Click += new System.EventHandler(this.btn_registeruser_Click);
            // 
            // lbl_unameusermanage
            // 
            this.lbl_unameusermanage.AutoSize = true;
            this.lbl_unameusermanage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unameusermanage.ForeColor = System.Drawing.Color.White;
            this.lbl_unameusermanage.Location = new System.Drawing.Point(27, 372);
            this.lbl_unameusermanage.Name = "lbl_unameusermanage";
            this.lbl_unameusermanage.Size = new System.Drawing.Size(103, 22);
            this.lbl_unameusermanage.TabIndex = 31;
            this.lbl_unameusermanage.Text = "Username";
            // 
            // txt_uname_usermanage
            // 
            this.txt_uname_usermanage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_uname_usermanage.Location = new System.Drawing.Point(136, 369);
            this.txt_uname_usermanage.Multiline = true;
            this.txt_uname_usermanage.Name = "txt_uname_usermanage";
            this.txt_uname_usermanage.Size = new System.Drawing.Size(166, 30);
            this.txt_uname_usermanage.TabIndex = 32;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_usertypeusermanage
            // 
            this.lbl_usertypeusermanage.AutoSize = true;
            this.lbl_usertypeusermanage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usertypeusermanage.ForeColor = System.Drawing.Color.White;
            this.lbl_usertypeusermanage.Location = new System.Drawing.Point(321, 375);
            this.lbl_usertypeusermanage.Name = "lbl_usertypeusermanage";
            this.lbl_usertypeusermanage.Size = new System.Drawing.Size(103, 22);
            this.lbl_usertypeusermanage.TabIndex = 34;
            this.lbl_usertypeusermanage.Text = "User Type";
            // 
            // txt_email_usermanage
            // 
            this.txt_email_usermanage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email_usermanage.Location = new System.Drawing.Point(655, 372);
            this.txt_email_usermanage.Multiline = true;
            this.txt_email_usermanage.Name = "txt_email_usermanage";
            this.txt_email_usermanage.Size = new System.Drawing.Size(168, 30);
            this.txt_email_usermanage.TabIndex = 37;
            // 
            // lbl_emailusermanage
            // 
            this.lbl_emailusermanage.AutoSize = true;
            this.lbl_emailusermanage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailusermanage.ForeColor = System.Drawing.Color.White;
            this.lbl_emailusermanage.Location = new System.Drawing.Point(588, 376);
            this.lbl_emailusermanage.Name = "lbl_emailusermanage";
            this.lbl_emailusermanage.Size = new System.Drawing.Size(61, 22);
            this.lbl_emailusermanage.TabIndex = 36;
            this.lbl_emailusermanage.Text = "Email";
            // 
            // dataGridView_usermanage
            // 
            this.dataGridView_usermanage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_usermanage.Location = new System.Drawing.Point(31, 171);
            this.dataGridView_usermanage.Name = "dataGridView_usermanage";
            this.dataGridView_usermanage.Size = new System.Drawing.Size(792, 166);
            this.dataGridView_usermanage.TabIndex = 40;
            this.dataGridView_usermanage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_usermanage_CellClick);
            // 
            // btn_searchUser
            // 
            this.btn_searchUser.BackColor = System.Drawing.Color.White;
            this.btn_searchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_searchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.btn_searchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_searchUser.Location = new System.Drawing.Point(31, 430);
            this.btn_searchUser.Name = "btn_searchUser";
            this.btn_searchUser.Size = new System.Drawing.Size(792, 41);
            this.btn_searchUser.TabIndex = 41;
            this.btn_searchUser.Text = "Search";
            this.btn_searchUser.UseVisualStyleBackColor = false;
            this.btn_searchUser.Click += new System.EventHandler(this.btn_searchUser_Click);
            // 
            // combobx_usertype_usermanage
            // 
            this.combobx_usertype_usermanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combobx_usertype_usermanage.FormattingEnabled = true;
            this.combobx_usertype_usermanage.Location = new System.Drawing.Point(428, 375);
            this.combobx_usertype_usermanage.Name = "combobx_usertype_usermanage";
            this.combobx_usertype_usermanage.Size = new System.Drawing.Size(145, 21);
            this.combobx_usertype_usermanage.TabIndex = 42;
            // 
            // btn_updateUser
            // 
            this.btn_updateUser.BackColor = System.Drawing.Color.White;
            this.btn_updateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.btn_updateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_updateUser.Location = new System.Drawing.Point(564, 507);
            this.btn_updateUser.Name = "btn_updateUser";
            this.btn_updateUser.Size = new System.Drawing.Size(259, 41);
            this.btn_updateUser.TabIndex = 43;
            this.btn_updateUser.Text = "Update User";
            this.btn_updateUser.UseVisualStyleBackColor = false;
            this.btn_updateUser.Click += new System.EventHandler(this.btn_updateUser_Click);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.BackColor = System.Drawing.Color.White;
            this.btn_deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.btn_deleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_deleteUser.Location = new System.Drawing.Point(31, 507);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(271, 41);
            this.btn_deleteUser.TabIndex = 44;
            this.btn_deleteUser.Text = "Delete User";
            this.btn_deleteUser.UseVisualStyleBackColor = false;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_SeeReqs
            // 
            this.btn_SeeReqs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(40)))));
            this.btn_SeeReqs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SeeReqs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SeeReqs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.btn_SeeReqs.ForeColor = System.Drawing.Color.White;
            this.btn_SeeReqs.Location = new System.Drawing.Point(31, 106);
            this.btn_SeeReqs.Name = "btn_SeeReqs";
            this.btn_SeeReqs.Size = new System.Drawing.Size(259, 41);
            this.btn_SeeReqs.TabIndex = 45;
            this.btn_SeeReqs.Text = "See Accounts Requests";
            this.btn_SeeReqs.UseVisualStyleBackColor = false;
            this.btn_SeeReqs.Click += new System.EventHandler(this.btn_SeeReqs_Click);
            // 
            // UserManagementUserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_SeeReqs);
            this.Controls.Add(this.btn_deleteUser);
            this.Controls.Add(this.btn_updateUser);
            this.Controls.Add(this.combobx_usertype_usermanage);
            this.Controls.Add(this.btn_searchUser);
            this.Controls.Add(this.dataGridView_usermanage);
            this.Controls.Add(this.txt_email_usermanage);
            this.Controls.Add(this.lbl_emailusermanage);
            this.Controls.Add(this.lbl_usertypeusermanage);
            this.Controls.Add(this.txt_uname_usermanage);
            this.Controls.Add(this.lbl_unameusermanage);
            this.Controls.Add(this.btn_registeruser);
            this.Controls.Add(this.lbl_usermanage);
            this.Name = "UserManagementUserControl3";
            this.Size = new System.Drawing.Size(853, 586);
            this.Load += new System.EventHandler(this.UserManagementUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usermanage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usermanage;
        private System.Windows.Forms.Button btn_registeruser;
        private System.Windows.Forms.Label lbl_unameusermanage;
        private System.Windows.Forms.TextBox txt_uname_usermanage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_usertypeusermanage;
        private System.Windows.Forms.TextBox txt_email_usermanage;
        private System.Windows.Forms.Label lbl_emailusermanage;
        private System.Windows.Forms.DataGridView dataGridView_usermanage;
        private System.Windows.Forms.Button btn_searchUser;
        private System.Windows.Forms.ComboBox combobx_usertype_usermanage;
        private System.Windows.Forms.Button btn_updateUser;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_SeeReqs;
    }
}
