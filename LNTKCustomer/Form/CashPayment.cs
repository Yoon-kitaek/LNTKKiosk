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
using System.Threading;

namespace LNTKCustomer.Form
{
    public partial class CashPayment : DevExpress.XtraEditors.XtraForm
    {
        int remainingPayment;
        public CashPayment( )
        {
            InitializeComponent();
            remainingPayment = 0;
            foreach (ShoppedItem shoppedItem in OrderInfo.Instance.shoppedItemList)
                remainingPayment += shoppedItem.price;
            foreach (Recipe recipe in OrderInfo.Instance.changedRecipe)
                remainingPayment += (recipe.Amount * DataRepository.Grocery.Get(recipe.GroceryId).Price);
            SetInstructionText(remainingPayment);
            while (remainingPayment > 0)
            {
                Thread.Sleep(1000);
                remainingPayment += -1000;
                SetInstructionText(remainingPayment);
            }

            if (remainingPayment < 0)
            {
                lbcInstruction.Text = $"거스름돈은 {remainingPayment}원입니다.";
            }

            EndPage endPage = new EndPage();
            endPage.Show();
            Close();
            
        }

        private void SetInstructionText(int price)
        {
            string head = "현금투입기에 ";
            string tail = "원을 넣어주세요.";
            lbcInstruction.Text = head + $"{remainingPayment}" + tail;
        }


    }
}