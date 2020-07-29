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
        public CustomizationButton()
        {
            InitializeComponent();
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
            OnrecipeEdit((int)pceBurgerPicture.EditValue);
        }

        #region recipeEdit event things for C# 3.0
        public event EventHandler<recipeEditEventArgs> recipeEdit;

        protected virtual void OnrecipeEdit(recipeEditEventArgs e)
        {
            if (recipeEdit != null)
                recipeEdit(this, e);
        }

        private recipeEditEventArgs OnrecipeEdit(int productId)
        {
            recipeEditEventArgs args = new recipeEditEventArgs(productId);
            OnrecipeEdit(args);

            return args;
        }

        private recipeEditEventArgs OnrecipeEditForOut()
        {
            recipeEditEventArgs args = new recipeEditEventArgs();
            OnrecipeEdit(args);

            return args;
        }

        public class recipeEditEventArgs : EventArgs
        {
            public int ProductId { get; set; }

            public recipeEditEventArgs()
            {
            }

            public recipeEditEventArgs(int productId)
            {
                ProductId = productId;
            }
        }
        #endregion


    }
}
