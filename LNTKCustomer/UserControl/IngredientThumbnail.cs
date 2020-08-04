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
    public partial class IngredientThumbnail : DevExpress.XtraEditors.XtraUserControl
    {
        bool isChecked;
        int quantity;
        Product product = new Product();
        private int productId;

        public IngredientThumbnail()
        {
            InitializeComponent();
        }

        public IngredientThumbnail(int productId)
        {
            this.productId = productId;
        }

        public void SetValues(int productId, int groceryId)
        {
            product = DataRepository.Product.Get(productId);
            List<Recipe> recipes = DataRepository.Recipe.GetByProduct(productId);
            uscThumbnail.SetValues(product.Name);
            Recipe recipe = recipes.FirstOrDefault(x => x.GroceryId == groceryId);
            if (recipe != null)
            {
                isChecked = true;
                quantity = recipe.Amount;
            }

            else
            {
                isChecked = false;
                quantity = 0;
            }
            SetCheckBoxImage();
            lbcQuantity.Text = quantity.ToString();
        }

        private void pceCheckBox_Click(object sender, EventArgs e)
        {
            isChecked = !(isChecked);
        }

        private void SetCheckBoxImage()
        {
            if (isChecked == true)
                pceCheckBox.Image = Properties.Resources.Check;
            else
                pceCheckBox.Image = Properties.Resources.Uncheck;
            pceCheckBox.LoadImage();
        }

        private void pcePlus_Click(object sender, EventArgs e)
        {
            if (quantity == 0)
            {
                isChecked = true;
                SetCheckBoxImage();
                pceMinus.Enabled = true;
            }
            quantity++;
            lbcQuantity.Text = quantity.ToString();
        }

        private void pceMinus_Click(object sender, EventArgs e)
        {
            if (quantity == 1)
            {
                isChecked = false;
                SetCheckBoxImage();
                pceMinus.Enabled = false;
            }
            quantity--;
            lbcQuantity.Text = quantity.ToString();
        }
    }
}
