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
    public partial class AddSupplier_Form : MetroForm
    {
        string  supp_name, supp_phone, supp_email;
        int supp_id;

        SupplierData suppDataObj = new SupplierData();
        public AddSupplier_Form()
        {
            InitializeComponent();
        }

        private void AddSupplier_Form_Load(object sender, EventArgs e)
        {

        }
        private void addSupplierSave_Button_Click(object sender, EventArgs e)
        {
            supp_id = int.Parse(addSupplierID_Text.Text);
            supp_name = addSupplierName_Text.Text;
            supp_phone = addSupplierPhone_text.Text;
            supp_email = addSupplierEmail_text.Text;

            Supplier suppObj = new Supplier();
            suppObj.Supplier_ID = supp_id;
            suppObj.Supplier_Name = supp_name;
            suppObj.Supplier_Phone = supp_phone;
            suppObj.Supplier_Email = supp_email;

            suppDataObj.insert(suppObj);
            MessageBox.Show("New Supplier added successfully");

        }

        private void addSupplierReset_Button_Click(object sender, EventArgs e)
        {
            addSupplierID_Text.Clear();
            addSupplierName_Text.Clear();
            addSupplierPhone_text.Clear();
            addSupplierEmail_text.Clear();
        }

        private void addSupplierClose_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
