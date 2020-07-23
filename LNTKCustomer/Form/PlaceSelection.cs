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
using DevExpressKiller;

namespace LNTKCustomer.Form
{
    public partial class PlaceSelection : DevExpress.XtraEditors.XtraForm
    {
        public PlaceSelection()
        {

            InitializeComponent();
        }

        private void pceTakeOut_EditValueChanged(object sender, EventArgs e)
        {
            CustomerMenu form = new CustomerMenu();
            form.Show();
        }

        private void pceAtStore_EditValueChanged(object sender, EventArgs e)
        {
            CustomerMenu form = new CustomerMenu();
            form.Show();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}