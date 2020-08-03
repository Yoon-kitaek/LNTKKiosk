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
using System.IO;
using LNTKKiosk.Data;
using DevExpress.XtraLayout.Customization;
using LNTKCustomer.Form;
using DevExpress.Utils.DirectXPaint.Svg;

namespace LNTKCustomer.UserControl
{
    public partial class SideSelection : DevExpress.XtraEditors.XtraUserControl
    {
        public int categoryId = 12;
        public SideSelection()
        {
            InitializeComponent();
        }

        public void SetPicture(int productId)
        {
            DataRepository.Product.FilterbyCatergory(categoryId);

            pceSidePicture.Image = byteArrayToImage(DataRepository.Product.Get(productId).Picture);
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        #region SideEdit event things for C# 3.0
        public event EventHandler<SideEditEventArgs> SideEdit;

        protected virtual void OnSideEdit(SideEditEventArgs e)
        {
            if (SideEdit != null)
                SideEdit(this, e);
        }

        private SideEditEventArgs OnSideEdit(int productId)
        {
            SideEditEventArgs args = new SideEditEventArgs(productId);
            OnSideEdit(args);

            return args;
        }

        private SideEditEventArgs OnSideEditForOut()
        {
            SideEditEventArgs args = new SideEditEventArgs();
            OnSideEdit(args);

            return args;
        }

        public class SideEditEventArgs : EventArgs
        {
            public int ProductId { get; set; }

            public SideEditEventArgs()
            {
            }

            public SideEditEventArgs(int productId)
            {
                ProductId = productId;
            }
        }
        #endregion

        private void sbtFriesCustomization_Click(object sender, EventArgs e)
        {
            OnSideEdit(categoryId);
            OpenSideOrBeverateCustomization(categoryId);
        }

        private void OpenSideOrBeverateCustomization(int categoryId)
        {
            SideOrBeverageCustomization sideOrBeverageCustomization = new SideOrBeverageCustomization(categoryId);
            sideOrBeverageCustomization.ShowDialog();
        }

    }
}
