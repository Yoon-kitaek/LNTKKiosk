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

namespace LNTKCustomer.Form
{
    public partial class Customization : DevExpress.XtraEditors.XtraForm
    {
        public Customization()
        {
            InitializeComponent();
        }

        private void Customization_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

        }

        private void sbtBeverageCustomization_Click(object sender, EventArgs e)
        {
            //장바구니넣기
          //  ShoppingCart shoppingCart = new ShoppingCart();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Payment form = new Payment();
            form.Show();
        }
    }
}