using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public partial class OrderDetail
    {
        public int ProductPrice { get; set; }

        public DateTime OrderTime { get; set; }

        public string ProductName { get; set; }

        public string CategoryName { get; set; }

    }
}
