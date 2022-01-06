using KennelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KennelApp
{
    class RegisterDog
    {
        public static List<IDog> Dogs = new();

        public static void DogDatabase()
        {
            Dogs.Add(new Dog { Name = "Bilbo", Owner = "Bojan", Status = false, Washing = false, Clipping = false });
            Dogs.Add(new Dog { Name = "Steffie", Owner = "Bosse", Status = false, Washing = false, Clipping = false });
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
                    Console.WriteLine("Dog's name: " + dog.Name + " | Owner: " + dog.Owner + " | Status: NOT checked-in | Washing Service: " + dog.Washing + " | Clipping Service: " + dog.Clipping);
                else
                    Console.WriteLine("Dog's name: " + dog.Name + " | Owner: " + dog.Owner + " | Status: Checked-in | Washing Service: " + dog.Washing + " | Clipping Service: " + dog.Clipping);
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

        public static void AddWashingService()
        {
            Console.WriteLine("Enter the dog's name: ");
            var animalToWash = Console.ReadLine();

            foreach (var dog in Dogs)
            {
                if (animalToWash == dog.Name)
                    dog.Washing = true;
            }

            Console.WriteLine("Service has been added!");
        }

        public static void AddClippingService()
        {
            Console.WriteLine("Enter the dog's name: ");
            var animalToClip = Console.ReadLine();

            foreach (var dog in Dogs)
            {
                if (animalToClip == dog.Name)
                    dog.Clipping = true;
            }

            Console.WriteLine("Service has been added!");
        }

        public static void ShowReceipt()
        {
            Receipt receipt = new();

            Console.WriteLine("Enter the dog's name: ");
            var dogToReceiptName = Console.ReadLine();

            foreach (var dog in Dogs)
            {
                if (dogToReceiptName == dog.Name)
                {
                    if (dog.Washing)
                        Console.WriteLine(receipt.Price + receipt.WashingPrice + " SEK");
                    else if (dog.Clipping)
                        Console.WriteLine(receipt.Price + receipt.ClippingPrice + " SEK");
                    else if (dog.Washing && dog.Clipping)
                        Console.WriteLine(receipt.TotalPrice + " SEK");
                    else
                        Console.WriteLine(receipt.Price + " SEK");
                }
            }
        }
    }
}
