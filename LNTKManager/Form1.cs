using LNTKKiosk.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTKManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uscButtonContainer_MenuSelected(object sender, ButtonContainer.MenuSelectedEventArgs e)
        {
            List<Product> list = DataRepository.Product.SearchByCategory(e.Label);

            Text = e.Label;
        }
    }
}
