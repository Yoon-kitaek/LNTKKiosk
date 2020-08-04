﻿using DevExpress.XtraScheduler;
using LNTKCustomer.Form;
using LNTKKiosk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKCustomer
{
    public class OrderInfo
    {

        #region singleton
        private OrderInfo()
        { 
        }

        private static OrderInfo _instance = null;

        public static OrderInfo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OrderInfo();

                return _instance;
            }
        }
        #endregion
        public bool IsTakeOut { get; set; }
        public int OrderId { get; set; }
        public List<ShoppedItem> shoppedItemList { get; set; }
        public List<Recipe> changedRecipe { get; set; }
    }
}
