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
    public partial class frmWorklogSetup : Form
    {
        DataTable lstEmployees;
        WorkLog _WorkLog;

        public frmWorklogSetup(WorkLog workLog)
        {
            InitializeComponent();
            lstEmployees = Global.GetEmployees();
            cbEmployee.DataSource = lstEmployees;
            cbEmployee.DisplayMember = "FirstName";
            cbEmployee.ValueMember = "Id";
            _WorkLog = workLog;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _WorkLog.Date = dtDate.Value;
            _WorkLog.EmployeeId = (int)cbEmployee.SelectedValue;
            _WorkLog.WorkHoursOrDays = (int)numHours.Value;
            
            Shared.Global.SaveWorklog(_WorkLog);
        }

        private void cbEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
             if (cbEmployee.SelectedValue.GetType() == typeof (int)){
                int EmployeeID = (int)cbEmployee.SelectedValue;
                var employee = lstEmployees.AsEnumerable().FirstOrDefault(i => (int)i["Id"] == EmployeeID);
                if (employee != null)
                {
                    if ((EmployeeType)employee["EmployeeType"] == EmployeeType.DailyWages)
                    {
                        lbWorkHours.Text = "Hours";
                        numHours.Maximum = 24;
                    }
                    else
                    {
                        lbWorkHours.Text = "Days";
                        numHours.Maximum = DateTime.DaysInMonth(dtDate.Value.Year, dtDate.Value.Month);
                    }
                }
            }
            
            
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            numHours.Maximum = DateTime.DaysInMonth(dtDate.Value.Year, dtDate.Value.Month);
        }
    }
}
