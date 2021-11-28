using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Models
{
    class Dog : IDog
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public bool Status { get; set; }

        public bool Washing { get; set; }

        public bool Clipping { get; set; }

    }
}
