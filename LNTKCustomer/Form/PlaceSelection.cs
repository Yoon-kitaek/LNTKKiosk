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

        private void pceEatAtRestaurant_Click(object sender, EventArgs e)
        {
            CustomerMenu form = new CustomerMenu();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            Close();
        }

        private void pceTakeOut_Click(object sender, EventArgs e)
        {
            CustomerMenu form = new CustomerMenu();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            Close();
        }
    }
}