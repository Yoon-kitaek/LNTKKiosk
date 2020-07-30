using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class OrderDetailData : EntityData<OrderDetail>
    {

        public OrderDetail Get(int orderId, int productId)
        {
            LNTKEntities context = CreateContext();

            return context.OrderDetails.FirstOrDefault(a => a.OrderId == orderId && a.ProductId == productId);
        }

        public void Delete(int orderId, int productId)
        {
            OrderDetail orderDetail = Get(orderId, productId);

            if (orderDetail == null)
                return;

            Delete(orderDetail);
        }

        public List<OrderDetail> GetByOrder(int orderId)
        {
            List<OrderDetail> orderDetails = DataRepository.OrderDetail.GetAll();

            orderDetails.RemoveAll(x => x.OrderId != orderId);

            return orderDetails;
        }

        public List<OrderDetail> GetAllWithProperties()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.OrderDetails
                        select new { OrderDetail = x, 
                            Product = x.Product, 
                            OrderDate = x.Order.Date, 
                            ProductName = x.Product.Name, 
                            CategoryName = x.Product.CodeCategory.Item };

            var items = query.ToList();

            foreach (var item in items)
            {
                item.OrderDetail.ProductPrice = item.Product.Price *(100- DataRepository.Product.GetDiscountRate(item.Product, item.OrderDate))/100;
                item.OrderDetail.OrderTime = item.OrderDate;
                item.OrderDetail.ProductName = item.ProductName;
                item.OrderDetail.CategoryName = item.CategoryName;
            }

            return items.ConvertAll(x => x.OrderDetail);
        }

        public int GetCountByOrder(int orderId)
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.OrderDetails
                        where x.OrderId == orderId
                        select x;

            return query.Count();
        }

        public List<OrderDetail> GetByOrderWithProduct(int orderId)
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.OrderDetails
                        where x.OrderId == orderId
                        select new
                        {
                            OrderDetail = x,
                            ProductName = x.Product.Name
                        };

            var items = query.ToList();

            foreach (var item in items)
            {
                item.OrderDetail.ProductName = item.ProductName;
            }

            return items.ConvertAll(x => x.OrderDetail);
        }

        public int GetMaxId()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.OrderDetails
                        orderby x.OrderDetailId descending
                        select x.OrderDetailId;

            return query.FirstOrDefault();
        }

        public object GetwithNonCompletedOrderDetail()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.OrderDetails
                        where x.Order.IsCompleted == false
                        select new { OrderDetail = x,  OrderId = x.OrderId, ProductName = x.Product.Name };

            var items = query.ToList();

            foreach (var item in items)
            {
                item.OrderDetail.OrderId = item.OrderId;
                item.OrderDetail.ProductName = item.ProductName;
                
            }

            return query.ToList();
        }
        public object GetwithCompletedOrderDetail()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.OrderDetails
                        where x.Order.IsCompleted == true
                        select new { OrderDetail = x, OrderId = x.OrderId, ProductName = x.Product.Name };

            var items = query.ToList();

            foreach (var item in items)
            {
                item.OrderDetail.OrderId = item.OrderId;
                item.OrderDetail.ProductName = item.ProductName;      
            }
            
            

            return items.ConvertAll(x=> x.OrderDetail).OrderByDescending(x=> x.OrderId).Take(5);
        }

    }
}
