using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll_Managment_System.Shared;

namespace Payroll_Managment_System.Forms
{
    public partial class frmEmployeeSetup : Form
    {
        Employee _employee;
        public frmEmployeeSetup(Employee Employee)
        {
            InitializeComponent();
            _employee = Employee;

            loadRecord();

      }

        private void loadRecord()
        {
            txtFirstName.Text = _employee.FirstName;
            txtLastName.Text = _employee.LastName;
            txtPayRate.Text = _employee.PayRate.ToString();
            txtDesignation.Text = _employee.Designation;
            cbEmpoyeeType.SelectedIndex =(int) _employee.EmployeeType;
              
              
        }

        private bool SaveRecord() {
            bool Ret = false;
            _employee.FirstName = txtFirstName.Text;
            _employee.LastName = txtLastName.Text;
            _employee.PayRate = Decimal.Parse(txtPayRate.Text);
            _employee.Designation = txtDesignation.Text;
            _employee.EmployeeType = (EmployeeType)cbEmpoyeeType.SelectedIndex;
            _employee.Active = true;
            if (_employee.Id == 0)
            {
              
                Ret = Shared.Global.SaveEmployee(_employee);
              
            }
            else {
                Ret = Shared.Global.UpdateEmployee(_employee);
            }

            return Ret;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveRecord()) {
                MessageBox.Show("Record Saved!");
            }
            Close();
        }
    }
}
