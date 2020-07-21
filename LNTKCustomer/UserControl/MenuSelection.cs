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
    public partial class MenuSelection : DevExpress.XtraEditors.XtraUserControl
    {
        public MenuSelection()
        {
            InitializeComponent();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("버거클릭");
        }
    }
}
