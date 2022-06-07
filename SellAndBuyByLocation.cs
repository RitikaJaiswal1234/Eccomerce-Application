using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication
{
    public class SellAndBuyByLocation
    {
        public string Location { get; set; }
        public int SellingProduct { get; set; }
        public int BuyingProduct { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public SellAndBuyByLocation()
        {

        }
        public SellAndBuyByLocation(String location, int sellingProduct, int buyingProduct)
        {
            this.Location = location;
            this.SellingProduct = sellingProduct;
            this.BuyingProduct = buyingProduct;
        }
    }
    public class SellDataByLocation
    {
        public string SellingLocation { get; set; }
        public int SellingQuantity { get; set; }
        public SellDataByLocation()
        {

        }
        public SellDataByLocation (string sellingLocation, int sellingQuantity)
        {
            this.SellingLocation = sellingLocation;
            this.SellingQuantity = sellingQuantity;
        }
    }
    public class BuyerDataLocation
    {
        public string BuyerLocation { get; set; }
        public int BuyerQuantity { get; set; }
        public BuyerDataLocation() { }
        public BuyerDataLocation(string buyerLocation, int buyquantity)
        {
            this.BuyerLocation = buyerLocation;
            this.BuyerQuantity = buyquantity;
        }
    }
}
