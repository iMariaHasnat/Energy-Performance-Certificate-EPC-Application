namespace EPCPROJECT
{
    partial class DataUpdateControl3
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
            this.lbl_dataupdate = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.dataGridView_recentepc = new System.Windows.Forms.DataGridView();
            this.btn_oldepcfiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sendNotif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recentepc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dataupdate
            // 
            this.lbl_dataupdate.AutoSize = true;
            this.lbl_dataupdate.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataupdate.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_dataupdate.Location = new System.Drawing.Point(317, 44);
            this.lbl_dataupdate.Name = "lbl_dataupdate";
            this.lbl_dataupdate.Size = new System.Drawing.Size(193, 33);
            this.lbl_dataupdate.TabIndex = 6;
            this.lbl_dataupdate.Text = "Data Update";
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_import.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.White;
            this.btn_import.Location = new System.Drawing.Point(54, 143);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(267, 46);
            this.btn_import.TabIndex = 7;
            this.btn_import.Text = "Import / Update EPC Data";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // dataGridView_recentepc
            // 
            this.dataGridView_recentepc.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_recentepc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_recentepc.Location = new System.Drawing.Point(54, 280);
            this.dataGridView_recentepc.Name = "dataGridView_recentepc";
            this.dataGridView_recentepc.Size = new System.Drawing.Size(737, 245);
            this.dataGridView_recentepc.TabIndex = 8;
            this.dataGridView_recentepc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_recentepc_CellContentClick);
            // 
            // btn_oldepcfiles
            // 
            this.btn_oldepcfiles.BackColor = System.Drawing.Color.White;
            this.btn_oldepcfiles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_oldepcfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_oldepcfiles.Location = new System.Drawing.Point(591, 200);
            this.btn_oldepcfiles.Name = "btn_oldepcfiles";
            this.btn_oldepcfiles.Size = new System.Drawing.Size(200, 46);
            this.btn_oldepcfiles.TabIndex = 9;
            this.btn_oldepcfiles.Text = "See Old EPC Files";
            this.btn_oldepcfiles.UseVisualStyleBackColor = false;
            this.btn_oldepcfiles.Click += new System.EventHandler(this.btn_oldepcfiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recent Data shows here";
            // 
            // btn_sendNotif
            // 
            this.btn_sendNotif.BackColor = System.Drawing.Color.White;
            this.btn_sendNotif.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_sendNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(94)))), ((int)(((byte)(59)))));
            this.btn_sendNotif.Location = new System.Drawing.Point(419, 143);
            this.btn_sendNotif.Name = "btn_sendNotif";
            this.btn_sendNotif.Size = new System.Drawing.Size(372, 46);
            this.btn_sendNotif.TabIndex = 11;
            this.btn_sendNotif.Text = "Send Update Notification to Employees";
            this.btn_sendNotif.UseVisualStyleBackColor = false;
            this.btn_sendNotif.Click += new System.EventHandler(this.btn_sendNotif_Click);
            // 
            // DataUpdateControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_sendNotif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_oldepcfiles);
            this.Controls.Add(this.dataGridView_recentepc);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.lbl_dataupdate);
            this.Name = "DataUpdateControl3";
            this.Size = new System.Drawing.Size(853, 586);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recentepc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dataupdate;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.DataGridView dataGridView_recentepc;
        private System.Windows.Forms.Button btn_oldepcfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sendNotif;
    }
}
