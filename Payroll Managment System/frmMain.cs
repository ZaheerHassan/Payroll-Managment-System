using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll_Managment_System.Forms;

namespace Payroll_Managment_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee frmEmployee = new frmEmployee();
            frmEmployee.ShowDialog();
                
        }

        private void btnWorkLog_Click(object sender, EventArgs e)
        {
            frmWorklogs frmWorklogs = new frmWorklogs();
            frmWorklogs.ShowDialog();
        }
    }
}
