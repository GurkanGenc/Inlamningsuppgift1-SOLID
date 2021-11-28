using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Models
{
    class Receipt : IReceipt
    {
        public int Price { get { return 120; } }
        public int WashingPrice { get { return 100; } }
        public int ClippingPrice { get { return 50; } }
        public int TotalPrice { get { return 270; } }
    }
}
