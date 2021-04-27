using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Managment_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Shared.Global.GetEmployee(1);
        }
      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = Shared.Global.Login(txtUserName.Text, txtPassword.Text);
            if (result == true)
            {
                MessageBox.Show("Login Sucessfully!");


                Hide();
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
            }
            else {
                MessageBox.Show("Login Failed!");
            }          
            }

        }
   

}
