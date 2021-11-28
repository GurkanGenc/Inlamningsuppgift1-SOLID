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
            Dogs.Add(new Dog { Name = "Bilbo" });
            Dogs.Add(new Dog { Name = "Steffie" });
        }

        public static void AddDog()
        {
            IDog Dog = new Dog();
            Console.WriteLine("Enter the name: ");
            Dog.Name = Console.ReadLine();

            Dogs.Add(Dog);

            Console.WriteLine("Dog has been registered!");
        }

        internal static void ListDogs()
        {
            foreach (var dog in Dogs)
            {
                Console.WriteLine("Dog's name: " + dog.Name);
            }
        }
    }
}
