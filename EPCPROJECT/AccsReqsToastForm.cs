using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace EPCPROJECT
{
    public partial class AccsReqsToastForm : Form
    {
        int toastX, toastY;
        public AccsReqsToastForm(string toastmsgReqs)
        {
            InitializeComponent();
            lbl_ReqsToastmessage.Text = toastmsgReqs;
            this.TopMost = true;

            // 1) Handle clicks on the form itself
            this.Click += Toast_Click;

            // 2) Also handle clicks on any child control (labels, panels, etc.)
            foreach (Control ctl in this.Controls)
                ctl.Click += Toast_Click;
        }

        private void Toast_Click(object sender, EventArgs e)
        {
            // Open the account‑requests console
            var reqForm = new AccountsRequests();
            reqForm.Show();

            // Close the toast
            this.Close();
        }

        private void AccsReqsToastForm_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 10; // 10 pixels from the right edge
            toastY = ScreenHeight - this.Height - 10; // 10 pixels from the bottom edge

            this.Location = new Point(toastX, toastY);
        }
    }
}
