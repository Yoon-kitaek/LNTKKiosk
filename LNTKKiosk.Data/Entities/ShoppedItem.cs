using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class ShoppedItem
    {
        public ShoppedItem(string packageName, int productId, int qunatity)
        {
            Product product = DataRepository.Product.Get(productId);
            this.packageName = packageName;
            this.productId = productId;
            productName = product.Name;
            this.quantity = qunatity;
            DataRepository.Product.SetEventPrice(product);
            this.price = product.EventPrice;
            totalPrice = this.quantity * this.price;
        }
        public string packageName { get; set; }       
        public int productId { get; set; }
        public string productName { get; private set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int totalPrice { get; set; }


    }
}
