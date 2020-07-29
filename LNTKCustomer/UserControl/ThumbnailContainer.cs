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

namespace LNTKCustomer.UserControl
{
    public partial class ThumbnailContainer : DevExpress.XtraEditors.XtraUserControl
    {
        public ThumbnailContainer()
        {
            InitializeComponent();
        
            _thumbnails.Add(uscThumbnail6);
            _thumbnails.Add(uscThumbnail5);
            _thumbnails.Add(uscThumbnail4);
            _thumbnails.Add(uscThumbnail3);
            _thumbnails.Add(uscThumbnail2);
            _thumbnails.Add(uscThumbnail1);   

        }

    private List<Thumbnail> _thumbnails = new List<Thumbnail>();

        private void uscThumbnail6_ThumbnailClicked(object sender, Thumbnail.ThumbnailClickedEventArgs e)
        {
            MessageBox.Show("Test");
            Thumbnail thumbnail = sender as Thumbnail;

            //thumbnail.Acctivate();

            _thumbnails
               .FindAll(x => x != thumbnail);
              // .ForEach(x => x.Deactivate());

            OnProductSelected(e.Name);

        }
        #region ProductSelected event things for C# 3.0
        public event EventHandler<ProductSelectedEventArgs> ProductSelected;

        protected virtual void OnProductSelected(ProductSelectedEventArgs e)
        {
            if (ProductSelected != null)
                ProductSelected(this, e);
        }

        private ProductSelectedEventArgs OnProductSelected(string name)
        {
            ProductSelectedEventArgs args = new ProductSelectedEventArgs(name);
            OnProductSelected(args);

            return args;
        }

        private ProductSelectedEventArgs OnProductSelectedForOut()
        {
            ProductSelectedEventArgs args = new ProductSelectedEventArgs();
            OnProductSelected(args);

            return args;
        }

        public class ProductSelectedEventArgs : EventArgs
        {
            public string Name { get; set; }

            public ProductSelectedEventArgs()
            {
            }

            public ProductSelectedEventArgs(string name)
            {
                Name = name;
            }
        }
        #endregion

    }
}
