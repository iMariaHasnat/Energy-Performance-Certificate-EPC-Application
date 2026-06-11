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
    public partial class EmpDashboardUserControl : UserControl
    {
        public EmpDashboardUserControl()
        {
            InitializeComponent();

            // wire up your three buttons
            btn_empviewEPCs.Click += Btn_empviewEPCs_Click;
            btn_empfilterData.Click += Btn_empfilterData_Click;
            btn_empviewNotifs.Click += Btn_empviewNotifs_Click;
        }

        private void Btn_empviewEPCs_Click(object sender, EventArgs e)
        {
            // Find the host form and call its method
            var parent = this.FindForm() as EmployeeDashboard;
            parent?.ShowOldEpcFiles();
        }

        private void Btn_empfilterData_Click(object sender, EventArgs e)
        {
            var parent = this.FindForm() as EmployeeDashboard;
            parent?.ShowAnalytics();
        }

        private void Btn_empviewNotifs_Click(object sender, EventArgs e)
        {
            var parent = this.FindForm() as EmployeeDashboard;
            parent?.ShowNotifications();
        }
    }
}
