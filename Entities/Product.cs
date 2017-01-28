using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Product
    {
        public int Product_ID { get; set; }
        public double Unit_Cost { get; set; }
        public string Product_Description { get; set; }
        public int Stock { get; set; }
        public int Supplier_ID { get; set; }

        public string Product_Name { get; set; }
        public int Catagory_ID { get; set; }
        public double Unit_Price { get; set; }
             

    }
}
