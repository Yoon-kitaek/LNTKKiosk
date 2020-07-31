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
using DevExpress.XtraGrid.Views.Grid;

namespace LNTKCustomer.Form
{
    public partial class ShoppingCart : DevExpress.XtraEditors.XtraForm
    {
        int j = 0;
        List<ShoppedItem> shoppedItemList = new List<ShoppedItem>();
        private List<ShoppedPackage> shoppedPackageList = new List<ShoppedPackage>();

        public ShoppingCart(List<ShoppedItem> shoppedItems)
        {
            InitializeComponent();
            this.shoppedItemList = shoppedItems;
            productBindingSource.DataSource = this.shoppedItemList;

            foreach (string name in shoppedItemList.Select(x => x.packageName).Distinct())
            {
                ShoppedPackage shoppedPackage = new ShoppedPackage();
                shoppedPackage.packageName = name;
                shoppedPackage.productIds = shoppedItemList.Where(x => x.packageName.Equals(name)).Select(y => y.productId).Distinct().ToList();
                shoppedPackageList.Add(shoppedPackage);
            }
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            uscThumbnailContainer.SetShoppedItemList(shoppedPackageList);
            lbcPackageName.Text = shoppedPackageList[j].packageName;
            GridView gridView1 = grcShoppedItemList.MainView as GridView;
            gridView1.ExpandAllGroups();
        }

 

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Payment form = new Payment(shoppedItemList);

            form.WindowState = FormWindowState.Maximized;
            form.Show();
            Close();
        }

        private void grcShoppedItemList_Click(object sender, EventArgs e)
        {

        }

        private void sbtPay_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(shoppedItemList);
            payment.ShowDialog();
            Close();
        }

        private void sbtHome_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void uscThumbnailContainer_ArrowClicked(object sender, UserControl.ThumbnailContainer.ArrowClickedEventArgs e)
        {
            if (e.isRight == true)
            {
                if (j == shoppedPackageList.Count - 1)
                    j = 0;
                else
                    j++;

            }
            else
            {
                if (j == 0)
                    j = shoppedPackageList.Count - 1;
                else
                    j--;
            }
            lbcPackageName.Text = shoppedPackageList[j].packageName;
        }
    }
}