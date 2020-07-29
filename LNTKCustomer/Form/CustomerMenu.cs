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
    public partial class CustomerMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProductThumbnail form = new ProductThumbnail();
        public List<ShoppedItem> shoppingList { get; set; }

        public CustomerMenu()
        {
            InitializeComponent();
            SetTestData();
        }

        private void SetTestData()
        {
            shoppingList = new List<ShoppedItem>();
            ShoppedItem test1 = new ShoppedItem("몬스터X 라지 세트", 26, 1);
            ShoppedItem test2 = new ShoppedItem("몬스터X 라지 세트", 20, 1);
            ShoppedItem test3 = new ShoppedItem("몬스터X 라지 세트", 21, 1);
            ShoppedItem test4 = new ShoppedItem("닭갈비버거", 27, 1);

            shoppingList.Add(test1);
            shoppingList.Add(test2);
            shoppingList.Add(test3);
            shoppingList.Add(test4);
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
            SetTestData();//실험용
            form.GetShoppedItemList(shoppingList);
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
         //   tileBarItem6.ItemSize.Equals()
         //   tileBar1.WideTileWidth = 160;

        }

        private void pceShoppingCart_Click(object sender, EventArgs e)
        {
            //ShoppingCart shoppingCart = new ShoppingCart(shoppingList);
            //shoppingCart.MdiParent = this;
            //shoppingCart.WindowState = FormWindowState.Maximized;
            //shoppingCart.Show();
            //pceShoppingCart.Visible = false;
            //pcnShoppingCart.Visible = false;



            //adcMenuCategory.Enabled = false;
            //adcLogo.Enabled = true;
        }

        private void tileBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
