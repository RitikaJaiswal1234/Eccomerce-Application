using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EcommerceApplication
{
    public class SallerData
    {
        public int SallerId { get; set; }
        public string SallerName { get; set; }
        public string Location { get; set; }
        public int SellingProduct { get; internal set; }

        public SallerData(int sallerId, string sallerName, string location )
        {
            SallerId = sallerId;
            SallerName = sallerName;
            Location = location;
        }
    }
    public class TopSaller
    {
        public int SallerId { get; set; }
        public string SallerName { get; set; }
        public int Count { get; set; }
    }
    public class TopSellingProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
    }
}
