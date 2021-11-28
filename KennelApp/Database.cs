using KennelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp
{
    class Database
    {
        public static List<ICustomer> Customers = new List<ICustomer>();
        //public static List<Animal> Animals { get; set; }
        //public static List<Assignment> Assignments { get; set; }

        public static void KennelDatabase()
        {
            Customers.Add(new Customer() { Name = "Bosse" });
        }
    }
}
