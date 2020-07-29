﻿using LNTKKiosk.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTKManager
{
    public partial class KeyPad : Form
    {
        public KeyPad()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (tbxResult.Text == "0")
                tbxResult.Clear();

            DevExpress.XtraEditors.SimpleButton button = (DevExpress.XtraEditors.SimpleButton)sender;
            tbxResult.Text = tbxResult.Text + button.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbxResult.Text = "0";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            Order order = DataRepository.Order.Get(int.Parse(tbxResult.Text));

            if (order == null)
            {
                MessageBox.Show("없는 주문번호입니다.");
                tbxResult.Text = "";
                return;
            }

            if (order.IsCompleted != false)
            {
                tbxResult.Text = "";
                return;
            }

            order.IsCompleted = true;

            DataRepository.Order.Update(order);

            bdsNonCompletedOrderDetail.DataSource = DataRepository.OrderDetail.GetwithNonCompletedOrderDetail();
            bdsCompletedOrderDetail.DataSource = DataRepository.OrderDetail.GetwithCompletedOrderDetail();

            tbxResult.Text = "";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            //
        }

        private void KeyPad_Load(object sender, EventArgs e)
        {
            bdsNonCompletedOrderDetail.DataSource = DataRepository.OrderDetail.GetwithNonCompletedOrderDetail();
            bdsCompletedOrderDetail.DataSource = DataRepository.OrderDetail.GetwithCompletedOrderDetail();
            
        }
    }
}
