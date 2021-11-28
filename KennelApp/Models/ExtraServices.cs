using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Models
{
    class ExtraServices : IExtraServices
    {
        public string Washing { get; set; }
        public string Clipping { get; set; }
        public string Cost { get; set; }
    }
}
