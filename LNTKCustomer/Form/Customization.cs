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
using DevExpress.Utils.Extensions;
using DevExpress.XtraWaitForm;

namespace LNTKCustomer.Form
{
    public partial class Customization : DevExpress.XtraEditors.XtraForm
    {
        string name;
        public Customization(string packageName)
        {
            InitializeComponent();
            name = packageName;         
        }

        private void Customization_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
          
            if (name.Contains("세트") == false)
            {
                sbtNext.Visible = false;
                uscBeverageSelection.Visible = false;
                uscSideSelection.Visible = false;
                
                MessageBox.Show($"{uscBeverageSelection.Visible},{uscSideSelection.Visible},{sbtNext.Visible}");

            }

        }

        private void sbtBeverageCustomization_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Payment form = new Payment();
            form.Show();
        }

       
    }
}