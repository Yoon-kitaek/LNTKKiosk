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
    public partial class RecipeManagement : Form
    {
        public RecipeManagement()
        {
            InitializeComponent();
        }

        private Recipe _recipe = new Recipe();

        private void WriteToEntity()
        {
            _recipe.ProductId = (int)cbbProductId.SelectedValue;
            _recipe.GroceryId = (int)cbbGroceryId.SelectedValue;

            try
            {
                _recipe.Amount = int.Parse(txeAmount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cbbProductId_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbbProductId.SelectedValue != null)
           bdsRecipe.DataSource = DataRepository.Recipe.GetByProductIdWithProperties((int?)cbbProductId.SelectedValue);
        }

        private void RecipeManagement_Load(object sender, EventArgs e)
        {
            bdsGrocery.DataSource = DataRepository.Grocery.GetAll();
            bdsProduct.DataSource = DataRepository.Product.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txeAmount.Text == "")
            {
                MessageBox.Show("수량을 입력해주세요");
                return;
            }

            WriteToEntity();
           
            if (_recipe.Amount == 0)
                return;
            try
            {
                DataRepository.Recipe.Insert(_recipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("등록되었습니다.");
            
            bdsRecipe.DataSource = DataRepository.Recipe.GetByProductIdWithProperties((int?)cbbProductId.SelectedValue);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Recipe recipe = bdsRecipe.Current as Recipe;
            if (recipe == null)
                return;
            DataRepository.Recipe.Update(recipe);
            MessageBox.Show("수정되었습니다.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Recipe recipe = bdsRecipe.Current as Recipe;
            if (recipe == null)
                return;
            if (Helpers.Helper.SureToDelete() == false)
                return;

            DataRepository.Recipe.Delete(recipe);

            bdsRecipe.Remove(recipe);
        }

        private void txeAmount_EditValueChanged(object sender, EventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txeAmount);
        }
    }
}
