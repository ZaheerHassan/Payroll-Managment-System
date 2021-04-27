using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Managment_System.Forms
{
    public partial class frmWorklogs : Form
    {
        public frmWorklogs()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            dgWorklog.DataSource = Shared.Global.GetWorklogs();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmWorklogSetup frmWorklogSetup = new frmWorklogSetup(new Shared.WorkLog());
            frmWorklogSetup.ShowDialog();
        }
    }
}
