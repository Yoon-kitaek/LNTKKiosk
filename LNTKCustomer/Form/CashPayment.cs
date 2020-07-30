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
using LNTKKiosk.Data;

namespace LNTKCustomer.Form
{
    public partial class CashPayment : DevExpress.XtraEditors.XtraForm
    {
        List<ShoppedItem> shoppedItemList = new List<ShoppedItem>();
        public CashPayment(List<ShoppedItem> shoppedItemList )
        {
            InitializeComponent();
            this.shoppedItemList = shoppedItemList;
        }
    }
}