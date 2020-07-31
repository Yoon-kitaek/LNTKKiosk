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
        List<ShoppedItem> shoppedItemList = new List<ShoppedItem>();
        public CardPayment(List<ShoppedItem> shoppedItemList)
        {
            InitializeComponent();
            this.shoppedItemList = shoppedItemList;

        }

        private void CardPayment_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);

            EndPage endPage = new EndPage(shoppedItemList);
            endPage.Show();
            Close();
        }
    }
}