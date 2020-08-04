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
using DevExpress.Utils.Extensions;
using DevExpress.XtraWaitForm;
using LNTKKiosk.Data;

namespace LNTKCustomer.Form
{
    public partial class Customization : DevExpress.XtraEditors.XtraForm
    {
        string productName;
        string package;
        public int beverageId { get; set; }
        public int SideId { get; set; }
        const int FrenchFriesM = 12;
        const int ColaM = 13;
        const int FrenchFriesL = 20;
        const int ColaL = 21;



        List<ShoppedItem> shoppingList = new List<ShoppedItem>();

        public Customization(string packageName, string package)
        {
            InitializeComponent();
            productName = packageName;
            this.package = package;

        }

        private void Customization_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            int productId = DataRepository.Product.GetByName(productName).ProductId;
            uscBurgerCustomization.SetPicture(productId);

            if (package.Equals("") == true)
            {
                layoutControl4.Visible = false;
            }
            else
            {
                layoutControl4.Visible = true;

                if (package.Contains("M") == true)
                {
                    uscSideCustomization.SetPicture(FrenchFriesM);
                    uscBeverageCustomization.SetPicture(ColaM);
                }
                else
                {
                    uscSideCustomization.SetPicture(FrenchFriesL);
                    uscBeverageCustomization.SetPicture(ColaL);
                }

            }


        }

        private void AddtoCart()
        {
            Product product = DataRepository.Product.GetByName(productName);
            ShoppedItem shoppedItem = new ShoppedItem(Name + package, product.ProductId, 1);
            shoppingList.Add(shoppedItem);

            beverageId = 13;//for test
            SideId = 12;//for test

            if (package.Equals("") != true)
            {
                ShoppedItem beverage = new ShoppedItem(Name + package, beverageId, 1);
                ShoppedItem side = new ShoppedItem(Name + package, SideId, 1);
                shoppingList.Add(beverage);
                shoppingList.Add(side);
            }
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OrderInfo.Instance.shoppedItemList = shoppingList;
            Payment form = new Payment();
            form.Show();
        }

        private void btnPutInCart_Click(object sender, EventArgs e)
        {
            AddtoCart();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

      
    }
}