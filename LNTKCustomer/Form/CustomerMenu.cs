using DevExpress.XtraWaitForm;
using LNTKCustomer.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTKCustomer.Form
{
    public partial class CustomerMenu : DevExpress.XtraEditors.XtraForm
    {
        ProductThumbnail form = new ProductThumbnail();

        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void btnRecommendedButton_Click(object sender, EventArgs e)
        {
            form.SetCategoryId(10);
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            form.SetCategoryId(10);
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            form.SetCategoryId(11);
        }

        private void btnMorningSale_Click(object sender, EventArgs e)
        {
            KingMorningMenu form = new KingMorningMenu();
            form.Show();
         
        }

        private void toolboxControl1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
