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
    public partial class AddCustomer_Form : MetroForm
    {
        string  cust_name, cust_address, cust_phone, cust_email;
        int customer_id;
        CustomerData customerdataobj = new CustomerData();
              

        public AddCustomer_Form()
        {
            InitializeComponent();
        }

        private void AddCustomer_Form_Load(object sender, EventArgs e)
        {

        }

        private void addCustomerReset_button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            adCustomerName_text.Clear();
            adCustomerAddress_text.Clear();
            adCustomerPhone_text.Clear();
            adCustomerEmail_text.Clear();

        }

        private void adCustomerClose_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adCustomerSave_Button_Click(object sender, EventArgs e)
        {
            customer_id = int.Parse(textBox1.Text);
            cust_email = adCustomerEmail_text.Text;
            cust_phone = adCustomerPhone_text.Text;
            cust_name = adCustomerName_text.Text;
            cust_address = adCustomerAddress_text.Text;

            Customer customerobj = new Customer();
            customerobj.Customer_ID = customer_id;
            customerobj.Customer_Name = cust_name;
            customerobj.Customer_Address = cust_address;
            customerobj.Customer_Phone = cust_phone;
            customerobj.Customer_Email = cust_email;
            customerdataobj.Insert(customerobj);
            MessageBox.Show("New customer added succesfully");
        }
    }
}
