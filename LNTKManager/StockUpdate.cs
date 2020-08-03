using DevExpress.XtraGauges.Core.Styles;
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
    public partial class StockUpdate : Form
    {
        public StockUpdate()
        {
            InitializeComponent();
        }
        public StockUpdate(Stock stock) : this()
        {
            txeStockId.Text = stock.StockId.ToString();
            cbbGroceryId.SelectedItem = stock.GroceryId;
            txeReceivedDate.Text = stock.ReceivedDate.ToString();
            txeExpirationDate.Text = stock.ExpirationDate.ToString();
            txePrice.Text = stock.Price.ToString();
            txeExhustedDate.Text = stock.ExhaustedDate.ToString();
        }

        private Stock _stock = new Stock();

        private void StockUpdate_Load(object sender, EventArgs e)
        {
            bdsGrocery.DataSource = DataRepository.Grocery.GetAll();
        }

        private void WriteToEntity()
        {
            _stock.StockId = Convert.ToInt32(txeStockId.Text);
            _stock.GroceryId = (int)cbbGroceryId.SelectedValue;

            try
            {
                _stock.ReceivedDate = DateTime.ParseExact(txeReceivedDate.Text, "yyyyMMdd", null);
            }
            catch (Exception)
            {
                Helpers.InputConstraint.DateConstraint(txeReceivedDate);
            }

            try
            {
                _stock.ExpirationDate = int.Parse(txeExpirationDate.Text);
            }
            catch (Exception)
            {
                Helpers.InputConstraint.OnlyIntConstraint(txeExpirationDate);
            }

            try
            {
                _stock.Price = int.Parse(txePrice.Text);
            }
            catch (Exception)
            {

                Helpers.InputConstraint.OnlyIntConstraint(txePrice);
            }


            if(txeExhustedDate.Text != null)
            {
                try
                {
                    _stock.ExhaustedDate = DateTime.ParseExact(txeExhustedDate.Text, "yyyyMMdd", null);
                }
                catch (Exception)
                {
                    Helpers.InputConstraint.DateConstraint(txeExhustedDate);
                }
            }
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txeReceivedDate.Text == "")
            {
                MessageBox.Show("입고날짜를 입력해주세요 \n ex) 20200720");
                return;
            }

            if (txeExpirationDate.Text == "")
            {
                MessageBox.Show("유효기간을 입력해주세요 \n ex) 30");
                return;
            }

            if (txePrice.Text == "")
            {
                MessageBox.Show("가격을 입력해주세요");
                return;
            }


            WriteToEntity();

            try
            {
                DataRepository.Stock.Update(_stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("수정되었습니다.");
            Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
