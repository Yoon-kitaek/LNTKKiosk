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

namespace LNTKCustomer.UserControl
{
    public partial class SelectBeverage : DevExpress.XtraEditors.XtraUserControl
    {
        private const int thumbnailCount = 4;
        private List<UserControl.Thumbnail> thumbnails = new List<UserControl.Thumbnail>();
        private int j = 0;
        private int categoryid = 11;

        public SelectBeverage()
        {
            InitializeComponent();
        }
        private void SelectBeverage_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;


            thumbnails.Add(uscThumbnail1);
            thumbnails.Add(uscThumbnail2);
            thumbnails.Add(uscThumbnail3);
            thumbnails.Add(uscThumbnail4);
            BindingThumbnail();

        }
        private void BindingThumbnail()
        {
            List<Product> products = DataRepository.Product.FilterbyCatergory(categoryid);
            for (int i = 0; i < thumbnailCount; i++)
            {
                if (i + j * thumbnailCount >= products.Count)
                {
                    thumbnails[i].Visible = false;
                }
                else
                {
                    thumbnails[i].Visible = true;
                    thumbnails[i].SetValues(products[i + j * thumbnailCount].Name);
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
                if (j == (DataRepository.Product.FilterbyCatergory(categoryid).Count - 1) / thumbnailCount)
                    j = 0;
                else
                    j++;

            }
            else
            {
                if (j == 0)
                    j = (DataRepository.Product.FilterbyCatergory(categoryid).Count - 1) / thumbnailCount;
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
