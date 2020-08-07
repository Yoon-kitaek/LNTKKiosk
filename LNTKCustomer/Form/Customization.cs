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
using LNTKCustomer.UserControl;

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
            uscBurgerCustomization.productId = productId;

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
                    beverageId = ColaM;
                    SideId = FrenchFriesM;
                }
                else
                {
                    uscSideCustomization.SetPicture(FrenchFriesL);
                    uscBeverageCustomization.SetPicture(ColaL);
                    beverageId = ColaL;
                    SideId = FrenchFriesL;
                }

            }


        }

        private void AddtoCart()
        {
            Product product = DataRepository.Product.GetByName(productName);
            ShoppedItem shoppedItem = new ShoppedItem(productName + package, product.ProductId, 1);
            OrderInfo.Instance.shoppedItemList.Add(shoppedItem);

            if (package.Equals("") != true)
            {
                //if(Side)
                ShoppedItem beverage = new ShoppedItem(productName + package, beverageId, 1);
                ShoppedItem side = new ShoppedItem(productName + package, SideId, 1);
                OrderInfo.Instance.shoppedItemList.Add(beverage);
                OrderInfo.Instance.shoppedItemList.Add(side);
            }
        }



        private void btnPutInCart_Click(object sender, EventArgs e)
        {
            AddtoCart();
            Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            AddtoCart();
            Payment payment = new Payment();
            payment.Show();
            Close();
        }

        private void sbtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}