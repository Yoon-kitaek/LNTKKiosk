using DevExpress.XtraReports.Serialization;
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
    public partial class ProductInsert : Form
    {
        public ProductInsert()
        {
            InitializeComponent();
        }

        public ProductInsert(Product product)
        {
            InitializeComponent();

            txeID.Text = product.ProductId.ToString();
            txeName.Text = product.Name;

            txbDescription.Text = product.Description;
            txePrice.Text = product.Price.ToString();
            cbbCategoryId.SelectedItem = product.CodeCategoryId;
            
           // pcbImage.Image = byteArrayToImage(product.Picture);

            if (pcbImage.Image != null)
                _product.Picture = ConvertImageToBinary(pcbImage.Image);
        }

        private Product _product = new Product(); 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txePath.Text = "";
            String file_Path = null;
            openFileDialog1.InitialDirectory = "C:\\";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pcbImage.Image = Image.FromFile(openFileDialog1.FileName);
                file_Path = openFileDialog1.FileName;
                txePath.Text = file_Path.Split('\\')[file_Path.Split('\\').Length - 1];
            }

        }

        private void WriteToEntity()
        {
            _product.Name = txeName.Text;
            _product.Description = txbDescription.Text;
            if (pcbImage.Image != null)
            _product.Picture = ConvertImageToBinary(pcbImage.Image);
            _product.Price = int.Parse(txePrice.Text);
            _product.CodeCategoryId = (int)cbbCategoryId.SelectedValue;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txeName.Text == "")
            {
                MessageBox.Show("상품명을 입력해주세요.");
                return;
            }

            if(txbDescription.Text == "")
            {
                MessageBox.Show("상품설명을 입력해주세요.");
                return;
            }

            if(txePrice.Text == "")
            {
                MessageBox.Show("가격을 입력해주세요."); ;
                return;
            }

            WriteToEntity();
           
            try
            {
                DataRepository.Product.Insert(_product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("등록되었습니다.");
            Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txePrice_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txePrice);
        }

        private void txbDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                e.Handled = true;
        }

        private void ProductInsert_Load(object sender, EventArgs e)
        {
            bdsCategory.DataSource = DataRepository.CodeCategory.GetMenuCategory();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _product.ProductId = int.Parse(txeID.Text);
            WriteToEntity();

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
    }
}
