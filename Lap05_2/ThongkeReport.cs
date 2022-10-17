using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap05_2
{
    internal class ThongkeReport
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public float SellPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime OrderDate { get; set; }
        public double Total { set; get; }
        public DateTime DeliveryDate { get; set; }
        public int Index { get; internal set; }
    }
}
