namespace EPCPROJECT
{
    partial class NotificationsUserControl3
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
            this.lbl_notifications = new System.Windows.Forms.Label();
            this.dataGridView_notifications = new System.Windows.Forms.DataGridView();
            this.lbl_listofnotifs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_notifications)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_notifications
            // 
            this.lbl_notifications.AutoSize = true;
            this.lbl_notifications.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notifications.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_notifications.Location = new System.Drawing.Point(322, 44);
            this.lbl_notifications.Name = "lbl_notifications";
            this.lbl_notifications.Size = new System.Drawing.Size(196, 33);
            this.lbl_notifications.TabIndex = 10;
            this.lbl_notifications.Text = "Notifications";
            // 
            // dataGridView_notifications
            // 
            this.dataGridView_notifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_notifications.Location = new System.Drawing.Point(65, 194);
            this.dataGridView_notifications.Name = "dataGridView_notifications";
            this.dataGridView_notifications.Size = new System.Drawing.Size(719, 336);
            this.dataGridView_notifications.TabIndex = 11;
            // 
            // lbl_listofnotifs
            // 
            this.lbl_listofnotifs.AutoSize = true;
            this.lbl_listofnotifs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listofnotifs.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_listofnotifs.Location = new System.Drawing.Point(61, 126);
            this.lbl_listofnotifs.Name = "lbl_listofnotifs";
            this.lbl_listofnotifs.Size = new System.Drawing.Size(232, 24);
            this.lbl_listofnotifs.TabIndex = 12;
            this.lbl_listofnotifs.Text = "List of all notifications";
            // 
            // NotificationsUserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_listofnotifs);
            this.Controls.Add(this.dataGridView_notifications);
            this.Controls.Add(this.lbl_notifications);
            this.Name = "NotificationsUserControl3";
            this.Size = new System.Drawing.Size(853, 586);
            this.Load += new System.EventHandler(this.NotificationsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_notifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_notifications;
        private System.Windows.Forms.DataGridView dataGridView_notifications;
        private System.Windows.Forms.Label lbl_listofnotifs;
    }
}
