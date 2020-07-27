using LNTKCustomer.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTKCustomer
{
    public partial class WaitScreen : DevExpress.XtraEditors.XtraForm
    {
        public WaitScreen()
        {
            InitializeComponent();
        }

        private void imsWaitScreen_Click(object sender, EventArgs e)
        {
            PlaceSelection placeSelection = new PlaceSelection();
            placeSelection.WindowState= FormWindowState.Maximized;
            placeSelection.Show();

        }
    }
}
