using KennelApp.Models;
using System;
using System.Collections.Generic;

namespace KennelApp
{
    public class RegisterCustomer
    {
        private static List<ICustomer> Customers = new();

        public static void CustomerDatabase()
        {
            Customers.Add(new Customer { Name = "Bosse", OwnerOf = "Steffie"} );
            Customers.Add(new Customer { Name = "Bojan", OwnerOf = "Bilbo" });
        }

        public static void AddCustomer()
        {
            ICustomer Customer = new Customer();
            Console.WriteLine("To register a new customer\nEnter the customer's name: ");
            Customer.Name = Console.ReadLine();
            Console.WriteLine("Enter the dog's name: ");
            Customer.OwnerOf = Console.ReadLine();

            if (Customer.Name != "" && Customer.OwnerOf != "")
            {
                Customers.Add(Customer);
                Console.WriteLine("Customer has been registered!");
            }
            else
                Console.WriteLine("Enter valid inputs!");
            
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
