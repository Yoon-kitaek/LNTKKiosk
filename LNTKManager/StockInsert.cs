using DevExpress.XtraPrinting.Native;
using LNTKKiosk.Data;
using LNTKManager.Helpers;
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
    public partial class StockInsert : Form
    {
        public StockInsert()
        {
            InitializeComponent();
        }

        private Stock _stock;

        private void WriteToEntity()
        {
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

        }

        private void StockInsert_Load(object sender, EventArgs e)
        {
            bdsGrocery.DataSource = DataRepository.Grocery.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txeReceivedDate.Text == "")
            {
                MessageBox.Show("입고날짜를 입력해주세요 \n ex) 20200720");
                return;
            }
            
            if(txeExpirationDate.Text == "")
            {
                MessageBox.Show("유효기간을 입력해주세요 \n ex) 30");
                return;
            }

            if (txePrice.Text == "")
            {
                MessageBox.Show("가격을 입력해주세요");
                return;
            }

            _stock = new Stock();
            WriteToEntity();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txeReceivedDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txeReceivedDate);
        }

        private void txeExpirationDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txeExpirationDate);
        }

        private void txePrice_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txePrice);
        }

        private void txeReceivedDate_Leave(object sender, EventArgs e)
        {
            Helpers.InputConstraint.DateConstraint(txeReceivedDate);
        }
    }
}
