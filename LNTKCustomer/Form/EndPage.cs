using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LNTKKiosk.Data;

namespace LNTKCustomer.Form
{
    public partial class EndPage : DevExpress.XtraEditors.XtraForm
    {
        private int orderId;
        List<ShoppedItem> shoppedItemList = new List<ShoppedItem>();

        public EndPage(List<ShoppedItem> shoppedItemList)
        {
            InitializeComponent();
            this.shoppedItemList = shoppedItemList;
        }
        private void EndPage_Load(object sender, EventArgs e)
        {
            orderId = DataRepository.Order.GetMaxId() + 1;

            Order order = new Order();

            order.OrderId = orderId;
            order.Date = DateTime.Now;
            order.IsCompleted = false;
            DataRepository.Order.Insert(order);
            foreach (ShoppedItem shoppedItem in shoppedItemList)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderId = orderId;
                orderDetail.ProductId = shoppedItem.productId;
                orderDetail.IsCompleted = false;
                orderDetail.OrderDetailId = DataRepository.OrderDetail.GetMaxId() + 1;
                    DataRepository.OrderDetail.Insert(orderDetail);
            }
            lbcOrderId.Text = orderId.ToString();
        }
    }
}