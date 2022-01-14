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
            Customers.Add(new Customer("Towe", "Steffie", "Dog"));
            Customers.Add(new Customer("Sara", "Sniff","Dog"));
        }

        public static void AddCustomer(string name, string ownerOf, string animalType)
        {
            Customers.Add(new Customer(name, ownerOf, animalType));
        }

        public static void AddCustomer()
        {
            Console.WriteLine("To register a new customer\nEnter the customer's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the animal's name: ");
            string ownerOf = Console.ReadLine();
            Console.WriteLine("Enter the animal type: ");
            string animalType = Console.ReadLine();

            if (name != "" && ownerOf != "" && animalType != "")
            {
                AddCustomer(name, ownerOf, animalType);
                AnimalRegistration.AddAnimal(name, ownerOf, animalType);
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
