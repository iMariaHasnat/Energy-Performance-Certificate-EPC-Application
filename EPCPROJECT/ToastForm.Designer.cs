namespace EPCPROJECT
{
    partial class ToastForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToastForm));
            this.panel_toastborder = new System.Windows.Forms.Panel();
            this.lbl_toasttitle = new System.Windows.Forms.Label();
            this.lbl_toastmessage = new System.Windows.Forms.Label();
            this.picturebx_toast = new System.Windows.Forms.PictureBox();
            this.label_toastCross = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebx_toast)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_toastborder
            // 
            this.panel_toastborder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(155)))), ((int)(((byte)(53)))));
            this.panel_toastborder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_toastborder.Location = new System.Drawing.Point(0, 0);
            this.panel_toastborder.Name = "panel_toastborder";
            this.panel_toastborder.Size = new System.Drawing.Size(10, 68);
            this.panel_toastborder.TabIndex = 0;
            // 
            // lbl_toasttitle
            // 
            this.lbl_toasttitle.AutoSize = true;
            this.lbl_toasttitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toasttitle.Location = new System.Drawing.Point(77, 15);
            this.lbl_toasttitle.Name = "lbl_toasttitle";
            this.lbl_toasttitle.Size = new System.Drawing.Size(85, 17);
            this.lbl_toasttitle.TabIndex = 2;
            this.lbl_toasttitle.Text = "Data Update";
            // 
            // lbl_toastmessage
            // 
            this.lbl_toastmessage.AutoSize = true;
            this.lbl_toastmessage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_toastmessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toastmessage.Location = new System.Drawing.Point(77, 36);
            this.lbl_toastmessage.Name = "lbl_toastmessage";
            this.lbl_toastmessage.Size = new System.Drawing.Size(219, 17);
            this.lbl_toastmessage.TabIndex = 3;
            this.lbl_toastmessage.Text = "Admin has updated new EPC data!";
            // 
            // picturebx_toast
            // 
            this.picturebx_toast.Image = ((System.Drawing.Image)(resources.GetObject("picturebx_toast.Image")));
            this.picturebx_toast.Location = new System.Drawing.Point(16, 16);
            this.picturebx_toast.Name = "picturebx_toast";
            this.picturebx_toast.Size = new System.Drawing.Size(51, 35);
            this.picturebx_toast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebx_toast.TabIndex = 1;
            this.picturebx_toast.TabStop = false;
            // 
            // label_toastCross
            // 
            this.label_toastCross.AutoSize = true;
            this.label_toastCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_toastCross.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_toastCross.ForeColor = System.Drawing.Color.Black;
            this.label_toastCross.Location = new System.Drawing.Point(305, 1);
            this.label_toastCross.Name = "label_toastCross";
            this.label_toastCross.Size = new System.Drawing.Size(24, 25);
            this.label_toastCross.TabIndex = 4;
            this.label_toastCross.Text = "X";
            this.label_toastCross.Click += new System.EventHandler(this.label_toastCross_Click);
            // 
            // ToastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 68);
            this.Controls.Add(this.label_toastCross);
            this.Controls.Add(this.lbl_toastmessage);
            this.Controls.Add(this.lbl_toasttitle);
            this.Controls.Add(this.picturebx_toast);
            this.Controls.Add(this.panel_toastborder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastForm";
            this.Text = "ToastForm";
            this.Load += new System.EventHandler(this.ToastForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebx_toast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_toastborder;
        private System.Windows.Forms.PictureBox picturebx_toast;
        private System.Windows.Forms.Label lbl_toasttitle;
        private System.Windows.Forms.Label lbl_toastmessage;
        private System.Windows.Forms.Label label_toastCross;
    }
}