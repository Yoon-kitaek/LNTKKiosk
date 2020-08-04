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
using LNTKKiosk.Data;

namespace LNTKCustomer.Form
{
    public partial class SingleOrSet : DevExpress.XtraEditors.XtraForm
    {
        public SingleOrSet(string packageName )
        {
            InitializeComponent();
            this.Text = packageName;
            uscPackageSelection.Name = packageName;
            uscPackageSelection.SetPrice();
        }


    }
}