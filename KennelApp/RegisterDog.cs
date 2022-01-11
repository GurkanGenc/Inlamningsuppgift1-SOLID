using KennelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KennelApp
{
    class RegisterDog
    {
        public static List<IAnimal> Animals = new();

        public static void DogDatabase()
        {
            Animals.Add(new Animal { Name = "Bilbo", Owner = "Bojan", Status = true, Washing = false, Clipping = false });
            Animals.Add(new Animal { Name = "Steffie", Owner = "Bosse", Status = false, Washing = false, Clipping = false });
        }

        public static void AddAnimal()
        {
            IAnimal Animal = new Animal();
            Console.WriteLine("To register a new animal\nEnter the animal's name: ");
            Animal.Name = Console.ReadLine();
            Console.WriteLine("Enter the owner's name: ");
            Animal.Owner = Console.ReadLine();

            if (Animal.Name != "" && Animal.Owner != "")
            {
                Animals.Add(Animal);
                Console.WriteLine("Animal has been registered!");
            }
            else
                Console.WriteLine("Enter valid inputs!");
        }

        internal static void DogList()
        {
            foreach (var animal in Animals)
            {
                if (animal.Status == false)
                    Console.WriteLine("Animal's name: " + animal.Name + " | Owner: " + animal.Owner + " | Status: NOT checked-in");
                else if (animal.Status == true && animal.Washing == true && animal.Clipping == false)
                    Console.WriteLine("Animal's name: " + animal.Name + " | Owner: " + animal.Owner + " | Status: Checked-in | Washing Service: Yes");
                else if (animal.Status == true && animal.Clipping == true && animal.Washing == false)
                    Console.WriteLine("Animal's name: " + animal.Name + " | Owner: " + animal.Owner + " | Status: Checked-in | Clipping Service: Yes");
                else if (animal.Status == true && animal. Washing== true && animal.Clipping == true)
                    Console.WriteLine("Animal's name: " + animal.Name + " | Owner: " + animal.Owner + " | Status: Checked-in | Washing Service: Yes | Clipping Service: Yes");
                else if (animal.Status)
                    Console.WriteLine("Animal's name: " + animal.Name + " | Owner: " + animal.Owner + " | Status: Checked-in");
            }
        }

        // Checks-in animal.
        public static void Checkin()
        {
            Console.WriteLine("Available Animals for checking-in:");
            foreach (var animal in Animals)
            {
                if (!animal.Status)
                    Console.WriteLine(animal.Name);
            }

            DateTime dateTime = DateTime.Now;
            Console.WriteLine("\nEnter the animal's name to check-in: ");
            var animalToCheckin = Console.ReadLine().ToLower();
            
            foreach (var animal in Animals.Where(x => x.Status == false))
            {
                if (animalToCheckin == animal.Name.ToLower())
                {
                    animal.Status = true;
                    Console.WriteLine("Animal has been Checked-in!: " + dateTime.ToShortDateString());
                }
                else if (animalToCheckin != animal.Name.ToLower())
                {
                    Console.WriteLine("Animal is not found!");
                }
            }
            //foreach (var animal in Animals.Where(x => x.Status == true))
            //{
            //    if (animal.Status && animalToCheckin == animal.Name.ToLower())
            //    {
            //        Console.WriteLine("The animal is already checked-in!");
            //    }
            //}
        }

        public static void Checkout()
        {
            Console.WriteLine("Available Animals for checking-out:");
            foreach (var animal in Animals)
            {
                if (animal.Status)
                    Console.WriteLine(animal.Name);
            }

            DateTime dateTime = DateTime.Now;
            Console.WriteLine("\nEnter the animal's name to check-out: ");
            var animalToCheckout = Console.ReadLine().ToLower();

            foreach (var animal in Animals.Where(x => x.Status == true))
            {
                if (animalToCheckout == animal.Name.ToLower())
                {
                    animal.Status = false;
                    Console.WriteLine("Animal has been Checked-out!: " + dateTime.ToShortDateString());
                }
                else if (animalToCheckout != animal.Name.ToLower())
                {
                    Console.WriteLine("Animal is not found!");
                }
            }            
        }

        public static void AddWashingService()
        {
            Console.WriteLine("Avaiable Animals for washing:");
            foreach (var animal in Animals.Where(x => x.Status == true))
            {
                if (!animal.Washing)
                    Console.WriteLine(animal.Name);
                else
                    Console.WriteLine("No available animal found!");
            }
           
            Console.WriteLine("\nEnter the animal's name: ");
            var animalToWash = Console.ReadLine().ToLower();

            foreach (var animal in Animals.Where(x => x.Status == true))
            {
                if (animal.Washing && animalToWash == animal.Name.ToLower())
                    Console.WriteLine("Animal already got this service!");
                else if (animalToWash == animal.Name.ToLower())
                {
                    animal.Washing = true;
                    Console.WriteLine("Washing service has been added! 100:-");
                }
                else if (animalToWash != animal.Name.ToLower() || animalToWash == "")
                    Console.WriteLine("Animal is not found!");
            }
        }

        public static void AddClippingService()
        {
            Console.WriteLine("Avaiable Animals for clipping:");
            foreach (var animal in Animals.Where(x => x.Status == true))
            {
                if (!animal.Clipping)
                    Console.WriteLine(animal.Name);
                else
                    Console.WriteLine("No available animal found!");
            }

            Console.WriteLine("\nEnter the animal's name: ");
            var animalToClip = Console.ReadLine().ToLower();

            foreach (var animal in Animals.Where(x => x.Status == true))
            {
                if (animal.Clipping && animalToClip == animal.Name.ToLower())
                    Console.WriteLine("Animal already got this service!");
                else if (animalToClip == animal.Name.ToLower())
                {
                    animal.Clipping = true;
                    Console.WriteLine("Clipping service has been added! 50:-");
                }
                else if (animalToClip != animal.Name.ToLower() || animalToClip == "")
                    Console.WriteLine("Animal is not found!");
            }
        }

        public static void ShowReceipt()
        {
            Receipt receipt = new();

            Console.WriteLine("Available Animals to see the receipt:");
            foreach (var animal in Animals)
            {
                if (animal.Status)
                    Console.WriteLine(animal.Name);
            }

            Console.WriteLine("\nEnter the animal's name: ");
            var dogToReceiptName = Console.ReadLine().ToLower();

            foreach (var animal in Animals.Where(x => x.Status == true))
            {
                if (dogToReceiptName == animal.Name.ToLower())
                {
                    if (animal.Washing && animal.Clipping == false)
                        Console.WriteLine($"\nStaying: {receipt.Price} SEK\nWashing: {receipt.WashingPrice} SEK\n--------------------\nTotal price: {receipt.Price + receipt.WashingPrice} SEK");
                    else if (animal.Clipping && animal.Washing == false)
                        Console.WriteLine($"\nStaying: {receipt.Price} SEK\nClipping: {receipt.ClippingPrice} SEK\n--------------------\nTotal price: {receipt.Price + receipt.ClippingPrice} SEK");
                    else if (animal.Washing && animal.Clipping)
                        Console.WriteLine($"\nStaying: {receipt.Price} SEK\n" +
                            $"Washing: {receipt.WashingPrice} SEK\n" +
                            $"Clipping: {receipt.ClippingPrice} SEK\n" +
                            $"--------------------\n" +
                            $"Total price: {receipt.Price + receipt.WashingPrice + receipt.ClippingPrice} SEK");
                    else
                        Console.WriteLine("Staying: " + receipt.Price + " SEK");
                }
                else
                    Console.WriteLine("Animal is not found!");
            }
        }
    }
}
