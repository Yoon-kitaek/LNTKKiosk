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

namespace LNTKCustomer.Form
{
    public partial class SideOrBeverageCustomization : DevExpress.XtraEditors.XtraForm
    {
        int categoryId;
        public int selectedProductId { get; set; }
        public SideOrBeverageCustomization(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;
            selectedProductId = -1;
        }

        private void SideOrBeverageCustomization_Load(object sender, EventArgs e)
        {
            uscThumbnailContainer.categoryId = categoryId;
        }
    }
}