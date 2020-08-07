using LNTKKiosk.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTKManager
{
    public partial class ProductUpdate : Form
    {
        public ProductUpdate()
        {
            InitializeComponent();
        }

        private Product _product = new Product();

        public ProductUpdate(Product product) : this()
        {
            txeID.Text = product.ProductId.ToString();
            txeName.Text = product.Name;

            txbDescription.Text = product.Description;
            txePrice.Text = product.Price.ToString();
            cbbCategoryId.SelectedItem = product.CodeCategoryId;

            if(product.Picture !=null)
            pcbImage.Image = byteArrayToImage(product.Picture);
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private byte[] ConvertImageToBinary(Image image)
        {

            using (MemoryStream memoryStream = new MemoryStream())
            {
                if (ImageFormat.Jpeg.Equals(image.RawFormat))
                {
                    image.Save(memoryStream, ImageFormat.Jpeg);
                }
                else if (ImageFormat.Png.Equals(image.RawFormat))
                {
                    image.Save(memoryStream, ImageFormat.Png);
                }
                else if (ImageFormat.Gif.Equals(image.RawFormat))
                {
                    image.Save(memoryStream, ImageFormat.Gif);
                }
                return memoryStream.ToArray();
            }
        }

        private void txbDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                e.Handled = true;
        }

        private void txePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))  
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txePath.Text = "";
            String file_Path = null;
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pcbImage.Image = Image.FromFile(openFileDialog1.FileName);
                file_Path = openFileDialog1.FileName;
                txePath.Text = file_Path.Split('\\')[file_Path.Split('\\').Length - 1];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _product.ProductId = int.Parse(txeID.Text);
            if(txeName.Text == null)
            {
                MessageBox.Show("상품명을 입력해주세요");
                return;
            }

            _product.Name = txeName.Text;

            if(txbDescription.Text == null)
            {
                MessageBox.Show("상품설명을 입력해주세요");
                return;
            }

            _product.Description = txbDescription.Text;

            if (pcbImage.Image != null)
                _product.Picture = ConvertImageToBinary(pcbImage.Image);

            if(txePrice.Text == null)
            {
                MessageBox.Show("가격을 입력해주세요");
                return;
            }

            _product.Price = int.Parse(txePrice.Text);

            _product.CodeCategoryId = (int)cbbCategoryId.SelectedValue;

            try
            {
                DataRepository.Product.Update(_product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("수정되었습니다.");
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            bdsCategory.DataSource = DataRepository.CodeCategory.GetMenuCategory();
        }


    }
}
