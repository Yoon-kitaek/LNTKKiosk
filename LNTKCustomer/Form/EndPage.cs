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
using System.Threading;

namespace LNTKCustomer.Form
{
    public partial class EndPage : DevExpress.XtraEditors.XtraForm
    {
        private int orderId;
        List<ShoppedItem> shoppedItemList = new List<ShoppedItem>();

        public EndPage()
        {
            InitializeComponent();
            shoppedItemList = OrderInfo.Instance.shoppedItemList;
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
           //     orderDetail.IsCompleted = false;
                orderDetail.OrderDetailId = DataRepository.OrderDetail.GetMaxId() + 1;
                DataRepository.OrderDetail.Insert(orderDetail);
            }
            lbcOrderId.Text = orderId.ToString();
            OrderInfo.Instance.Reset();
            wait(5000);
           
            Close();

        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}