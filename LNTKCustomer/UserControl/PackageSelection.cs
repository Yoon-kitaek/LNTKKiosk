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
            int price = DataRepository.Product.GetByName(Name).EventPrice;
            lbcSingle.Text = price.ToString();
            lbcMiddleSetPrice.Text = (price + MiddleSizePrice).ToString();
            lbcLargeSetPrice.Text = (price + LargeSizePrice).ToString();

        
        }
    }
}
