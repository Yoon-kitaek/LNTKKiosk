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
        
        private void RecipeManagement_Load(object sender, EventArgs e)
        {
            bdsRecipe.DataSource = DataRepository.Recipe.GetAllWithProperties();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            RecipeInsert form = new RecipeInsert();
            form.ShowDialog();
        }

       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Recipe recipe = bdsRecipe.Current as Recipe;
            if (recipe == null)
                return;

            RecipeUpdate form = new RecipeUpdate(recipe);
            form.ShowDialog();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
