namespace EPCPROJECT
{
    partial class EmpNotifications
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
            this.lbl_empnotifs = new System.Windows.Forms.Label();
            this.dgv_empNotifs = new System.Windows.Forms.DataGridView();
            this.lbl_empNotifsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empNotifs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_empnotifs
            // 
            this.lbl_empnotifs.AutoSize = true;
            this.lbl_empnotifs.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empnotifs.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_empnotifs.Location = new System.Drawing.Point(295, 44);
            this.lbl_empnotifs.Name = "lbl_empnotifs";
            this.lbl_empnotifs.Size = new System.Drawing.Size(196, 33);
            this.lbl_empnotifs.TabIndex = 11;
            this.lbl_empnotifs.Text = "Notifications";
            // 
            // dgv_empNotifs
            // 
            this.dgv_empNotifs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empNotifs.Location = new System.Drawing.Point(69, 182);
            this.dgv_empNotifs.Name = "dgv_empNotifs";
            this.dgv_empNotifs.Size = new System.Drawing.Size(712, 337);
            this.dgv_empNotifs.TabIndex = 12;
            // 
            // lbl_empNotifsTitle
            // 
            this.lbl_empNotifsTitle.AutoSize = true;
            this.lbl_empNotifsTitle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empNotifsTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_empNotifsTitle.Location = new System.Drawing.Point(65, 123);
            this.lbl_empNotifsTitle.Name = "lbl_empNotifsTitle";
            this.lbl_empNotifsTitle.Size = new System.Drawing.Size(193, 24);
            this.lbl_empNotifsTitle.TabIndex = 25;
            this.lbl_empNotifsTitle.Text = "All notifications: ";
            // 
            // EmpNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_empNotifsTitle);
            this.Controls.Add(this.dgv_empNotifs);
            this.Controls.Add(this.lbl_empnotifs);
            this.Name = "EmpNotifications";
            this.Size = new System.Drawing.Size(853, 586);
            this.Load += new System.EventHandler(this.EmpNotifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empNotifs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_empnotifs;
        private System.Windows.Forms.DataGridView dgv_empNotifs;
        private System.Windows.Forms.Label lbl_empNotifsTitle;
    }
}
