using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication
{
    public class TransectionData
    {
      
        public int Id { get; set; }
        public int SallerId { get; set; }
        public int ProductId { get; set; }
        public int BuyerId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int SaleDate { get; set; }

        public TransectionData(int Id, int SallerId, int ProductId, int BuyerId, int Price, int Quantity, int SaleDate)
        {
            this.Id = Id;
            this.SallerId = SallerId;
            this.ProductId = ProductId;
            this.BuyerId = BuyerId;
            this.Price = Price;
            this.Quantity = Quantity;
            this.SaleDate = SaleDate;
        }

        public TransectionData()
        {
        }
             


        }

       /* public TransectionData(int v1, int v2, int v3, int v4, int v5, int v6, int v7)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
        }*/
    }
public class GrossMerchandiseValue
{
    public int TotalGmv { get; set; }
    public GrossMerchandiseValue(int TotalGmv)
    { 
        this.TotalGmv = TotalGmv;
    }

}

