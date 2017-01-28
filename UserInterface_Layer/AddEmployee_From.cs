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
using Entities;
using DataLayer;

namespace Point_Of_Sales
{
    public partial class AddEmployee_From : MetroForm
    {
        string name, password, phone, address, type;
        int emp_id;

        EmployeeData employeeDataObj = new EmployeeData();
        private void addEmployeeSave_Button_Click(object sender, EventArgs e)
        {
            emp_id =int.Parse(textBox1.Text);
            name = addEmployeeName_text.Text;
            password = addEmployeePassword_text.Text;
            phone = addEmployeePhone_text.Text;
            address = addEmployeeAddress_richText.Text.ToString();
            type = textBox2.Text;
            Employee employeeObj = new Employee();
            employeeObj.Employee_ID = emp_id;
            employeeObj.Employee_Name = name;
            employeeObj.Employee_Password = password;
            employeeObj.Employee_Phone = phone;
            employeeObj.Employee_Address = address;
            employeeObj.Employee_Type = type;

            employeeDataObj.insert(employeeObj);
            MessageBox.Show("New Employee added successfully");


        }

        private void addEmployeeReset_Button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            addEmployeeName_text.Clear();
            addEmployeePassword_text.Clear();
            addEmployeePhone_text.Clear();
            addEmployeeAddress_richText.Clear();

        }

        private void addEmployeeName_lable_Click(object sender, EventArgs e)
        {

        }

        public AddEmployee_From()
        {
            InitializeComponent();
        }

        private void AddEmployee_From_Load(object sender, EventArgs e)
        {

        }

        private void addEmployeeClose_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
