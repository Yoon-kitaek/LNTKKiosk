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
using System.IO;
using LNTKKiosk.Data;

namespace LNTKCustomer.UserControl
{
    public partial class SideSelection : DevExpress.XtraEditors.XtraUserControl
    {
        public SideSelection()
        {
            InitializeComponent();
        }

        public void SetPicture(int productId)
        {
            pceSidePicture.Image = byteArrayToImage(DataRepository.Product.Get(productId).Picture);
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
    }
}
