using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPCPROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wscreen_timer_Tick(object sender, EventArgs e)
        {
            wscreen_panel2.Width += 3;

            if (wscreen_panel2.Width >= 1179)
            {
                wscreen_timer.Stop();
                Login_Form f2 = new Login_Form();
                f2.Show();
                this.Hide();
            }
        }
    }
}
