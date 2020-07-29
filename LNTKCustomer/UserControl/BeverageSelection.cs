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
    public partial class BeverageSelection : DevExpress.XtraEditors.XtraUserControl
    {
        public BeverageSelection()
        {
            InitializeComponent();
        }
        
        public void SetPicture(int productId)
        {
            pceBeveragePicture.Image = byteArrayToImage(DataRepository.Product.Get(productId).Picture);
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private void sbtBeverageCustomization_Click(object sender, EventArgs e)
        {
            OnBeverageEdit((int)pceBeveragePicture.EditValue);
        }

        #region BeverageEdit event things for C# 3.0
        public event EventHandler<BeverageEditEventArgs> BeverageEdit;

        protected virtual void OnBeverageEdit(BeverageEditEventArgs e)
        {
            if (BeverageEdit != null)
                BeverageEdit(this, e);
        }

        private BeverageEditEventArgs OnBeverageEdit(int productId)
        {
            BeverageEditEventArgs args = new BeverageEditEventArgs(productId);
            OnBeverageEdit(args);

            return args;
        }

        private BeverageEditEventArgs OnBeverageEditForOut()
        {
            BeverageEditEventArgs args = new BeverageEditEventArgs();
            OnBeverageEdit(args);

            return args;
        }

        public class BeverageEditEventArgs : EventArgs
        {
            public int ProductId { get; set; }

            public BeverageEditEventArgs()
            {
            }

            public BeverageEditEventArgs(int productId)
            {
                ProductId = productId;
            }
        }
        #endregion

    }
}
