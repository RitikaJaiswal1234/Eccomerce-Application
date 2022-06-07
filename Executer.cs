using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication
{
    public class Executer
    {
        public static void Main(String[] args)
        {
            List<TransectionData> transectionDetails = new List<TransectionData>();
            transectionDetails.Add(new TransectionData(101, 901, 701, 501, 120, 2, 2022 - 04 - 05));
            transectionDetails.Add(new TransectionData(102, 902, 702, 502, 230, 1, 2022 - 04 - 06));
            transectionDetails.Add(new TransectionData(103, 901, 703, 503, 240, 2, 2022 - 04 - 06));
            transectionDetails.Add(new TransectionData(104, 903, 702, 503, 110, 4, 2022 - 04 - 05));
            transectionDetails.Add(new TransectionData(105, 901, 702, 501, 150, 3, 2022 - 04 - 05));
            transectionDetails.Add(new TransectionData(106, 904, 701, 503, 220, 3, 2022 - 04 - 06));
            transectionDetails.Add(new TransectionData(107, 905, 704, 504, 225, 2, 2022 - 04 - 06));
            transectionDetails.Add(new TransectionData(108, 906, 705, 505, 250, 4, 2022 - 04 - 06));

            List<SallerData> sallerDetails = new List<SallerData>();
            sallerDetails.Add(new SallerData(901, "Sajal", "Pune"));
            sallerDetails.Add(new SallerData(902, "Vivek", "Banglore"));
            sallerDetails.Add(new SallerData(903, "Ravi", "Delhi"));
            sallerDetails.Add(new SallerData(904, "Ayush", "Indore"));
            sallerDetails.Add(new SallerData(905, "Uttu", "Bhopal"));
            sallerDetails.Add(new SallerData(906, "vinod", "Vizag"));
            sallerDetails.Add(new SallerData(907, "rohit", "Chennai"));
            sallerDetails.Add(new SallerData(908, "NishChal", "Pune"));

            List<BuyerData> buyerDetails = new List<BuyerData>();
            buyerDetails.Add(new BuyerData(501, "Ritika", "Indore"));
            buyerDetails.Add(new BuyerData(502, "Shradha", "Bhopal"));
            buyerDetails.Add(new BuyerData(503, "shreya", "Jaipur"));
            buyerDetails.Add(new BuyerData(504, "Varsha", "Pune"));
            buyerDetails.Add(new BuyerData(505, "Aaliya", "Chennai"));
            buyerDetails.Add(new BuyerData(506, "Bhawna", "Mumbai"));
            buyerDetails.Add(new BuyerData(507, "Vaishnavi", "Delhi"));
            buyerDetails.Add(new BuyerData(508, "sonal", "Banglore"));

            List<ProductData> productDetails = new List<ProductData>();
            productDetails.Add(new ProductData(701, "IPhone"));
            productDetails.Add(new ProductData(702, "Samsung Note"));
            productDetails.Add(new ProductData(703, "OnePlus tv"));
            productDetails.Add(new ProductData(704, "Sony HeadPhone"));
            productDetails.Add(new ProductData(705, "Asus LapTop"));
            productDetails.Add(new ProductData(706, "Benq monitor"));
            productDetails.Add(new ProductData(707, "HP Tablet"));
            productDetails.Add(new ProductData(708, "Bose SounDbar"));

            TransectionDataImpl transectionDataImpl = new TransectionDataImpl();
            TopSellingProduct result1 = transectionDataImpl.getTopSellingProduct(transectionDetails,productDetails);
            Console.WriteLine("top selling Product is : " + result1.ProductName);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

            TopBuyerProduct result2 = transectionDataImpl.getTopBuyerProduct(transectionDetails,buyerDetails);
            Console.WriteLine(" top buyer product : " + result2.BuyerName);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

            TopSaller result3 = transectionDataImpl.getTopSeller(transectionDetails, sallerDetails);
            Console.WriteLine("Top Seller Name of product : " + result3.SallerName);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

            GrossMerchandiseValue result4 =transectionDataImpl.getGrossMerchandiseValue(transectionDetails);
            Console.WriteLine("Total Gross Merchandise Value : " + result4.TotalGmv);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

            List<SellAndBuyByLocation> result5 = transectionDataImpl.getSellAndBuyByLocations(transectionDetails, sallerDetails, buyerDetails);
            foreach (SellAndBuyByLocation sellAndBuyByLocation in result5)
            {
                Console.WriteLine($"{sellAndBuyByLocation.Location}, { sellAndBuyByLocation.SellingProduct}, { sellAndBuyByLocation.BuyingProduct}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

            List<SellAndBuyByLocation> result6 = transectionDataImpl.getSellAndBuyByLocationsNew(transectionDetails, sallerDetails, buyerDetails);
            foreach (SellAndBuyByLocation sellAndBuyByLocation in result6)
            {
                Console.WriteLine($"{sellAndBuyByLocation.Location}, { sellAndBuyByLocation.SellingProduct}, { sellAndBuyByLocation.BuyingProduct}");
            }
        }
    }
}
