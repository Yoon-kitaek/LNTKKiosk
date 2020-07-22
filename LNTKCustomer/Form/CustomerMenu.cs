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



        private void CustomerMenu_Load(object sender, EventArgs e)
        {
            RecommendedMenu form = new RecommendedMenu();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }



        private void btnRecommended_Click(object sender, EventArgs e)
        {


            RecommendedMenu form = new RecommendedMenu();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnBurgerSet_Click(object sender, EventArgs e)
        {

            foreach (WaitForm frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(BurgerSetMenu))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }


            BurgerSetMenu form = new BurgerSetMenu();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnBeverageCoffee_Click(object sender, EventArgs e)
        {




            BeverageCoffeeMenu form = new BeverageCoffeeMenu();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnKingMorning_Click(object sender, EventArgs e)
        {



            KingMorningMenu form = new KingMorningMenu();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnDiscountLunch_Click(object sender, EventArgs e)
        {



            LunchDiscountMenu form = new LunchDiscountMenu();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

       
    }
}
