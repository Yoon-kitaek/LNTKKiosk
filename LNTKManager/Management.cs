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

namespace LNTKManager
{
    public partial class Management : DevExpress.XtraEditors.XtraForm
    {
        public Management()
        {
            InitializeComponent();
            
        }

        private void buttonContainer1_MenuSelected(object sender, ButtonContainer.MenuSelectedEventArgs e)
        {
            
            
                if (e.Label == "버거")
                {
                    int buggerId = 10;

                    bdsProduct.DataSource = DataRepository.Product.SearchByCategoryId(buggerId);

                }

                else if (e.Label == "음료")
                {
                    int buggerId = 11;

                    bdsProduct.DataSource = DataRepository.Product.SearchByCategoryId(buggerId);

                }

                else if (e.Label == "사이드")
                {
                    int buggerId = 12;

                    bdsProduct.DataSource = DataRepository.Product.SearchByCategoryId(buggerId);

                }
            
            
        }

        private void tctlManagement_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            //if(tpgeOrder == e.Page)
            //{ 
            //    //기택이 소스코드

            //}
            //else if(tpgeProduct == e.Page)
            //{
            //    LeeMethod();
            //}
                

        }

        private void Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lotteNaldsTouchKingDataSet3.OrderDetail' table. You can move, or remove it, as needed.
            bdsCompletedOrder.DataSource = DataRepository.Order.GetwithCompleted();
            bdsNonCompletedOrder.DataSource = DataRepository.Order.GetwithNonCompleted();
            bdsStock.DataSource = DataRepository.Stock.GetAllWithProperties();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bdsCompletedOrder.DataSource = DataRepository.Order.GetwithCompleted();
            bdsNonCompletedOrder.DataSource = DataRepository.Order.GetwithNonCompleted();
        }

        private void tctlManagement_Click(object sender, EventArgs e)
        {
            
            bdsOrderDetail.DataSource = DataRepository.OrderDetail.GetAllWithProperties();
        }

        private void gridControl3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            RecipeManagement form = new RecipeManagement();
            form.ShowDialog();
        }

        private void btnGrocery_Click(object sender, EventArgs e)
        {
            GroceryManagement form = new GroceryManagement();
            form.ShowDialog();
        }

        private void btnStockInsert_Click(object sender, EventArgs e)
        {
            StockInsert form = new StockInsert();
            form.ShowDialog();
            
        }

        private void btnStockUpdate_Click(object sender, EventArgs e)
        {
            Stock stock = bdsStock.Current as Stock;
            if (stock == null)
                return;

            StockUpdate form = new StockUpdate(stock);
            form.ShowDialog();

        }

        private void btnStockDelete_Click(object sender, EventArgs e)
        {
            Stock stock = bdsStock.Current as Stock;
            if (stock == null)
                return;
            if (Helpers.Helper.SureToDelete() == false)
                return;

            DataRepository.Stock.Delete(stock);

            bdsStock.Remove(stock);
        }

        private void btnProductInsert_Click(object sender, EventArgs e)
        {
            ProductInsert form = new ProductInsert();
            form.ShowDialog();
       
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            ProductPartial dummy = bdsProduct.Current as ProductPartial;
            Product product = DataRepository.Product.Get(dummy.ProductId);
            if (product == null)
                return;
            
            ProductUpdate form = new ProductUpdate(product);
            form.ShowDialog();

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            Product product = bdsProduct.Current as Product;
            if (product == null)
                return;
            if (Helpers.Helper.SureToDelete() == false)
                return;

            DataRepository.Product.Delete(product);

            bdsProduct.Remove(product);

        }
    }
}
