﻿using System;
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
using LNTKKiosk.Data;

namespace LNTKCustomer.Form
{
    public partial class CardPayment : DevExpress.XtraEditors.XtraForm
    {
        public CardPayment()
        {
            InitializeComponent();
        }

        private void CardPayment_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            EndPage endPage = new EndPage();      
            endPage.Show(); 
            Close();  
        }
    }
}