namespace EPCPROJECT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.wscreen_bgpicture = new System.Windows.Forms.PictureBox();
            this.wscreen_panel1 = new System.Windows.Forms.Panel();
            this.wscreen_panel2 = new System.Windows.Forms.Panel();
            this.wscreen_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wscreen_bgpicture)).BeginInit();
            this.wscreen_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wscreen_bgpicture
            // 
            this.wscreen_bgpicture.BackColor = System.Drawing.Color.White;
            this.wscreen_bgpicture.Image = global::EPCPROJECT.Properties.Resources.Red_and_Green_Gradient_Pitch_Deck_Presentation;
            this.wscreen_bgpicture.Location = new System.Drawing.Point(-3, 0);
            this.wscreen_bgpicture.Name = "wscreen_bgpicture";
            this.wscreen_bgpicture.Size = new System.Drawing.Size(1179, 665);
            this.wscreen_bgpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wscreen_bgpicture.TabIndex = 0;
            this.wscreen_bgpicture.TabStop = false;
            // 
            // wscreen_panel1
            // 
            this.wscreen_panel1.BackColor = System.Drawing.Color.White;
            this.wscreen_panel1.Controls.Add(this.wscreen_panel2);
            this.wscreen_panel1.Location = new System.Drawing.Point(-3, 659);
            this.wscreen_panel1.Name = "wscreen_panel1";
            this.wscreen_panel1.Size = new System.Drawing.Size(1179, 22);
            this.wscreen_panel1.TabIndex = 1;
            // 
            // wscreen_panel2
            // 
            this.wscreen_panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.wscreen_panel2.Location = new System.Drawing.Point(3, 0);
            this.wscreen_panel2.Name = "wscreen_panel2";
            this.wscreen_panel2.Size = new System.Drawing.Size(48, 22);
            this.wscreen_panel2.TabIndex = 2;
            // 
            // wscreen_timer
            // 
            this.wscreen_timer.Enabled = true;
            this.wscreen_timer.Interval = 1;
            this.wscreen_timer.Tick += new System.EventHandler(this.wscreen_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 681);
            this.Controls.Add(this.wscreen_panel1);
            this.Controls.Add(this.wscreen_bgpicture);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wscreen_bgpicture)).EndInit();
            this.wscreen_panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox wscreen_bgpicture;
        private System.Windows.Forms.Panel wscreen_panel1;
        private System.Windows.Forms.Panel wscreen_panel2;
        private System.Windows.Forms.Timer wscreen_timer;
    }
}

