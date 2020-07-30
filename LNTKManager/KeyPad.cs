using LNTKKiosk.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTKManager
{
    public partial class KeyPad : Form
    {
        int orderCount = 0;
        List<OrderDetail> orders = new List<OrderDetail>();

        public KeyPad()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Clear();

            DevExpress.XtraEditors.SimpleButton button = (DevExpress.XtraEditors.SimpleButton)sender;
            tbxResult.Text = tbxResult.Text + button.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbxResult.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            Order order = DataRepository.Order.Get(int.Parse(tbxResult.Text));

            if (order == null)
            {
                MessageBox.Show("없는 주문번호입니다.");
                tbxResult.Text = "";
                return;
            }

            if (order.IsCompleted != false)
            {
                tbxResult.Text = "";
                return;
            }


            orderCount++;
            if (orderCount > 5)
            {
                orders.RemoveRange(0, DataRepository.OrderDetail.GetCountByOrder(orders[0].OrderId));
                orderCount--;
            }

            List<OrderDetail> orderDetails = DataRepository.OrderDetail.GetByOrderWithProduct(order.OrderId);
            orders.AddRange(orderDetails);

            order.IsCompleted = true;

            DataRepository.Order.Update(order);

            bdsCompletedOrderDetail.DataSource = null;
            bdsCompletedOrderDetail.DataSource = orders;
            bdsNonCompletedOrderDetail.DataSource = DataRepository.OrderDetail.GetwithNonCompletedOrderDetail();
            //bdsCompletedOrderDetail.DataSource = DataRepository.OrderDetail.GetwithCompletedOrderDetail();

            tbxResult.Text = "";
        }

       
        private void KeyPad_Load(object sender, EventArgs e)
        {
            bdsNonCompletedOrderDetail.DataSource = DataRepository.OrderDetail.GetwithNonCompletedOrderDetail();
            //bdsCompletedOrderDetail.DataSource = DataRepository.OrderDetail.GetwithCompletedOrderDetail();

        }

        private void tbxResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnEnter_Click(sender, e);

            else if (e.KeyCode == Keys.Delete)
                this.btnDelete_Click(sender, e);

        }
    }
}
