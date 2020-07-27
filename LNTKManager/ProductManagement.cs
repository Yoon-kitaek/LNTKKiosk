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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

            ProductInsert product = new ProductInsert(bdsProduct.Current as Product);
            product.ShowDialog();
            
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            bdsProduct.DataSource = DataRepository.Product.GetAll();
        }
    }
}
