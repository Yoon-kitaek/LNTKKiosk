using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LNTKKiosk.Data;
using LNTKCustomer.Form;
using System.Runtime.CompilerServices;
using DevExpress.Utils.Extensions;

namespace LNTKCustomer.UserControl
{
    public partial class PackageSelection : DevExpress.XtraEditors.XtraUserControl
    {
        public string Name { get; set; }
        const int MiddleSizePrice = 1200;
        const int LargeSizePrice = 1600; 
        public PackageSelection()
        {
            InitializeComponent();
        }

        public void SetPrice()
        {
            Product product = DataRepository.Product.GetByName(Name);
            DataRepository.Product.SetEventPrice(product); //TODO : EventPrice 한번에
            int price = product.EventPrice;
            lbcSinglePrice.Text = price.ToString();
            lbcMiddleSetPrice.Text = (price + MiddleSizePrice).ToString();
            lbcLargeSetPrice.Text = (price + LargeSizePrice).ToString();
        }

        public void CloseForm()
        {
            SingleOrSet singleOrSet = (SingleOrSet)this.Parent.Parent;
            singleOrSet.Close();
        }


        #region MenuClicked event things for C# 3.0
        public event EventHandler<MenuClickedEventArgs> MenuClicked;

        protected virtual void OnMenuClicked(MenuClickedEventArgs e)
        {
            if (MenuClicked != null)
                MenuClicked(this, e);
        }

        private MenuClickedEventArgs OnMenuClicked(string name)
        {
            MenuClickedEventArgs args = new MenuClickedEventArgs(name);
            OnMenuClicked(args);

            return args;
        }

        private MenuClickedEventArgs OnMenuClickedForOut()
        {
            MenuClickedEventArgs args = new MenuClickedEventArgs();
            OnMenuClicked(args);

            return args;
        }

        public class MenuClickedEventArgs : EventArgs
        {
            public string Name { get; set; }

            public MenuClickedEventArgs()
            {
            }

            public MenuClickedEventArgs(string name)
            {
                Name = name;
            }
        }
        #endregion

        private void pceSingle_Click(object sender, EventArgs e)
        {
            OnMenuClicked(lbcSingle.Text);
            OpenCustomizationMenu(Name,"");
            CloseForm();
        }

        private void pceMiddleSet_Click(object sender, EventArgs e)
        {
            OnMenuClicked(lbcMiddleSet.Text);
            OpenCustomizationMenu(Name ,lbcMiddleSet.Text);
            CloseForm();
        }

        private void pceLargetSet_Click(object sender, EventArgs e)
        {
            OnMenuClicked(lbcLargeSet.Text);
            OpenCustomizationMenu(Name , lbcLargeSet.Text);
            CloseForm();
        }

        private void OpenCustomizationMenu(string productName, string package)
        {
            Customization customization = new Customization(productName, package);
            customization.Show();
        
        }
    }
}
