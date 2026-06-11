namespace EPCPROJECT
{
    partial class EmpData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpData));
            this.lbl_empdata = new System.Windows.Forms.Label();
            this.btn_allEPCs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_empdata
            // 
            this.lbl_empdata.AutoSize = true;
            this.lbl_empdata.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empdata.ForeColor = System.Drawing.Color.Black;
            this.lbl_empdata.Location = new System.Drawing.Point(376, 44);
            this.lbl_empdata.Name = "lbl_empdata";
            this.lbl_empdata.Size = new System.Drawing.Size(81, 33);
            this.lbl_empdata.TabIndex = 11;
            this.lbl_empdata.Text = "Data";
            // 
            // btn_allEPCs
            // 
            this.btn_allEPCs.BackColor = System.Drawing.Color.Transparent;
            this.btn_allEPCs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_allEPCs.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_allEPCs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_allEPCs.Location = new System.Drawing.Point(241, 155);
            this.btn_allEPCs.Name = "btn_allEPCs";
            this.btn_allEPCs.Size = new System.Drawing.Size(351, 49);
            this.btn_allEPCs.TabIndex = 30;
            this.btn_allEPCs.Text = "See old EPCs";
            this.btn_allEPCs.UseVisualStyleBackColor = false;
            this.btn_allEPCs.Click += new System.EventHandler(this.btn_allEPCs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // EmpData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_allEPCs);
            this.Controls.Add(this.lbl_empdata);
            this.Name = "EmpData";
            this.Size = new System.Drawing.Size(853, 586);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_empdata;
        private System.Windows.Forms.Button btn_allEPCs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
