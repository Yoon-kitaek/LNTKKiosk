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
    public partial class RecipeUpdate : Form
    {
        public RecipeUpdate()
        {
            InitializeComponent();
        }

        private Recipe _recipe = new Recipe();

        public RecipeUpdate(Recipe recipe) : this()
        {

            cbbProductId.SelectedItem = recipe.ProductId;
            cbbGroceryId.SelectedItem = recipe.GroceryId;
            txeAmount.Text = recipe.Amount.ToString();
        }

        private void RecipeUpdate_Load(object sender, EventArgs e)
        {
            bdsGrocery.DataSource = DataRepository.Grocery.GetAll();
            bdsProduct.DataSource = DataRepository.Product.GetAllPartial();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _recipe.ProductId = (int)cbbProductId.SelectedValue;
            _recipe.GroceryId = (int)cbbGroceryId.SelectedValue;
            _recipe.Amount = int.Parse(txeAmount.Text);

            try
            {
                DataRepository.Recipe.Update(_recipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("수정되었습니다.");
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txeAmount_EditValueChanged(object sender, EventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txeAmount);
        }
    }
}
