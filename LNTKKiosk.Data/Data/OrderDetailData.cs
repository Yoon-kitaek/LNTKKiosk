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
    }
}
