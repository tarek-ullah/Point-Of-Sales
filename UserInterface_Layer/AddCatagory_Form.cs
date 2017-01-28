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
    public partial class AddCatagory_Form : MetroForm
    {
        string catagory_name, catagory_description;
        int catagory_unit, catagory_id;

        CatagoryData catagoryDataobj = new CatagoryData();
        
 
        
        public AddCatagory_Form()
        {
            InitializeComponent();
        }

        private void AddCatagory_Form_Load(object sender, EventArgs e)
        {

        }

        private void Catagory_Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Catagory_Reset_button_Click(object sender, EventArgs e) {

            ca_name_TextBox.Clear();
            richTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
         }


        private void Catagory_Save_button_Click(object sender, EventArgs e)
        {

            catagory_id = int.Parse(textBox1.Text);
            catagory_name = ca_name_TextBox.Text;
            catagory_unit = int.Parse(textBox2.Text);
            catagory_description = richTextBox1.Text.ToString();

            Catagory catagoryObj = new Catagory();
            catagoryObj.Catagory_Name = catagory_name;
            catagoryObj.Catagory_Unit = catagory_unit;
            catagoryObj.Catagory_ID = catagory_id;
            catagoryObj.Catagory_Description = catagory_description;
            catagoryDataobj.Insert(catagoryObj);
            MessageBox.Show("New Catagory added successfully");

        }

    }
}
