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
            Dogs.Add(new Dog { Name = "Bilbo", Owner = "Bojan", Status = false });
            Dogs.Add(new Dog { Name = "Steffie", Owner = "Bosse", Status = false });
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
                Console.WriteLine("Dog's name: " + dog.Name + " | Owner: " + dog.Owner + " | Status: NOT checked-in");
            }
        }
    }
}
