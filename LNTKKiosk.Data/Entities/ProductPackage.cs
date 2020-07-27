using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class ProductPackage
    {
        public List <int> productIds { get; set; }
        public string PackageName { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public void GetTotalPrice()
        {
            TotalPrice = 0;
            foreach (int productId in productIds)
                TotalPrice += DataRepository.Product.Get(productId).EventPrice;



        }
    }
}
