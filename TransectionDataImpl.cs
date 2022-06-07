using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication
{
    public class TransectionDataImpl : ITransectionData
    {
        //First Problem :Find top selling product
        public TopSellingProduct getTopSellingProduct(List<TransectionData> list1, List<ProductData> list2)
        {
            Dictionary<int, TopSellingProduct> dic = new Dictionary<int, TopSellingProduct>();
            foreach (TransectionData item in list1)
            {
                if (dic.ContainsKey(item.ProductId))
                {
                    dic[item.ProductId].Count++;
                }
                else
                {
                    dic.Add(item.ProductId, new TopSellingProduct());
                    dic[item.ProductId].ProductId = item.ProductId;
                    dic[item.ProductId].Count = 1;
                }
            }
            TopSellingProduct topSellingProduct = new TopSellingProduct();
            topSellingProduct.Count = int.MinValue;
            foreach (TopSellingProduct topSelling in dic.Values)
            {
                if (topSelling.Count > topSellingProduct.Count)
                {
                    topSellingProduct.Count = topSelling.Count;
                    topSellingProduct.ProductId = topSelling.ProductId;
                }
            }
            List<ProductData> list = new List<ProductData>();
            foreach (ProductData data in list2)
            {
                if (data.ProductID == topSellingProduct.ProductId)
                {
                    topSellingProduct.ProductName = data.ProductName;
                }
            }
            return topSellingProduct;

        }

        //Second Problem : Find Top buyer
        public TopBuyerProduct getTopBuyerProduct(List<TransectionData> list1, List<BuyerData> list2)
        {
            Dictionary<int, TopBuyerProduct> dic = new Dictionary<int, TopBuyerProduct>();
            foreach (TransectionData data in list1)
            {
                if (dic.ContainsKey(data.BuyerId))
                {
                    dic[data.BuyerId].Count++;
                }
                else
                {
                    dic.Add(data.BuyerId, new TopBuyerProduct());
                    dic[data.BuyerId].BuyerId = data.BuyerId;
                    dic[data.BuyerId].Count = 1;
                }
            }
            TopBuyerProduct topbuyerProduct = new TopBuyerProduct();
            topbuyerProduct.Count = int.MinValue;
            foreach (TopBuyerProduct topBuyer in dic.Values)
            {
                if (topBuyer.Count > topbuyerProduct.Count)
                {
                    topbuyerProduct.Count = topBuyer.Count;
                    topbuyerProduct.BuyerId = topBuyer.BuyerId;
                }
            }
            List<BuyerData> list = new List<BuyerData>();
            foreach (BuyerData data in list2)
            {
                if (data.BuyerId == topbuyerProduct.BuyerId)
                {
                    topbuyerProduct.BuyerName = data.BuyerName;
                }
            }
            return topbuyerProduct;
        }
        //Third Problem : Find Top Seller
        public TopSaller getTopSeller(List<TransectionData> list1, List<SallerData> list2)
        {
            Dictionary<int, TopSaller> dic = new Dictionary<int, TopSaller>();
            foreach (TransectionData data in list1)
            {
                if (dic.ContainsKey(data.SallerId))
                {
                    dic[data.SallerId].Count++;
                }
                else
                {
                    dic.Add(data.SallerId, new TopSaller());
                    dic[data.SallerId].SallerId = data.SallerId;
                    dic[data.SallerId].Count = 1;
                }
            }
            TopSaller topSaller = new TopSaller();
            topSaller.Count = int.MinValue;
            foreach (TopSaller saller in dic.Values)
            {
                if (saller.Count > topSaller.Count)
                {
                    topSaller.Count = saller.Count;
                    topSaller.SallerId = saller.SallerId;
                }
            }
            List<SallerData> list = new List<SallerData>();
            foreach (SallerData data in list2)
            {
                if (data.SallerId == topSaller.SallerId)
                {
                    topSaller.SallerName = data.SallerName;
                }
            }
            return topSaller;
        }
        //Fourth Problem : Calculate GMV
        public GrossMerchandiseValue getGrossMerchandiseValue(List<TransectionData> list)
        {
            int Total = 0;
            foreach (TransectionData transectionData in list)
            {
                Total += transectionData.Price * transectionData.Quantity;
            }

            return new GrossMerchandiseValue(Total);
        }

        //Fifth Problem : find top selling and buying by location
         public List<SellAndBuyByLocation> getSellAndBuyByLocations(List<TransectionData> list1, List<SallerData> list2, List<BuyerData> list3)
        {
            Dictionary<string, SellDataByLocation> dic = new Dictionary<string, SellDataByLocation>();
            List<SellDataByLocation> result1 = new List<SellDataByLocation>();
            foreach (SallerData sallerData in list2)
            {
                if (dic.ContainsKey(sallerData.Location))
                {
                    dic[sallerData.Location].SellingLocation = sallerData.Location;
                }
                else
                {
                    dic.Add(sallerData.Location, new SellDataByLocation());
                    dic[sallerData.Location].SellingLocation = sallerData.Location;
                }
                foreach (TransectionData transectionData in list1)
                {
                    if (transectionData.SallerId == sallerData.SallerId)
                    {
                        dic[sallerData.Location].SellingQuantity += transectionData.Quantity;
                    }
                }
            }
            foreach (SellDataByLocation sellDataByLocation in dic.Values)
            {
                result1.Add(sellDataByLocation);
            }

            Dictionary<string, BuyerDataLocation> dic2 = new Dictionary<string, BuyerDataLocation>();
            List<BuyerDataLocation> result2 = new List<BuyerDataLocation>();
            foreach (BuyerData buyerData in list3)
            {
                if (dic2.ContainsKey(buyerData.Location))
                {
                    // dic2.Add(buyerData.Location, new BuyerDataLocation());
                    dic2[buyerData.Location].BuyerLocation = buyerData.Location;
                }
                else
                {
                    dic2.Add(buyerData.Location, new BuyerDataLocation());
                    dic2[buyerData.Location].BuyerLocation = buyerData.Location;
                }
                    List<TransectionData> list = new List<TransectionData>();
                
                    foreach (TransectionData transectionData in list1)
                    {
                        if (transectionData.BuyerId == buyerData.BuyerId)
                        {
                            dic2[buyerData.Location].BuyerQuantity += transectionData.Quantity;
                        }
                    }
             }
            foreach (BuyerDataLocation buyerDataLocation in dic2.Values)
            {
                result2.Add(buyerDataLocation);
            }
            Dictionary<string, SellAndBuyByLocation> dic3 = new Dictionary<string, SellAndBuyByLocation>();
            List<SellAndBuyByLocation> result = new List<SellAndBuyByLocation>();
            foreach (SellDataByLocation data in result1)
            {
                dic3.Add(data.SellingLocation, new SellAndBuyByLocation());
                dic3[data.SellingLocation].Location = data.SellingLocation;
                dic3[data.SellingLocation].SellingProduct = data.SellingQuantity;
                dic3[data.SellingLocation].BuyingProduct = 0;
            }
            foreach (BuyerDataLocation data1 in result2)
            {
                if (dic3.ContainsKey(data1.BuyerLocation))
                {
                    dic3[data1.BuyerLocation].BuyingProduct = data1.BuyerQuantity;
                }
                else
                {
                    dic3.Add(data1.BuyerLocation, new SellAndBuyByLocation());
                    dic3[data1.BuyerLocation].Location = data1.BuyerLocation;
                    dic3[data1.BuyerLocation].SellingProduct = 0;
                    dic3[data1.BuyerLocation].BuyingProduct = data1.BuyerQuantity;
                }
            }
            return dic3.Values.ToList();
        }

        private void buildSellerandBuyerQualityDictionary(List<TransectionData> transData, Dictionary<int, int> transBySellerIdDic, Dictionary<int, int> transByBuyerIdDic)
        {
            foreach (TransectionData transectionData in transData)
            {
                if (transBySellerIdDic.ContainsKey(transectionData.SallerId))
                {
                    transBySellerIdDic[transectionData.SallerId] += transectionData.Quantity;
                }
                else
                {
                    transBySellerIdDic.Add(transectionData.SallerId, transectionData.Quantity);
                }

                if (transByBuyerIdDic.ContainsKey(transectionData.BuyerId))
                {
                    transByBuyerIdDic[transectionData.BuyerId] += transectionData.Quantity;
                }
                else
                {
                    transByBuyerIdDic.Add(transectionData.BuyerId, transectionData.Quantity);
                }

            }
        }


        private void buildSellerLocationQuantity(List<SallerData> sellData, Dictionary<int, int> transBySellerIdDic, Dictionary<string, SellAndBuyByLocation> sellBuyeDataLocationDic)
            {
                foreach (SallerData sallerData in sellData)
                {
                    if (sellBuyeDataLocationDic.ContainsKey(sallerData.Location))
                    {
                    sellBuyeDataLocationDic[sallerData.Location].SellingProduct = transBySellerIdDic[sallerData.SallerId];
                    }
                    else
                    {
                        sellBuyeDataLocationDic.Add(sallerData.Location, new SellAndBuyByLocation());
                        sellBuyeDataLocationDic[sallerData.Location].SellingProduct = transBySellerIdDic[sallerData.SallerId];
                    }

                }
            }


        private void buildBuyerLocationQuantity(List<BuyerData> buyData, Dictionary<int, int> transByBuyerIdDic, Dictionary<string, SellAndBuyByLocation> sellBuyeDataLocationDic)
        {
            foreach (BuyerData buyerData in buyData)
            {
                if (sellBuyeDataLocationDic.ContainsKey(buyerData.Location))
                {
                    sellBuyeDataLocationDic[buyerData.Location].SellingProduct = transByBuyerIdDic[buyerData.BuyerId];
                }
                else
                {
                    sellBuyeDataLocationDic.Add(buyerData.Location, new SellAndBuyByLocation());
                    sellBuyeDataLocationDic[buyerData.Location].SellingProduct = transByBuyerIdDic[buyerData.BuyerId];
                }

            }

        }

        public List<SellAndBuyByLocation> getSellAndBuyByLocationsNew(List<TransectionData> transData, List<SallerData> sellData, List<BuyerData> buyData)
        {
            Dictionary<string, SellAndBuyByLocation> sellBuyeDataLocationDic = new Dictionary<string, SellAndBuyByLocation>();
            List<SellDataByLocation> result1 = new List<SellDataByLocation>();

            Dictionary<int, int> transBySellerIdDic = new Dictionary<int, int>();
            Dictionary<int, int> transByBuyerIdDic = new Dictionary<int, int>();

            //getting Transcation quatity by sellerId and BuyerId
            buildSellerandBuyerQualityDictionary(transData, transBySellerIdDic, transByBuyerIdDic);

            //Find location from sellerData and fetch quatity from seller transcation dictionary 
            buildSellerLocationQuantity(sellData, transBySellerIdDic, sellBuyeDataLocationDic);


            //Find location from BuyerData and fetch quatity from Buyer transcation dictionary 
            buildBuyerLocationQuantity(buyData, transByBuyerIdDic, sellBuyeDataLocationDic);

          //Return list from sell and buyer dictionary
            return sellBuyeDataLocationDic.Values.ToList();
        }
    }
}

