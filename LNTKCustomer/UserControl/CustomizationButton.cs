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
using System.IO;

namespace LNTKCustomer.UserControl
{
    public partial class CustomizationButton : DevExpress.XtraEditors.XtraUserControl
    {
        private int productId;
        private List<Recipe> changedRecipe = new List<Recipe>();
        public CustomizationButton()
        {
            InitializeComponent();
        }

        public CustomizationButton(int productId, List<Recipe> changedRecipe)
        {
            InitializeComponent();
            this.productId = productId;
            this.changedRecipe = changedRecipe;
        }


        public void SetPicture(int productId)
        {
            pceBurgerPicture.Image = byteArrayToImage(DataRepository.Product.Get(productId).Picture);
        
        }



        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private void sbtBurgerCustomization_Click(object sender, EventArgs e)
        {
            OnIngredientEdit(productId, changedRecipe);
            OpenIngredientCustomization(productId, changedRecipe);
        }


        private void OpenIngredientCustomization(int productId, List<Recipe> changedRecipe)
        {
            IngredientThumbnail ingredientThumbnail = new IngredientThumbnail(productId, changedRecipe);
            ingredientThumbnail.Show();
        }

        #region IngredientEdit event things for C# 3.0
        public event EventHandler<IngredientEditEventArgs> IngredientEdit;

        protected virtual void OnIngredientEdit(IngredientEditEventArgs e)
        {
            if (IngredientEdit != null)
                IngredientEdit(this, e);
        }

        private IngredientEditEventArgs OnIngredientEdit(int productId, List<Recipe> changedRecipe)
        {
            IngredientEditEventArgs args = new IngredientEditEventArgs(productId, changedRecipe);
            OnIngredientEdit(args);

            return args;
        }

        private IngredientEditEventArgs OnIngredientEditForOut()
        {
            IngredientEditEventArgs args = new IngredientEditEventArgs();
            OnIngredientEdit(args);

            return args;
        }

        public class IngredientEditEventArgs : EventArgs
        {
            public int ProductId { get; set; }
            public List<Recipe> ChangedRecipe { get; set; }

            public IngredientEditEventArgs()
            {
            }

            public IngredientEditEventArgs(int productId, List<Recipe> changedRecipe)
            {
                ProductId = productId;
                ChangedRecipe = changedRecipe;
            }
        }
        #endregion









    }
}
