using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Models
{
    class Customer : ICustomer
    {
        public string Name { get; set; }
        public string OwnerOf { get; set; }
        public string AnimalType { get; set; }
    }
}
