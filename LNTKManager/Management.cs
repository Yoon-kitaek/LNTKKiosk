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
    public partial class Management : Form
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void tctlManagement_Click(object sender, EventArgs e)
        {
            bdsOrderDetail.DataSource = DataRepository.OrderDetail.GetAllWithProperties();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductInsert product = new ProductInsert(bdsProduct.Current as Product);
            product.ShowDialog();
        }

        private void gridControl3_Click(object sender, EventArgs e)
        {
            ProductInsert product = new ProductInsert(bdsProduct.Current as Product);
            product.ShowDialog();
        }
    }
}
