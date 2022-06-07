using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication
{
    public class BuyerData
    {
        public int BuyerId { get; set; }
        public string BuyerName { get; set; }
        public string Location { get; set; }
        public int BuyingProduct { get; internal set; }

        public BuyerData(int buyerId, string buyerName, string location)
        {
            BuyerId = buyerId;
            BuyerName = buyerName;
            Location = location;
        }
    }
    public class TopBuyerProduct
    {
        public int BuyerId { get; set; }
        public string BuyerName { get; set; }
        public int Count { get; set; }
    }
}
