using DevExpress.XtraWaitForm;
using LNTKCustomer.UserControl;
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

namespace LNTKCustomer.Form
{
    public partial class CustomerMenu : DevExpress.XtraEditors.XtraForm
    {
        ProductThumbnail form = new ProductThumbnail();
        List<ProductPackage> shoppingList = new List<ProductPackage>();

        public CustomerMenu()
        {
            InitializeComponent();
            SetTestData();
        }

        private void SetTestData()
        {
            ProductPackage test1 = new ProductPackage();
            ProductPackage test2 = new ProductPackage();
            test1.PackageName = "몬스터X 라지 세트";
            List<int> ttt = new List<int>();
            ttt.Add(26);
            ttt.Add(20);
            ttt.Add(21);
            test1.productIds = ttt;
            shoppingList.Add(test1);
            test2.PackageName = "닭갈비버거";
            List<int> ttt2 = new List<int>();
            ttt2.Add(27);
            test2.productIds = ttt2;
            shoppingList.Add(test2);
        }

        private void btnRecommendedButton_Click(object sender, EventArgs e)
        {
            form.SetCategoryId(10);
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            form.SetCategoryId(10);
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            form.SetCategoryId(11);
        }

        private void btnMorningSale_Click(object sender, EventArgs e)
        {
           
         
        }


        private void CustomerMenu_Load(object sender, EventArgs e)
        {
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void pceShoppingCart_Click(object sender, EventArgs e)
        {
            ShoppingCart shoppingCart = new ShoppingCart(shoppingList);
            shoppingCart.MdiParent = this;
            shoppingCart.WindowState = FormWindowState.Maximized;
            shoppingCart.Show();
            pceShoppingCart.Visible = false;
            pcnShoppingCart.Visible = false;
            adcMenuCategory.Enabled = false;
            adcLogo.Enabled = true;
        }

    }
}
