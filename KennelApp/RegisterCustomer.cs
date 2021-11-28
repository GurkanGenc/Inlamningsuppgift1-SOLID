using KennelApp.Models;
using System;
using System.Collections.Generic;

namespace KennelApp
{
    class RegisterCustomer // Instead of ThingsToDo class
    {
        public static List<ICustomer> Customers = new List<ICustomer>();

        //public RegisterCustomer(ICustomer customer)
        //{
        //    Customer = customer;
        //}

        public static void AddCustomer()
        {
            ICustomer Customer = new Customer();
            Console.WriteLine("Enter the name: ");
            Customer.Name = Console.ReadLine();

            Customers.Add(Customer);

            Console.WriteLine("Customer created ");
        }

        internal static void ListCustomers()
        {
            //Console.WriteLine($"Customer: {Customers}");

            foreach (var customer in Customers)
            {
                Console.WriteLine("Customer's name: " + customer.Name);
            }
        }
    }
}
