namespace EPCPROJECT
{
    partial class EmpDashboardUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpDashboardUserControl));
            this.lbl_empdashboard = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_empviewEPCs = new System.Windows.Forms.Button();
            this.btn_empfilterData = new System.Windows.Forms.Button();
            this.btn_empviewNotifs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_empdashboard
            // 
            this.lbl_empdashboard.AutoSize = true;
            this.lbl_empdashboard.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empdashboard.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_empdashboard.Location = new System.Drawing.Point(272, 44);
            this.lbl_empdashboard.Name = "lbl_empdashboard";
            this.lbl_empdashboard.Size = new System.Drawing.Size(312, 33);
            this.lbl_empdashboard.TabIndex = 10;
            this.lbl_empdashboard.Text = "Employee Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(409, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btn_empviewEPCs
            // 
            this.btn_empviewEPCs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(123)))), ((int)(((byte)(65)))));
            this.btn_empviewEPCs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empviewEPCs.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empviewEPCs.ForeColor = System.Drawing.Color.Transparent;
            this.btn_empviewEPCs.Location = new System.Drawing.Point(58, 209);
            this.btn_empviewEPCs.Name = "btn_empviewEPCs";
            this.btn_empviewEPCs.Size = new System.Drawing.Size(303, 42);
            this.btn_empviewEPCs.TabIndex = 32;
            this.btn_empviewEPCs.Text = "View all EPCs";
            this.btn_empviewEPCs.UseVisualStyleBackColor = false;
            // 
            // btn_empfilterData
            // 
            this.btn_empfilterData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(163)))), ((int)(((byte)(40)))));
            this.btn_empfilterData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empfilterData.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empfilterData.ForeColor = System.Drawing.Color.Transparent;
            this.btn_empfilterData.Location = new System.Drawing.Point(58, 330);
            this.btn_empfilterData.Name = "btn_empfilterData";
            this.btn_empfilterData.Size = new System.Drawing.Size(303, 42);
            this.btn_empfilterData.TabIndex = 33;
            this.btn_empfilterData.Text = "Filter EPC Data";
            this.btn_empfilterData.UseVisualStyleBackColor = false;
            // 
            // btn_empviewNotifs
            // 
            this.btn_empviewNotifs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.btn_empviewNotifs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empviewNotifs.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empviewNotifs.ForeColor = System.Drawing.Color.Transparent;
            this.btn_empviewNotifs.Location = new System.Drawing.Point(58, 450);
            this.btn_empviewNotifs.Name = "btn_empviewNotifs";
            this.btn_empviewNotifs.Size = new System.Drawing.Size(303, 42);
            this.btn_empviewNotifs.TabIndex = 34;
            this.btn_empviewNotifs.Text = "View Notifications";
            this.btn_empviewNotifs.UseVisualStyleBackColor = false;
            // 
            // EmpDashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_empviewNotifs);
            this.Controls.Add(this.btn_empfilterData);
            this.Controls.Add(this.btn_empviewEPCs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_empdashboard);
            this.Name = "EmpDashboardUserControl";
            this.Size = new System.Drawing.Size(853, 586);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_empdashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_empviewEPCs;
        private System.Windows.Forms.Button btn_empfilterData;
        private System.Windows.Forms.Button btn_empviewNotifs;
    }
}
