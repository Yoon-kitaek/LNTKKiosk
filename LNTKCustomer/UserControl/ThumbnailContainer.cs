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
using LNTKCustomer.Form;

namespace LNTKCustomer.UserControl
{
    public partial class ThumbnailContainer : DevExpress.XtraEditors.XtraUserControl
    {
        private List<ShoppedPackage> shoppedPackageList = new List<ShoppedPackage>();
        private List<Thumbnail> thumbnails = new List<Thumbnail>();
        private const int thumbnailCount = 4;
        private int page = 0;
        public int categoryId { get; set; }
        private bool isShoppingCart = false;

        public ThumbnailContainer()
        {
            InitializeComponent();
        }

        public void SetShoppedItemList(List<ShoppedPackage> shoppedPackageList)
        {
            isShoppingCart = true;
            this.shoppedPackageList = shoppedPackageList;
            BindingThumbnail();
        }
        private void ThumbnailContainer_Load(object sender, EventArgs e)
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
            if (isShoppingCart == false)
            {
                List<Product> products = DataRepository.Product.FilterbyCatergory(categoryId);
                for (int i = 0; i < thumbnailCount; i++)
                {
                    if (i + page * thumbnailCount >= products.Count)
                    {
                        thumbnails[i].Visible = false;
                    }
                    else
                    {
                        thumbnails[i].Visible = true;
                        thumbnails[i].SetValues(products[i + page * thumbnailCount].Name);
                    }
                }
            }
            else
            {
                for (int i = 0; i < thumbnailCount; i++)
                {
                    if (i >= shoppedPackageList[page].productIds.Count)
                    {
                        thumbnails[i].Visible = false;
                    }
                    else
                    {
                        thumbnails[i].Visible = true;
                        thumbnails[i].SetValues(DataRepository.Product.Get(shoppedPackageList[page].productIds[i]).Name);
                    }
                }
            }
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
            int lastPage;
            if (isShoppingCart == false)
                lastPage = (DataRepository.Product.FilterbyCatergory(categoryId).Count - 1) / thumbnailCount;
            else
                lastPage = shoppedPackageList.Count-1;


            if (isRight == true)
            {
                if (page == lastPage)
                    page = 0;
                else
                    page++;

            }
            else
            {
                if (page == 0)
                    page = lastPage;
                else
                    page--;
            }
            BindingThumbnail();
            //if (isShoppingCart == true)
            //    args.packageName = shoppedPackageList[j].packageName;

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
            public bool isRight { get; set; }
            //TODO : public string packageName { get; set; }

            public ArrowClickedEventArgs()
            {
            }

            public ArrowClickedEventArgs(bool isRight)
            {
                this.isRight = isRight;
            }
        }
        #endregion

        private void pceLeftArrow_Click(object sender, EventArgs e)
        {
            OnArrowClicked(false);
        }

        private void pceRightArrow_Click(object sender, EventArgs e)
        {
            OnArrowClicked(true);
        }


        #region SideOrBeverageEdit event things for C# 3.0
        public event EventHandler<SideOrBeverageEditEventArgs> SideOrBeverageEdit;

        protected virtual void OnSideOrBeverageEdit(SideOrBeverageEditEventArgs e)
        {
            if (SideOrBeverageEdit != null)
                SideOrBeverageEdit(this, e);
        }

        private SideOrBeverageEditEventArgs OnSideOrBeverageEdit(int categoryId)
        {
            SideOrBeverageEditEventArgs args = new SideOrBeverageEditEventArgs(categoryId);
            OnSideOrBeverageEdit(args);

            return args;
        }

        private SideOrBeverageEditEventArgs OnSideOrBeverageEditForOut()
        {
            SideOrBeverageEditEventArgs args = new SideOrBeverageEditEventArgs();
            OnSideOrBeverageEdit(args);

            return args;
        }

        public class SideOrBeverageEditEventArgs : EventArgs
        {
            public int CategoryId { get; set; }

            public SideOrBeverageEditEventArgs()
            {
            }

            public SideOrBeverageEditEventArgs(int categoryId)
            {
                CategoryId = categoryId;
            }
        }
        #endregion

        private void uscThumbnail1_Click(object sender, EventArgs e)
        {
            //OnSideOrBeverageEdit()
        }
    }
}
