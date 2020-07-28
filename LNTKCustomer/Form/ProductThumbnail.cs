using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LNTKKiosk.Data;
using LNTKCustomer.UserControl;

namespace LNTKCustomer.Form
{
    public partial class ProductThumbnail : DevExpress.XtraEditors.XtraForm
    {
        private const int thumbnailCount = 6;
        private List<UserControl.Thumbnail> thumbnails = new List<UserControl.Thumbnail>();
        private int page = 0;
        private int categoryId;
        List<ShoppedItem> shoppingList = new List<ShoppedItem>();
        public void SetCategoryId(int categoryId)
        {
            this.categoryId = categoryId;
            BindThumbnail();   
        
        }

        //categoryid=11 음료
        //categoryid=12 사이드
        public ProductThumbnail()
        {
            InitializeComponent();
        }

        public void GetShoppedItemList(List<ShoppedItem> shoppingList)
        {
            this.shoppingList = shoppingList;
        }



        private void ProductThumbnail_Load(object sender, EventArgs e)
        {
            categoryId = 10;
            thumbnails.Add(uscThumbnail1);
            thumbnails.Add(uscThumbnail2);
            thumbnails.Add(uscThumbnail3);
            thumbnails.Add(uscThumbnail4);
            thumbnails.Add(uscThumbnail5);
            thumbnails.Add(uscThumbnail6);
            BindThumbnail();

        }

        private void BindThumbnail()
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

        private void pceLeft_Click(object sender, EventArgs e)
        {
            if (page == 0)
                page = (DataRepository.Product.FilterbyCatergory(categoryId).Count-1) / thumbnailCount;
            else
                page--;
            BindThumbnail();
        }

        private void pceRight_Click(object sender, EventArgs e)
        {
            if (page == (DataRepository.Product.FilterbyCatergory(categoryId).Count - 1) / thumbnailCount)
                page = 0;
            else
                page++;
            BindThumbnail();
        }


        private void uscThumbnail_ThumbnailClicked(object sender, Thumbnail.ThumbnailClickedEventArgs e)
        {
            Thumbnail thumbnail = sender as Thumbnail;
            if (thumbnail.Label.Contains("버거") == true)
            {
                SingleOrSet form = new SingleOrSet(thumbnail.Label, shoppingList);
                form.Show();
            }
            else
            {
                Product product = DataRepository.Product.GetByName(thumbnail.Label);
                shoppingList.Add(new ShoppedItem(product.Name, product.ProductId, 1));
            }


            OnThumbnailClicked(e.Name);

        }


       
        #region ThumbnailClicked event things for C# 3.0
        public event EventHandler<ThumbnailClickedEventArgs> ThumbnailClicked;

        protected virtual void OnThumbnailClicked(ThumbnailClickedEventArgs e)
        {
            if (ThumbnailClicked != null)
                ThumbnailClicked(this, e);
        }

        private ThumbnailClickedEventArgs OnThumbnailClicked(string name)
        {
            ThumbnailClickedEventArgs args = new ThumbnailClickedEventArgs(name);
            OnThumbnailClicked(args);

            return args;
        }

        private ThumbnailClickedEventArgs OnThumbnailClickedForOut()
        {
            ThumbnailClickedEventArgs args = new ThumbnailClickedEventArgs();
            OnThumbnailClicked(args);

            return args;
        }

        public class ThumbnailClickedEventArgs : EventArgs
        {
            public string Name { get; set; }

            public ThumbnailClickedEventArgs()
            {
            }

            public ThumbnailClickedEventArgs(string name)
            {
                Name = name;
            }
        }
        #endregion


    }
}