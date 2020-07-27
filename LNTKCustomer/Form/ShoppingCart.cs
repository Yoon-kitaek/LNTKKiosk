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
using DevExpress.XtraWaitForm;

namespace LNTKCustomer.Form
{
    public partial class ShoppingCart : DevExpress.XtraEditors.XtraForm
    {
        List<ShoppedItem> shoppingList = new List<ShoppedItem>();

        public ShoppingCart(List <ShoppedItem> shoppingList)
        {
            InitializeComponent();
            this.shoppingList = shoppingList;
            productBindingSource.DataSource = this.shoppingList;

        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
          //  uscShoppedItemThumbnail.SetShoppingList(shoppingList);
        }

 

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Payment form = new Payment();

            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}