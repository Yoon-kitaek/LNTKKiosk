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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void buttonContainer1_MenuSelected(object sender, ButtonContainer.MenuSelectedEventArgs e)
        {
            if(e.Label == "버거")
            {
                int buggerId = 10;

                bdsProduct.DataSource = DataRepository.Product.SearchByCategoryId(buggerId);

            }

            else if (e.Label == "음료")
            {
                int buggerId = 11;

                bdsProduct.DataSource = DataRepository.Product.SearchByCategoryId(buggerId);

            }

            else if (e.Label == "사이드")
            {
                int buggerId = 12;

                bdsProduct.DataSource = DataRepository.Product.SearchByCategoryId(buggerId);

            }
        }
    }
}
