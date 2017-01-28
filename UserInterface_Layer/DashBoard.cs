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
    public partial class DashBoard : MetroForm
    {
        CustomerData customerObj = new CustomerData();
        Int32 int_event_id;
        string  event_id;
        string sub_amount;
        Double g_unit_price; 
        Int64 g_stock, updated_stock;

        Double total_amount, d_unit_price, vat, discount, payment_cash, bill;

        public DashBoard()
        { 
            InitializeComponent();
            DashBoard_Panel.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DashBoard_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {        
        }

        private void Customer_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Panel.BringToFront();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Panel.BringToFront();
        }

        private void catagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catagory_Panel.BringToFront();
        }

        private void Supplier_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier_Panel.BringToFront();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Panel.BringToFront();
        }

        private void ssalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Panel.BringToFront();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Panel.BringToFront();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_panel.BringToFront();
        }

        private void AddProduct_Button_Click(object sender, EventArgs e)
        {
            new AddProduct_Form().Show();
        }

        private void AddCatagory_button_Click(object sender, EventArgs e)
        {
            new AddCatagory_Form().Show();
        }

        private void AddSupplier_button_Click(object sender, EventArgs e)
        {
            new AddSupplier_Form().Show();
                
        }

        private void addCustomer_button_Click(object sender, EventArgs e)
        {
            new AddCustomer_Form().Show();
        }

        private void AddEmployee_button_Click(object sender, EventArgs e)
        {
            new AddEmployee_From().Show();
        }


        private void employeebtn_Click(object sender, EventArgs e)
        {
            EmployeeData emp = new EmployeeData();
            DataTable event_dt = new DataTable();
            event_dt = emp.show();
            BindingSource b_source = new BindingSource();
            b_source.DataSource = event_dt;
            dataGridView4.DataSource = b_source;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductData prod = new ProductData();
            DataTable event_dt = new DataTable();
            event_dt = prod.showProducts();
            BindingSource b_source = new BindingSource();
            b_source.DataSource = event_dt;
            dataGridView1.DataSource = b_source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatagoryData cata = new CatagoryData();
            DataTable event_dt = new DataTable();
            event_dt = cata.showCatagory();
            BindingSource b_source = new BindingSource();
            b_source.DataSource = event_dt;
            dataGridView2.DataSource = b_source;
        }

        private void supplierbtn_Click(object sender, EventArgs e)
        {
            SupplierData supp = new SupplierData();
            DataTable event_dt = new DataTable();
            event_dt = supp.showSupplier();
            BindingSource b_source = new BindingSource();
            b_source.DataSource = event_dt;
            dataGridView3.DataSource = b_source;

        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            CustomerData cust = new CustomerData();
            DataTable event_dt = new DataTable();
            event_dt = cust.showCustomer();
            BindingSource b_source = new BindingSource();
            b_source.DataSource = event_dt;
            dataGridView5.DataSource = b_source;

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (System.Windows.Forms.DataGridView)sender;
            MessageBox.Show(grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            subAmmount_text.Text = null;
            textBox1.Text = null;
            vat_text.Text = null;
            discount_text.Text = null;
            paymentCash_text.Text = null;
            change_text.Text = null;




        }

        private void button6_Click(object sender, EventArgs e)
        {
            new AddEmployee_From().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new AddProduct_Form().Show(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new AddCatagory_Form().Show(); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new AddSupplier_Form().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new AddCustomer_Form().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            subAmmount_text.Text = sub_amount;
            textBox1.Text = g_unit_price.ToString();
            try {
                vat = Double.Parse(vat_text.Text);
                vat = vat / 100;
                discount = Double.Parse(discount_text.Text);
                payment_cash = Double.Parse(paymentCash_text.Text);
            }
            catch(Exception en)
            {
                MessageBox.Show("vat , dicpount, payment cash fields are required;"); 
            }
               d_unit_price = g_unit_price;
               total_amount = Double.Parse(sub_amount);
             
               bill = (total_amount * d_unit_price * vat) - discount;
               change_text.Text = bill.ToString();
               Double due;
               due = bill - payment_cash;
            
              ProductData pro = new ProductData();
              pro.updateProducts(updated_stock, int_event_id);

              MessageBox.Show("Total charge " + bill.ToString() + "tk " + "\n" + "Due " + due);
        }

        private void Sales_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showProductBtn_Click(object sender, EventArgs e)
        {
            event_id = Barcode_text.Text;
             
            int_event_id = Int32.Parse(event_id);
            ProductData prod = new ProductData();
            DataTable event_dt = new DataTable();
            event_dt = prod.idMatchedProducts(int_event_id);
            BindingSource b_source = new BindingSource();
            b_source.DataSource = event_dt;
            dataGridView6.DataSource = b_source;
            
            IEnumerable<Double> query = from dt in event_dt.AsEnumerable()
                                        select dt.Field<Double>("Unit_Price");

            //Get all unit price
            foreach (Double price  in query)
            {
                g_unit_price = price; 
            }


              string stock_s;
              stock_s = event_dt.Rows[0][2].ToString();
              g_stock = Int64.Parse(stock_s);
             
            //MessageBox.Show(test);
            
        }

        private void dataGridView6_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
             var grid = (System.Windows.Forms.DataGridView)sender;
             sub_amount =grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
             Int64 changed;
             changed = Int64.Parse(sub_amount);
             updated_stock =  g_stock - changed ;              
        }

        private void subAmmount_lable_Click(object sender, EventArgs e)
        {

        }

        private void subAmmount_text_Click(object sender, EventArgs e)
        {

        }
    }
}
