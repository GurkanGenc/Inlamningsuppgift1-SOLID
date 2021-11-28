using KennelApp.Models;
using System;
using System.Collections.Generic;

namespace KennelApp
{
    public class RegisterCustomer
    {
        public static List<ICustomer> Customers = new List<ICustomer>();

        public static void CustomerDatabase()
        {
            Customers.Add(new Customer { Name = "Bosse"} );
            Customers.Add(new Customer { Name = "Bojan" });
        }

        public static void AddCustomer()
        {
            ICustomer Customer = new Customer();
            Console.WriteLine("Enter the name: ");
            Customer.Name = Console.ReadLine();

            Customers.Add(Customer);

            Console.WriteLine("Customer has been registered!");
        }

        internal static void CustomerList()
        {
            foreach (var customer in Customers)
            {
                Console.WriteLine("Customer's name: " + customer.Name);
            }
        }

        
    }
}
