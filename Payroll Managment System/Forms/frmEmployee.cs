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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            dgEmployee.DataSource = Shared.Global.GetEmployees();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmEmployeeSetup frmEmployeeSetup = new frmEmployeeSetup(new Shared.Employee());
            frmEmployeeSetup.ShowDialog();
            RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgEmployee.SelectedRows.Count > 0)
            {

                frmEmployeeSetup frmEmployeeSetup = new frmEmployeeSetup(Shared.Global.GetEmployee((int)dgEmployee.SelectedRows[0].Cells["Id"].Value));
                frmEmployeeSetup.ShowDialog();
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please Select employee");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgEmployee.SelectedRows.Count > 0)
            {
                if (Shared.Global.DeleteEmployee((int)dgEmployee.SelectedRows[0].Cells["Id"].Value))
                {
                    MessageBox.Show("Record has been Deleted!");
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Unable to Delete record");
                }
            }
        }
    }
}
