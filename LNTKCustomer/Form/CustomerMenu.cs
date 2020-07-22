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
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void btnRecommendedButton_Click(object sender, EventArgs e)
        {
            RecommendedMenu form = new RecommendedMenu();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {

            BurgerSetMenu form = new BurgerSetMenu();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            BeverageCoffeeMenu form = new BeverageCoffeeMenu();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnMorningSale_Click(object sender, EventArgs e)
        {
            KingMorningMenu form = new KingMorningMenu();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
