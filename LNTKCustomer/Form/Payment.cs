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

namespace LNTKCustomer.Form
{
    public partial class Payment : DevExpress.XtraEditors.XtraForm
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            Close();
            CardPayment cardPayment = new CardPayment();
            cardPayment.ShowDialog();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            Close();
            CashPayment cashPayment = new CashPayment();
            cashPayment.ShowDialog();
           
        }
    }
}