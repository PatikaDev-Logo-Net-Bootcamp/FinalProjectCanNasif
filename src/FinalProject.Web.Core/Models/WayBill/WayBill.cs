using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.WayBill
{
    internal class WayBill
    {
        public long Id  { get; set; }

        public double WayBillPrice  { get; set; }

        public DateTime WayBillPayTime  { get; set; }

        public double WayBillPayedPrice     { get; set; }
    }
}
