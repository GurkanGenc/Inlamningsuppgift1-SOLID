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
            Customers.Add(new Customer { Name = "Bosse", OwnerOf = "Steffie"} );
            Customers.Add(new Customer { Name = "Bojan", OwnerOf = "Bilbo" });
        }

        public static void AddCustomer()
        {
            ICustomer Customer = new Customer();
            Console.WriteLine("Enter the customer's name: ");
            Customer.Name = Console.ReadLine();
            Console.WriteLine("Enter the dog's name: ");
            Customer.OwnerOf = Console.ReadLine();

            Customers.Add(Customer);

            Console.WriteLine("Customer has been registered!");
        }

        internal static void CustomerList()
        {
            foreach (var customer in Customers)
            {
                Console.WriteLine("Customer's name: " + customer.Name + " | Owner of: " + customer.OwnerOf);
            }
        }

        
    }
}
