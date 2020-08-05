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
    public partial class GroceryUpdate : Form
    {
        public GroceryUpdate()
        {
            InitializeComponent();
        }

        private Grocery _grocery = new Grocery();

        public GroceryUpdate(Grocery grocery) : this()
        {
            txeGroceryId.Text = grocery.GroceryId.ToString();
            cbbCategoryId.SelectedItem = grocery.CodeCategoryId;
            txeUnit.Text = grocery.Unit.ToString();
            txeName.Text = grocery.Item;
            txePrice.Text = grocery.Price.ToString();
            if (grocery.Picture != null)
                pcbImage.Image = byteArrayToImage(grocery.Picture);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _grocery.GroceryId = int.Parse(txeGroceryId.Text);
            _grocery.CodeCategoryId = (int)cbbCategoryId.SelectedValue;
            _grocery.Price = int.Parse(txePrice.Text);
            try
            {
                _grocery.Unit = int.Parse(txeUnit.Text);
            }
            catch (Exception)
            {
                Helpers.InputConstraint.OnlyIntConstraint(txeUnit);
            }
            _grocery.Item = txeName.Text;

            if (pcbImage.Image != null)
                _grocery.Picture = ConvertImageToBinary(pcbImage.Image);
            try
            {
                DataRepository.Grocery.Update(_grocery);
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

        private void GroceryUpdate_Load(object sender, EventArgs e)
        {
            bdsCategory.DataSource = DataRepository.CodeCategory.GetAll();
        }

        private void txeUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
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

    }
}
