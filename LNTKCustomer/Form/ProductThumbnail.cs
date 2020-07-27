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

        private void uscThumbnail_Click(int i)
        {
           // if (thumbnails[i].Label.Contains("버거") == true)
                
          //  else
            {
                Product product = DataRepository.Product.GetByName(thumbnails[i].Label);
                shoppingList.Add(new ShoppedItem(product.Name,product.ProductId,1,product.EventPrice));
            }

        }



        private void uscThumbnail1_Click(object sender, EventArgs e)
        {
            uscThumbnail_Click(0);
        }

        private void uscThumbnail2_Click(object sender, EventArgs e)
        {
            uscThumbnail_Click(1);
        }

        private void uscThumbnail3_Click(object sender, EventArgs e)
        {
            uscThumbnail_Click(2);
        }

        private void uscThumbnail4_Click(object sender, EventArgs e)
        {
            uscThumbnail_Click(3);
        }

        private void uscThumbnail5_Click(object sender, EventArgs e)
        {
            uscThumbnail_Click(4);
        }

        private void uscThumbnail6_Click(object sender, EventArgs e)
        {
            uscThumbnail_Click(5);
        }
    }
}