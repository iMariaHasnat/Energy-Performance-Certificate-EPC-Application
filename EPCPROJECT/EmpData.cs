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
    public partial class EmpData : UserControl
    {
        public EmpData()
        {
            InitializeComponent();
        }

        private void btn_allEPCs_Click(object sender, EventArgs e)
        {
            OldEpcFiles oldEpcs = new OldEpcFiles();
            oldEpcs.Show();
        }
    }
}
