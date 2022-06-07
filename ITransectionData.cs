using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication
{
    public interface ITransectionData
    {
        public TopSaller getTopSeller(List<TransectionData> list1, List<SallerData> list2);
        public TopBuyerProduct getTopBuyerProduct(List<TransectionData> list1, List<BuyerData> list2);
        public TopSellingProduct getTopSellingProduct (List<TransectionData> list1, List<ProductData>list2);
        public GrossMerchandiseValue getGrossMerchandiseValue(List<TransectionData> list);
       // public List<SellAndBuyByLocation> getSellAndBuyByLocations(List<TransectionData> list1, List<SallerData> list2, List<BuyerData> list3);
        public List<SellAndBuyByLocation> getSellAndBuyByLocationsNew(List<TransectionData> transData, List<SallerData> sellData, List<BuyerData> buyData);
    }
}