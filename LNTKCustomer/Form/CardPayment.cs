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
using System.Threading;
using LNTKKiosk.Data;

namespace LNTKCustomer.Form
{
    public partial class CardPayment : DevExpress.XtraEditors.XtraForm
    {
        public CardPayment()
        {
            InitializeComponent();
        }

        private void CardPayment_Load(object sender, EventArgs e)
        {
            int remainingPayment = 0;
            foreach (ShoppedItem shoppedItem in OrderInfo.Instance.shoppedItemList)
                remainingPayment += shoppedItem.price;
            foreach (ShoppedItem shoppedItem in OrderInfo.Instance.shoppedItemList)
            {
                if (shoppedItem.packageName.Contains("세트") == true)
                    remainingPayment += -300;
            }

            lbcInstruction.Text = $"카드를 넣어 {remainingPayment}원을 결제해주세요.";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            EndPage endPage = new EndPage();      
             
            Close();  
            endPage.Show();
        }
    }
}