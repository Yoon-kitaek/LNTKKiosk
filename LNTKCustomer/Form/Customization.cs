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

        }

        private void sbtBeverageCustomization_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{bvsBeverage.Location.ToString()}");
            bvsBeverage.Location.WithVertOffset(500);
            bvsBeverage.Location.WithY( 700);
        }
    }
}