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

namespace LNTKCustomer.UserControl
{
    public partial class PackageSelection : DevExpress.XtraEditors.XtraUserControl
    {
        public string Name { get; set; }
        public PackageSelection()
        {
            InitializeComponent();
        }

    }
}
