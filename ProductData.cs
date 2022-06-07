using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication
{
    public class ProductData
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public ProductData(int productId, string productName)
        {
            ProductID = productId;
            ProductName = productName;
        }
        public override string ToString()
        {
            return ProductID + "," + ProductName;
        }
    }
}
   

