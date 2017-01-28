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
    public partial class AddProduct_Form : MetroForm
    {
        string prod_name, prod_des;
        double prod_cost, prod_price;
        int prod_stock, prod_cata_id, prod_supp_id, prod_id;

        ProductData productDataObj = new ProductData();
        
        private void ProductReset_button_Click(object sender, EventArgs e)
        {
            adProductName_Text.Clear();
            adProductCode_text.Clear();
            textBox1.Clear();
            textBox2.Clear();
            adProductUnitCost_text.Clear();
            adProductUnitPrice_text.Clear();
            adProductDescription_richText.Clear();
            adProductStock_text.Clear();


        }

        private void Product_save_button_Click(object sender, EventArgs e)
        {
            prod_name = adProductName_Text.Text;
            prod_id = int.Parse(adProductCode_text.Text);
            prod_cata_id = int.Parse(textBox1.Text);
            prod_des = adProductDescription_richText.Text.ToString();
            prod_supp_id = int.Parse(textBox2.Text);
            prod_stock = int.Parse(adProductStock_text.Text);
            prod_cost = double.Parse(adProductUnitCost_text.Text);
            prod_price = double.Parse(adProductUnitPrice_text.Text);

            Product productObj = new Product();
            productObj.Product_ID = prod_id;
            productObj.Product_Name = prod_name;
            productObj.Product_Description = prod_des;
            productObj.Stock = prod_stock;
            productObj.Unit_Cost = prod_cost;
            productObj.Unit_Price = prod_price;
            productObj.Catagory_ID = prod_cata_id;
            productObj.Supplier_ID = prod_supp_id;

            productDataObj.insert(productObj);
            MessageBox.Show("New Product added succesfully");
           
            
           
        }

        public AddProduct_Form()
        {
            InitializeComponent();
        }

        private void AddProduct_Form_Load(object sender, EventArgs e)
        {

        }    

        private void ProductClose_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
