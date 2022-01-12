using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Models
{
    public class CustomerRegistration
    {
        private static readonly List<ICustomer> Customers = new();

        public static void CustomerDatabase()
        {
            Customers.Add(new Customer { Name = "Towe", OwnerOf = "Steffie", AnimalType = "Dog" });
            Customers.Add(new Customer { Name = "Sara", OwnerOf = "Sniff", AnimalType = "Dog" });
        }

        public static void AddCustomer()
        {
            ICustomer Customer = Factory.RegisterCustomer();
            Console.WriteLine("To register a new customer\nEnter the customer's name: ");
            Customer.Name = Console.ReadLine();
            Console.WriteLine("Enter the animal's name: ");
            Customer.OwnerOf = Console.ReadLine();
            Console.WriteLine("Enter the animal type: ");
            Customer.AnimalType = Console.ReadLine();

            if (Customer.Name != "" && Customer.OwnerOf != "" && Customer.AnimalType != "")
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
                Console.WriteLine($"Customer's name: {customer.Name} | Owner of: {customer.OwnerOf} | Animal Type: {customer.AnimalType}");
            }
        }
    }
}
