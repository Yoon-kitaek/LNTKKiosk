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
    public partial class Payment : DevExpress.XtraEditors.XtraForm
    {
        List<ShoppedItem> shoppedItemList = new List<ShoppedItem>();
        public Payment(List<ShoppedItem> shoppedItemList)
        {
            InitializeComponent();
            this.shoppedItemList = shoppedItemList;
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            OrderInfo.Instance.shoppedItemList = shoppedItemList;
           // CardPayment cardPayment = new CardPayment(shoppedItemList);
            cardPayment.Show();
            Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            CashPayment cashPayment = new CashPayment(shoppedItemList);
            cashPayment.Show();
            Close();
        }
    }
}