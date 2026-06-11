namespace EPCPROJECT
{
    partial class OldEpcFiles
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
            this.dataGridViewOldFiles = new System.Windows.Forms.DataGridView();
            this.lbl_oldepcTitle = new System.Windows.Forms.Label();
            this.lbl_oldEPCsCross = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOldFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOldFiles
            // 
            this.dataGridViewOldFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOldFiles.Location = new System.Drawing.Point(63, 115);
            this.dataGridViewOldFiles.Name = "dataGridViewOldFiles";
            this.dataGridViewOldFiles.Size = new System.Drawing.Size(675, 302);
            this.dataGridViewOldFiles.TabIndex = 0;
            this.dataGridViewOldFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOldFiles_CellContentClick);
            // 
            // lbl_oldepcTitle
            // 
            this.lbl_oldepcTitle.AutoSize = true;
            this.lbl_oldepcTitle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oldepcTitle.ForeColor = System.Drawing.Color.Gray;
            this.lbl_oldepcTitle.Location = new System.Drawing.Point(59, 71);
            this.lbl_oldepcTitle.Name = "lbl_oldepcTitle";
            this.lbl_oldepcTitle.Size = new System.Drawing.Size(361, 24);
            this.lbl_oldepcTitle.TabIndex = 25;
            this.lbl_oldepcTitle.Text = "Old EPCs inlcuding recent ones:";
            // 
            // lbl_oldEPCsCross
            // 
            this.lbl_oldEPCsCross.AutoSize = true;
            this.lbl_oldEPCsCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_oldEPCsCross.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oldEPCsCross.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_oldEPCsCross.Location = new System.Drawing.Point(763, 9);
            this.lbl_oldEPCsCross.Name = "lbl_oldEPCsCross";
            this.lbl_oldEPCsCross.Size = new System.Drawing.Size(25, 24);
            this.lbl_oldEPCsCross.TabIndex = 36;
            this.lbl_oldEPCsCross.Text = "X";
            this.lbl_oldEPCsCross.Click += new System.EventHandler(this.lbl_oldEPCsCross_Click);
            // 
            // OldEpcFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_oldEPCsCross);
            this.Controls.Add(this.lbl_oldepcTitle);
            this.Controls.Add(this.dataGridViewOldFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OldEpcFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oldepcfiles";
            this.Load += new System.EventHandler(this.OldEpcFiles_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOldFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOldFiles;
        private System.Windows.Forms.Label lbl_oldepcTitle;
        private System.Windows.Forms.Label lbl_oldEPCsCross;
    }
}