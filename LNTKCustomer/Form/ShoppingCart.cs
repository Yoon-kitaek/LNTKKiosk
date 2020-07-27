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
        List<ProductPackage> shoppingList = new List<ProductPackage>();
        List<Product> shoppedProduct = new List<Product>();

        public ShoppingCart(List <ProductPackage> shoppingList)
        {
            InitializeComponent();
            this.shoppingList = shoppingList;
            foreach (ProductPackage productPackage in shoppingList)
            {
                for (int i = 0; i < productPackage.Quantity; i++)
                    shoppedProduct.Add(DataRepository.Product.Get(productPackage.productIds[i]));
            }
            productBindingSource.DataSource = this.shoppingList;

        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
       //     shoppedProductImages1.SetShoppingList(shoppingList);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Payment form = new Payment();
           
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}