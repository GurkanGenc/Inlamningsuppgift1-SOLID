using KennelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Models
{
    public class TestDatabase : ITestDatabase
    {
        public List<ICustomer> customers => throw new NotImplementedException();

        public List<ICustomer> PopulateDummyDataCustomer(List<ICustomer> customerList)
        {
            customerList.Add(new Customer { Name = "Bosse" });
            return customerList;
        }
    }
}
