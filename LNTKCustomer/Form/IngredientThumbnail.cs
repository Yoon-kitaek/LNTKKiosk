using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LNTKKiosk.Data;
using DevExpress.DataProcessing;
using LNTKCustomer.UserControl;

namespace LNTKCustomer.Form
{
    public partial class IngredientThumbnail : DevExpress.XtraEditors.XtraForm
    {
        private List<CodeCategory> codeCategories = new List<CodeCategory>();
        private List<int> categoryNumber = new List<int>();
        private List<Grocery> groceries = new List<Grocery>();
        private List<IngredientCustomization> thumbnails = new List<IngredientCustomization>();
        private List<Recipe> changedRecipe = new List<Recipe>();
        int i, productId;
        public IngredientThumbnail(int productId)
        {
            InitializeComponent();

            this.productId = productId;
            this.changedRecipe = OrderInfo.Instance.changedRecipe;
            thumbnails.Add(uscIngredient1);
            thumbnails.Add(uscIngredient2);
            thumbnails.Add(uscIngredient3);
            thumbnails.Add(uscIngredient4);


            i = 0;
            pceLeft.Enabled = false;
            codeCategories = DataRepository.CodeCategory.GetAll();
            List<string> ingredientOrder = new List<string> { "빵", "패티", "야채","토핑", "소스", "육류", "치즈" };
            foreach (string ingredientName in ingredientOrder)
            {
                categoryNumber.Add(codeCategories.FirstOrDefault(x => x.Item.Equals(ingredientName)).CodeCategoryId);
            }
            SetThumbnail();
        }

        private void pceRight_Click(object sender, EventArgs e)
        {
           
            if (i == 0)
            {
                int j = 0;
                foreach (IngredientCustomization ingredientCustomization in thumbnails)
                    j += ingredientCustomization.quantity;
                if (j != 1)
                {
                    MessageBox.Show("빵은 하나만");
                    return;
                }
                pceLeft.Enabled = true;
            }

            for (int j = 0; j<groceries.Count();j++)
            {
                Recipe recipe = thumbnails[j].SaveChange();
                if (recipe == null)
                    continue;
                else
                {
                    int index = changedRecipe.FindIndex(x => x.GroceryId == groceries[j].GroceryId);
                    if (index != -1)
                    {
                        changedRecipe[index].Amount += recipe.Amount;
                        if (changedRecipe[index].Amount == 0)
                            changedRecipe.RemoveAt(index);
                    }
                    else
                        changedRecipe.Add(recipe);
                }

            }

            if (i == categoryNumber.Count - 1)
            {
                MessageBox.Show("버거 커스터마이징 끝");
                OrderInfo.Instance.changedRecipe.AddRange(changedRecipe);
                Close();
                return;
            } 
            
            i++;
            SetThumbnail();
               
            
               
        }

        private void pceLeft_Click(object sender, EventArgs e)
        {

            if (i == 0)
                pceLeft.Enabled = false;
             i--;           
            SetThumbnail();
        }

        private void SetThumbnail()
        {
            groceries = DataRepository.Grocery.GetbyCodeCategory(categoryNumber[i]);
            lbcGroceryName.Text = codeCategories.FirstOrDefault(x => x.CodeCategoryId == categoryNumber[i]).Item;
            for (int j = 0; j < groceries.Count(); j++)
            {
                thumbnails[j].Visible = true;
                thumbnails[j].SetValues(productId, groceries[j].GroceryId);
                int index = changedRecipe.FindIndex(x => x.GroceryId == groceries[j].GroceryId);
                if (index != -1)
                    thumbnails[j].SetQuantity(changedRecipe[index].Amount);
            }
            if (groceries.Count() < 4)
            {
                for (int j = groceries.Count; j < 4; j++)
                    thumbnails[j].Visible = false;
            
            }
        
        }
    }
}