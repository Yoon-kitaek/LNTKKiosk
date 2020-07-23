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
        private int j = 0;
        private int categoryId;
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
            if (j == 0)
                j = (DataRepository.Product.FilterbyCatergory(categoryId).Count-1) / thumbnailCount;
            else
                j--;
            BindThumbnail();
        }

        private void pceRight_Click(object sender, EventArgs e)
        {
            if (j == (DataRepository.Product.FilterbyCatergory(categoryId).Count - 1) / thumbnailCount)
                j = 0;
            else
                j++;
            BindThumbnail();
        }
    }
}