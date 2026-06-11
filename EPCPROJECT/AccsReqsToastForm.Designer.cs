namespace EPCPROJECT
{
    partial class AccsReqsToastForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccsReqsToastForm));
            this.panel_accsReqsToastborder = new System.Windows.Forms.Panel();
            this.picturebx_toast = new System.Windows.Forms.PictureBox();
            this.lbl_ReqsToastmessage = new System.Windows.Forms.Label();
            this.lbl_ReqsToasttitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebx_toast)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_accsReqsToastborder
            // 
            this.panel_accsReqsToastborder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(155)))), ((int)(((byte)(53)))));
            this.panel_accsReqsToastborder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_accsReqsToastborder.Location = new System.Drawing.Point(0, 0);
            this.panel_accsReqsToastborder.Name = "panel_accsReqsToastborder";
            this.panel_accsReqsToastborder.Size = new System.Drawing.Size(10, 68);
            this.panel_accsReqsToastborder.TabIndex = 1;
            // 
            // picturebx_toast
            // 
            this.picturebx_toast.Image = ((System.Drawing.Image)(resources.GetObject("picturebx_toast.Image")));
            this.picturebx_toast.Location = new System.Drawing.Point(16, 16);
            this.picturebx_toast.Name = "picturebx_toast";
            this.picturebx_toast.Size = new System.Drawing.Size(51, 35);
            this.picturebx_toast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebx_toast.TabIndex = 2;
            this.picturebx_toast.TabStop = false;
            // 
            // lbl_ReqsToastmessage
            // 
            this.lbl_ReqsToastmessage.AutoSize = true;
            this.lbl_ReqsToastmessage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ReqsToastmessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReqsToastmessage.Location = new System.Drawing.Point(79, 36);
            this.lbl_ReqsToastmessage.Name = "lbl_ReqsToastmessage";
            this.lbl_ReqsToastmessage.Size = new System.Drawing.Size(205, 17);
            this.lbl_ReqsToastmessage.TabIndex = 5;
            this.lbl_ReqsToastmessage.Text = "An account has been requested!";
            // 
            // lbl_ReqsToasttitle
            // 
            this.lbl_ReqsToasttitle.AutoSize = true;
            this.lbl_ReqsToasttitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReqsToasttitle.Location = new System.Drawing.Point(79, 15);
            this.lbl_ReqsToasttitle.Name = "lbl_ReqsToasttitle";
            this.lbl_ReqsToasttitle.Size = new System.Drawing.Size(111, 17);
            this.lbl_ReqsToasttitle.TabIndex = 4;
            this.lbl_ReqsToasttitle.Text = "Account Request";
            // 
            // AccsReqsToastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 68);
            this.Controls.Add(this.lbl_ReqsToastmessage);
            this.Controls.Add(this.lbl_ReqsToasttitle);
            this.Controls.Add(this.picturebx_toast);
            this.Controls.Add(this.panel_accsReqsToastborder);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccsReqsToastForm";
            this.Text = "AccsReqsToastForm";
            this.Load += new System.EventHandler(this.AccsReqsToastForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebx_toast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_accsReqsToastborder;
        private System.Windows.Forms.PictureBox picturebx_toast;
        private System.Windows.Forms.Label lbl_ReqsToastmessage;
        private System.Windows.Forms.Label lbl_ReqsToasttitle;
    }
}