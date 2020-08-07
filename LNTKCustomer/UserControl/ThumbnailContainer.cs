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
        public int categoryId;
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

        public void SetCatergoryId(int categoryId)
        {
            isShoppingCart = false;
            this.categoryId = categoryId;
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

        private void uscTabButton_ButtonClicked(object sender, Thumbnail.ThumbnailClickedEventArgs e)
        {
            if (isShoppingCart == false)
            {
                Thumbnail thumbnail = sender as Thumbnail;

                OnMenuSelected(e.Name);
                if (categoryId == 11)
                    OrderInfo.Instance.selectedBeverage = DataRepository.Product.GetByName(e.Name).ProductId;
                if (categoryId == 12)
                    OrderInfo.Instance.selectedSide = DataRepository.Product.GetByName(e.Name).ProductId;
                SideOrBeverageCustomization sideOrBeverageCustomization = this.Parent.Parent as SideOrBeverageCustomization;
                sideOrBeverageCustomization.Close();
            }


        }

        #region MenuSelected event things for C# 3.0
        public event EventHandler<MenuSelectedEventArgs> MenuSelected;

        protected virtual void OnMenuSelected(MenuSelectedEventArgs e)
        {
            if (MenuSelected != null)
                MenuSelected(this, e);
        }

        private MenuSelectedEventArgs OnMenuSelected(string label)
        {
            MenuSelectedEventArgs args = new MenuSelectedEventArgs(label);
            OnMenuSelected(args);

            return args;
        }

        private MenuSelectedEventArgs OnMenuSelectedForOut()
        {
            MenuSelectedEventArgs args = new MenuSelectedEventArgs();
            OnMenuSelected(args);

            return args;
        }

        public class MenuSelectedEventArgs : EventArgs
        {
            public string Name { get; set; }

            public MenuSelectedEventArgs()
            {
            }

            public MenuSelectedEventArgs(string name)
            {
                Name = name;
            }
        }
        #endregion



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
                lastPage = shoppedPackageList.Count - 1;


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

    }
}
