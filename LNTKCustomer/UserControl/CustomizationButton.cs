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
        public int productId { get; set; }
        public CustomizationButton()
        {
            InitializeComponent();
        }

        public CustomizationButton(int productId)
        {
            InitializeComponent();
            this.productId = productId;
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
            LNTKCustomer.Form.IngredientThumbnail ingredientThumbnail = new LNTKCustomer.Form.IngredientThumbnail(productId);
            ingredientThumbnail.Show();
        }


        private void OpenIngredientCustomization(int productId)
        {
            IngredientThumbnail ingredientThumbnail = new IngredientThumbnail(productId);
            ingredientThumbnail.Show();
        }

        #region MenuClicked event things for C# 3.0
        public event EventHandler<MenuClickedEventArgs> MenuClicked;

        protected virtual void OnMenuClicked(MenuClickedEventArgs e)
        {
            if (MenuClicked != null)
                MenuClicked(this, e);
        }

        private MenuClickedEventArgs OnMenuClicked()
        {
            MenuClickedEventArgs args = new MenuClickedEventArgs();
            OnMenuClicked(args);

            return args;
        }

        private MenuClickedEventArgs OnMenuClickedForOut()
        {
            MenuClickedEventArgs args = new MenuClickedEventArgs();
            OnMenuClicked(args);

            return args;
        }

        public class MenuClickedEventArgs : EventArgs
        {

            public MenuClickedEventArgs()
            {
            }

            public MenuClickedEventArgs(string name)
            {
            }
        }
        #endregion





    }
}
