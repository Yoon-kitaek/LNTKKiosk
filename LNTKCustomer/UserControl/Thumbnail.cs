﻿using System;
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
using System.IO;
using LNTKCustomer.Form;

namespace LNTKCustomer.UserControl
{
    public partial class Thumbnail : DevExpress.XtraEditors.XtraUserControl
    {
        public Thumbnail()
        {
            InitializeComponent();
        }

        private void Thumbnail_Load(object sender, EventArgs e)
        {
            lbcName.Width = pceThumbnail.Width;
        }

        public string Label
        {
            get
            {
                return lbcName.Text;
            }
            set
            {
                Product product = DataRepository.Product.GetByName(value);
                
                lbcName.Text = value;

                if (DataRepository.Product.GetDiscountRate(product) > 0)
                    lbcDiscountSticker.Visible = true;
                else
                    lbcDiscountSticker.Visible = false;
                
                lbcPrice.Text = DataRepository.Product.GetByName(lbcName.Text).EventPrice.ToString();
                SetPicture();

            }
        }

        public void SetPicture()
        {
            pceThumbnail.Image = byteArrayToImage(DataRepository.Product.GetByName(lbcName.Text).Picture);
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private void Thumbnail_Click(object sender, EventArgs e)
        {
            OnThumbnailClicked(lbcName.Text);
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

