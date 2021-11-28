using KennelApp.Models;
using System;
using System.Collections.Generic;

namespace KennelApp
{
    class RegisterDog
    {
        public static List<IDog> Dogs = new List<IDog>();

        public static void DogDatabase()
        {
            Dogs.Add(new Dog { Name = "Bilbo", Owner = "Bojan", Status = false, ExtraService = "None" });
            Dogs.Add(new Dog { Name = "Steffie", Owner = "Bosse", Status = false, ExtraService = "None" });
        }

        public static void AddDog()
        {
            IDog Dog = new Dog();
            Console.WriteLine("Enter the dog's name: ");
            Dog.Name = Console.ReadLine();
            Console.WriteLine("Enter the owner's name: ");
            Dog.Owner = Console.ReadLine();

            Dogs.Add(Dog);

            Console.WriteLine("Dog has been registered!");
        }

        internal static void ListDogs()
        {
            foreach (var dog in Dogs)
            {
                if (dog.Status == false)
                    Console.WriteLine("Dog's name: " + dog.Name + " | Owner: " + dog.Owner + " | Status: NOT checked-in");
                else
                    Console.WriteLine("Dog's name: " + dog.Name + " | Owner: " + dog.Owner + " | Status: Checked-in");
            }
        }


        // Checks-in dog.
        public static void Checkin()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Enter the dog's name: ");
            var animalToCheckin = Console.ReadLine();

            foreach (var dog in Dogs)
            {
                if (animalToCheckin == dog.Name)
                    dog.Status = true;
            }

            Console.WriteLine("Dog has been Checked-in!: " + dateTime.ToShortDateString());
        }

        public static void Checkout()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Enter the dog's name: ");
            var animalToCheckout = Console.ReadLine();

            foreach (var dog in Dogs)
            {
                if (animalToCheckout == dog.Name)
                    dog.Status = false;
            }

            Console.WriteLine("Dog has been Checked-out!: " + dateTime.ToShortDateString());
        }

        public static void AddExtraService()
        {
            Console.WriteLine("Enter the service name: ");
            var serviceName = Console.ReadLine();

            

            Console.WriteLine("Dog has been registered!");
        }
    }
}
