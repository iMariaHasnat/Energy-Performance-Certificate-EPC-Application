namespace EPCPROJECT
{
    partial class AccountsRequests
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
            this.lbl_accsReqs = new System.Windows.Forms.Label();
            this.lbl_accsReqsCross = new System.Windows.Forms.Label();
            this.dgv_Requests = new System.Windows.Forms.DataGridView();
            this.cmb_StatusFilter = new System.Windows.Forms.ComboBox();
            this.txt_usernameORemail = new System.Windows.Forms.TextBox();
            this.lbl_StatusFilter = new System.Windows.Forms.Label();
            this.lbl_accsReqsSearch = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_RequestCount = new System.Windows.Forms.Label();
            this.btn_accsReqsExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Requests)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_accsReqs
            // 
            this.lbl_accsReqs.AutoSize = true;
            this.lbl_accsReqs.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accsReqs.ForeColor = System.Drawing.Color.Black;
            this.lbl_accsReqs.Location = new System.Drawing.Point(295, 44);
            this.lbl_accsReqs.Name = "lbl_accsReqs";
            this.lbl_accsReqs.Size = new System.Drawing.Size(277, 33);
            this.lbl_accsReqs.TabIndex = 10;
            this.lbl_accsReqs.Text = "Account Requests";
            // 
            // lbl_accsReqsCross
            // 
            this.lbl_accsReqsCross.AutoSize = true;
            this.lbl_accsReqsCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_accsReqsCross.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accsReqsCross.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_accsReqsCross.Location = new System.Drawing.Point(800, 9);
            this.lbl_accsReqsCross.Name = "lbl_accsReqsCross";
            this.lbl_accsReqsCross.Size = new System.Drawing.Size(25, 24);
            this.lbl_accsReqsCross.TabIndex = 35;
            this.lbl_accsReqsCross.Text = "X";
            this.lbl_accsReqsCross.Click += new System.EventHandler(this.lbl_accsReqsCross_Click);
            // 
            // dgv_Requests
            // 
            this.dgv_Requests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.dgv_Requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Requests.Location = new System.Drawing.Point(48, 294);
            this.dgv_Requests.Name = "dgv_Requests";
            this.dgv_Requests.Size = new System.Drawing.Size(733, 207);
            this.dgv_Requests.TabIndex = 36;
            this.dgv_Requests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Requests_CellContentClick);
            // 
            // cmb_StatusFilter
            // 
            this.cmb_StatusFilter.FormattingEnabled = true;
            this.cmb_StatusFilter.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cmb_StatusFilter.Location = new System.Drawing.Point(48, 152);
            this.cmb_StatusFilter.Name = "cmb_StatusFilter";
            this.cmb_StatusFilter.Size = new System.Drawing.Size(287, 21);
            this.cmb_StatusFilter.TabIndex = 39;
            // 
            // txt_usernameORemail
            // 
            this.txt_usernameORemail.BackColor = System.Drawing.Color.LightGray;
            this.txt_usernameORemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usernameORemail.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usernameORemail.Location = new System.Drawing.Point(48, 237);
            this.txt_usernameORemail.Multiline = true;
            this.txt_usernameORemail.Name = "txt_usernameORemail";
            this.txt_usernameORemail.Size = new System.Drawing.Size(287, 31);
            this.txt_usernameORemail.TabIndex = 40;
            // 
            // lbl_StatusFilter
            // 
            this.lbl_StatusFilter.AutoSize = true;
            this.lbl_StatusFilter.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusFilter.ForeColor = System.Drawing.Color.Gray;
            this.lbl_StatusFilter.Location = new System.Drawing.Point(44, 119);
            this.lbl_StatusFilter.Name = "lbl_StatusFilter";
            this.lbl_StatusFilter.Size = new System.Drawing.Size(145, 24);
            this.lbl_StatusFilter.TabIndex = 41;
            this.lbl_StatusFilter.Text = "Status Filter";
            // 
            // lbl_accsReqsSearch
            // 
            this.lbl_accsReqsSearch.AutoSize = true;
            this.lbl_accsReqsSearch.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accsReqsSearch.ForeColor = System.Drawing.Color.Gray;
            this.lbl_accsReqsSearch.Location = new System.Drawing.Point(44, 201);
            this.lbl_accsReqsSearch.Name = "lbl_accsReqsSearch";
            this.lbl_accsReqsSearch.Size = new System.Drawing.Size(291, 24);
            this.lbl_accsReqsSearch.TabIndex = 42;
            this.lbl_accsReqsSearch.Text = "Search username or email";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_Refresh.Location = new System.Drawing.Point(563, 136);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(218, 42);
            this.btn_Refresh.TabIndex = 43;
            this.btn_Refresh.Text = "Refresh Grid";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_RequestCount
            // 
            this.lbl_RequestCount.AutoSize = true;
            this.lbl_RequestCount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RequestCount.ForeColor = System.Drawing.Color.Gray;
            this.lbl_RequestCount.Location = new System.Drawing.Point(297, 524);
            this.lbl_RequestCount.Name = "lbl_RequestCount";
            this.lbl_RequestCount.Size = new System.Drawing.Size(222, 24);
            this.lbl_RequestCount.TabIndex = 44;
            this.lbl_RequestCount.Text = "Showing 5 requests";
            // 
            // btn_accsReqsExport
            // 
            this.btn_accsReqsExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_accsReqsExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_accsReqsExport.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accsReqsExport.ForeColor = System.Drawing.Color.Transparent;
            this.btn_accsReqsExport.Location = new System.Drawing.Point(563, 226);
            this.btn_accsReqsExport.Name = "btn_accsReqsExport";
            this.btn_accsReqsExport.Size = new System.Drawing.Size(218, 42);
            this.btn_accsReqsExport.TabIndex = 45;
            this.btn_accsReqsExport.Text = "Export";
            this.btn_accsReqsExport.UseVisualStyleBackColor = false;
            this.btn_accsReqsExport.Click += new System.EventHandler(this.btn_accsReqsExport_Click);
            // 
            // AccountsRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 574);
            this.Controls.Add(this.btn_accsReqsExport);
            this.Controls.Add(this.lbl_RequestCount);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_accsReqsSearch);
            this.Controls.Add(this.lbl_StatusFilter);
            this.Controls.Add(this.txt_usernameORemail);
            this.Controls.Add(this.cmb_StatusFilter);
            this.Controls.Add(this.dgv_Requests);
            this.Controls.Add(this.lbl_accsReqsCross);
            this.Controls.Add(this.lbl_accsReqs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsRequests";
            this.Text = "AccountsRequests";
            this.Load += new System.EventHandler(this.AccountsRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Requests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_accsReqs;
        private System.Windows.Forms.Label lbl_accsReqsCross;
        private System.Windows.Forms.DataGridView dgv_Requests;
        private System.Windows.Forms.ComboBox cmb_StatusFilter;
        private System.Windows.Forms.TextBox txt_usernameORemail;
        private System.Windows.Forms.Label lbl_StatusFilter;
        private System.Windows.Forms.Label lbl_accsReqsSearch;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_RequestCount;
        private System.Windows.Forms.Button btn_accsReqsExport;
    }
}