/*  List<SellAndBuyByLocation> result = new List<SellAndBuyByLocation>();


     List<SallerData> result1 = new List<SallerData>();
   foreach (SallerData sallerdata in list2)
   {
   foreach (TransectionData transectionData in list1)
   {
       if (dic.ContainsKey(sallerdata.Location))
       {
           dic[sallerdata.Location].Location = sallerdata.Location;
           dic[sallerdata.Location].SellingProduct += transectionData.Quantity;
       }
       else
       {
           dic.Add(sallerdata.Location, new SellAndBuyByLocation());
           dic[sallerdata.Location].Location = sallerdata.Location;
           dic[sallerdata.Location].SallerId = sallerdata.SallerId;
           //dic[sallerdata.Location].SallerId = transectionData.SallerId;
           dic[sallerdata.Location].SellingProduct = transectionData.Quantity;

       }
   }
         result1.Add(sallerdata);
         //Console.WriteLine(result1);
     }
     List<BuyerData> result2 = new List<BuyerData>();
     foreach (BuyerData buyerData in list3)
     {
         if (dic.ContainsKey(buyerData.Location))
         {
             dic[buyerData.Location].BuyingProduct += transectionData.Quantity;
         }
         else
         {
             dic.Add(buyerData.Location, new SellAndBuyByLocation());
             dic[buyerData.Location].Location = buyerData.Location;
             dic[buyerData.Location].BuyerId = transectionData.BuyerId;
           dic[buyerData.Location].BuyerId = transectionData.BuyerId;
             dic[buyerData.Location].SellingProduct = transectionData.Quantity;
         }
         result2.Add(buyerData);
     }
   //  List<SellAndBuyByLocation> result = new List<SellAndBuyByLocation>();

     foreach (SallerData sallerData in result1)
     {
         foreach (BuyerData buyerData in result2)
         {

             if (sallerData.Location == buyerData.Location)
             {
                 SellAndBuyByLocation sellAndBuyByLocation = new SellAndBuyByLocation();
                 sellAndBuyByLocation.Location = buyerData.Location;
                 sellAndBuyByLocation.SellingProduct = sallerData.SellingProduct;
                 sellAndBuyByLocation.BuyingProduct = buyerData.BuyingProduct;
                 result.Add(sellAndBuyByLocation);
             }
         }

     }

 }
 return result;*/



