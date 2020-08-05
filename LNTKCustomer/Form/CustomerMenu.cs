using DevExpress.XtraEditors;
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

        List<TileItem> tileItems = new List<TileItem>();

        public CustomerMenu()
        {
            InitializeComponent();
            shoppingList = OrderInfo.Instance.shoppedItemList;
          //  SetTestData();
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
        private void CustomerMenu_Load(object sender, EventArgs e)
        {           
            SetTestData();//실험용
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            tileItems.Add(tbiBeverage);
            tileItems.Add(tbiBurger);
            tileItems.Add(tbiSide);
            tileItems.Add(tbiCart);
        }
        public void TileItemsClickable(bool clickable)
        {
            foreach (TileItem tileItem in tileItems)
                tileItem.Enabled = clickable;
        }
        private void tbiBurger_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            form.SetCategoryId(10);
        }

        private void tbiBeverage_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            form.SetCategoryId(11);
        }

        private void tbiSide_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            form.SetCategoryId(12);
        }

        private void tbiCart_ItemClick(object sender, TileItemEventArgs e)
        {
            if (OrderInfo.Instance.shoppedItemList != null)
            {
                if (Application.OpenForms.OfType<ShoppingCart>().Count() ==0)
                {
                    ShoppingCart shoppingCart = new ShoppingCart();
                    shoppingCart.MdiParent = this;
                    shoppingCart.WindowState = FormWindowState.Maximized;
                    //      shoppingCart.FormClosing += new System.Windows.Forms.FormClosedEventHandler(shoppingCart.)
                    //   TileItemsClickable(false);
                    shoppingCart.Show();
                }
            }
            else
            {
                MessageBox.Show("카트에 추가하신 상품이 없습니다.");
            }
        }


        private void ShoppingCartClosed(object sender, FormClosedEventArgs e)
        {
            
        
        }
    }
}
