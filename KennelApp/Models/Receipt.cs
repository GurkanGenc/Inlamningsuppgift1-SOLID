using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Models
{
    class Receipt : IReceipt
    {
        public string Price { get { return "120SEK"; } }
        public string ExtraPrice { get; set; }
    }
}
