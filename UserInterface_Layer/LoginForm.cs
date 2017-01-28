using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DataLayer;

namespace Point_Of_Sales
{
    public partial class LoginForm : MetroForm
    {
        EmployeeData employeData = new EmployeeData();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            string userName = userName_textField.Text;
            string password = password_textField.Text;
            
            if(employeData.Login(userName, password))
            {
                DashBoard DB = new DashBoard();
                DB.Show();
            }
            else
            {
                MessageBox.Show("Incorrect usrname or password");
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
