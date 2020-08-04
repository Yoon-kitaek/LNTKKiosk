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
        private List<Recipe> recipe=new List<Recipe>();
        public CustomizationButton()
        {
            InitializeComponent();
        }

        public CustomizationButton(int productId, List<Recipe> recipe)
        {
            InitializeComponent();
            this.productId = productId;
            this.recipe = recipe;
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
            OnIngredientEdit(productId,recipe);
            OpenIngredientCustomization(productId,recipe);
        }


        private void OpenIngredientCustomization(int productId)
        {
            IngredientThumbnail ingredientThumbnail = new IngredientThumbnail(productId,recipe);
            ingredientThumbnail.Show();
        }

        #region IngredientEdit event things for C# 3.0
        public event EventHandler<IngredientEditEventArgs> IngredientEdit;

        protected virtual void OnIngredientEdit(IngredientEditEventArgs e)
        {
            if (IngredientEdit != null)
                IngredientEdit(this, e);
        }

        private IngredientEditEventArgs OnIngredientEdit(int productId)
        {
            IngredientEditEventArgs args = new IngredientEditEventArgs(productId);
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

            public IngredientEditEventArgs()
            {
            }

            public IngredientEditEventArgs(int productId)
            {
                ProductId = productId;
            }
        }
        #endregion

    }
}
