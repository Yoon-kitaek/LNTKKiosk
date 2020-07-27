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
            CardPayment form = new CardPayment();
            form.ShowDialog();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            
        }
    }
}