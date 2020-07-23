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
using DevExpress.Internal;

namespace LNTKCustomer.UserControl
{
    public partial class ShoppedProductImages : DevExpress.XtraEditors.XtraUserControl
    {
        private const int thumbnailCount = 4;
        private List<UserControl.Thumbnail> thumbnails = new List<UserControl.Thumbnail>();
        private int j = 0;
        List<ProductPackage> shoppinglist = new List<ProductPackage>();

        public ShoppedProductImages()
        {
            InitializeComponent();
            thumbnails.Add(uscThumbnail1);
            thumbnails.Add(uscThumbnail2);
            thumbnails.Add(uscThumbnail3);
            thumbnails.Add(uscThumbnail4);
        }

        public void SetShoppingList (List<ProductPackage> list)
        {
            shoppinglist = list;
            BindingThumbnail();
        }
        private void BindingThumbnail()
        {
            lbcPackageName.Text = shoppinglist[j].PackageName;
            for (int i = 0; i < thumbnailCount; i++)
            {
                if (shoppinglist[j].productIds.Count <= i )
                {
                    thumbnails[i].Visible = false;
                }
                else
                {
                    thumbnails[i].Visible = true;
                    thumbnails[i].SetValues(DataRepository.Product.Get(shoppinglist[j].productIds[i]).Name);
                }

            }
        }
        private void pceLeft_Click(object sender, EventArgs e)
        {
            OnArrowClicked(false);
        }

        private void pceRight_Click(object sender, EventArgs e)
        {
            OnArrowClicked(true);
        }

        #region ArrowClicked event things for C# 3.0
        public event EventHandler<ArrowClickedEventArgs> ArrowClicked;

        protected virtual void OnArrowClicked(ArrowClickedEventArgs e)
        {
            if (ArrowClicked != null)
                ArrowClicked(this, e);
        }

        private ArrowClickedEventArgs OnArrowClicked(bool isRight)
        {
            ArrowClickedEventArgs args = new ArrowClickedEventArgs(isRight);
            OnArrowClicked(args);
            if (isRight == true)
            {
                if (j == shoppinglist.Count-1)
                    j = 0;
                else
                    j++;

            }
            else
            {
                if (j == 0)
                    j = shoppinglist.Count - 1;
                else
                    j--;

            }
            BindingThumbnail();

            return args;
        }

        private ArrowClickedEventArgs OnArrowClickedForOut()
        {
            ArrowClickedEventArgs args = new ArrowClickedEventArgs();
            OnArrowClicked(args);

            return args;
        }

        public class ArrowClickedEventArgs : EventArgs
        {
            public bool IsRight { get; set; }

            public ArrowClickedEventArgs()
            {
            }

            public ArrowClickedEventArgs(bool isRight)
            {
                IsRight = isRight;
            }
        }
        #endregion
    }
}
