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
using System.Threading;


namespace LNTKCustomer.Form
{
    public partial class CardPayment : DevExpress.XtraEditors.XtraForm
    {
        public CardPayment()
        {
            InitializeComponent();

            EndPage form = new EndPage();
            form.Show();


        }


    }
}