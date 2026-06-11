using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EPCPROJECT
{
    public partial class ToastForm : Form
    {
        int toastX, toastY;
        public ToastForm(string toastMessage)
        {
            InitializeComponent();
            lbl_toastmessage.Text = toastMessage;
            this.TopMost = true;
        }

        public ToastForm() : this(string.Empty)
        {
        }

        private void ToastForm_Load(object sender, EventArgs e)
        {

            Position();

        }

        private void label_toastCross_Click(object sender, EventArgs e)
        {
            this.Close();
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