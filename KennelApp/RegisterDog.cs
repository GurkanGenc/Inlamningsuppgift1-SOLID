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
            Animals.Add(new Dog { Name = "Bilbo", Owner = "Bojan", Status = true, Washing = false, Clipping = false });
            Animals.Add(new Dog { Name = "Steffie", Owner = "Bosse", Status = false, Washing = false, Clipping = false });
        }

        public static void AddDog()
        {
            IAnimal Dog = new Dog();
            Console.WriteLine("Enter the dog's name: ");
            Dog.Name = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the owner's name: ");
            Dog.Owner = Console.ReadLine().ToLower();

            if (Dog.Name != "" && Dog.Owner != "")
            {
                Animals.Add(Dog);
                Console.WriteLine("Dog has been registered!");
            }
            else
                Console.WriteLine("Enter valid inputs!");
        }

        internal static void ListDogs()
        {
            foreach (var dog in Animals)
            {
                if (dog.Status == false)
                    Console.WriteLine("Dog's name: " + dog.Name + " | Owner: " + dog.Owner + " | Status: NOT checked-in");
                else if (dog.Status == true && dog.Washing == true && dog.Clipping == false)
                    Console.WriteLine("Dog's name: " + dog.Name + " | Owner: " + dog.Owner + " | Status: Checked-in | Washing Service: Yes");
                else if (dog.Status == true && dog.Clipping == true && dog.Washing == false)
                    Console.WriteLine("Dog's name: " + dog.Name + " | Owner: " + dog.Owner + " | Status: Checked-in | Clipping Service: Yes");
                else if (dog.Status == true && dog. Washing== true && dog.Clipping == true)
                    Console.WriteLine("Dog's name: " + dog.Name + " | Owner: " + dog.Owner + " | Status: Checked-in | Washing Service: Yes | Clipping Service: Yes");
                else if (dog.Status)
                    Console.WriteLine("Dog's name: " + dog.Name + " | Owner: " + dog.Owner + " | Status: Checked-in");
            }
        }

        // Checks-in dog.
        public static void Checkin()
        {
            Console.WriteLine("Available Animals for checking-in:");
            foreach (var dog in Animals)
            {
                if (!dog.Status)
                    Console.WriteLine(dog.Name);
            }

            DateTime dateTime = DateTime.Now;
            Console.WriteLine("\nEnter the dog's name to check-in: ");
            var animalToCheckin = Console.ReadLine().ToLower();
            
            foreach (var dog in Animals.Where(x => x.Status == false))
            {
                if (animalToCheckin == dog.Name.ToLower())
                {
                    dog.Status = true;
                    Console.WriteLine("Dog has been Checked-in!: " + dateTime.ToShortDateString());
                }
                else if (animalToCheckin != dog.Name.ToLower())
                {
                    Console.WriteLine("Animal is not found!");
                }
            }
            //foreach (var dog in Animals.Where(x => x.Status == true))
            //{
            //    if (dog.Status && animalToCheckin == dog.Name.ToLower())
            //    {
            //        Console.WriteLine("The animal is already checked-in!");
            //    }
            //}
        }

        public static void Checkout()
        {
            Console.WriteLine("Available Animals for checking-out:");
            foreach (var dog in Animals)
            {
                if (dog.Status)
                    Console.WriteLine(dog.Name);
            }

            DateTime dateTime = DateTime.Now;
            Console.WriteLine("\nEnter the dog's name to check-out: ");
            var animalToCheckout = Console.ReadLine().ToLower();

            foreach (var dog in Animals.Where(x => x.Status == true))
            {
                if (animalToCheckout == dog.Name.ToLower())
                {
                    dog.Status = false;
                    Console.WriteLine("Dog has been Checked-out!: " + dateTime.ToShortDateString());
                }
                else if (animalToCheckout != dog.Name.ToLower())
                {
                    Console.WriteLine("Animal is not found!");
                }
            }            
        }

        public static void AddWashingService()
        {
            Console.WriteLine("Avaiable Animals for washing:");
            foreach (var dog in Animals.Where(x => x.Status == true))
            {
                if (!dog.Washing)
                    Console.WriteLine(dog.Name);
                else
                    Console.WriteLine("No available animal found!");
            }
           
            Console.WriteLine("\nEnter the dog's name: ");
            var animalToWash = Console.ReadLine().ToLower();

            foreach (var dog in Animals.Where(x => x.Status == true))
            {
                if (dog.Washing && animalToWash == dog.Name.ToLower())
                    Console.WriteLine("Animal already got this service!");
                else if (animalToWash == dog.Name.ToLower())
                {
                    dog.Washing = true;
                    Console.WriteLine("Washing service has been added! 100:-");
                }
                else if (animalToWash != dog.Name.ToLower() || animalToWash == "")
                    Console.WriteLine("Animal is not found!");
            }
        }

        public static void AddClippingService()
        {
            Console.WriteLine("Avaiable Animals for clipping:");
            foreach (var dog in Animals.Where(x => x.Status == true))
            {
                if (!dog.Clipping)
                    Console.WriteLine(dog.Name);
                else
                    Console.WriteLine("No available animal found!");
            }

            Console.WriteLine("\nEnter the dog's name: ");
            var animalToClip = Console.ReadLine().ToLower();

            foreach (var dog in Animals.Where(x => x.Status == true))
            {
                if (dog.Clipping && animalToClip == dog.Name.ToLower())
                    Console.WriteLine("Animal already got this service!");
                else if (animalToClip == dog.Name.ToLower())
                {
                    dog.Clipping = true;
                    Console.WriteLine("Clipping service has been added! 50:-");
                }
                else if (animalToClip != dog.Name.ToLower() || animalToClip == "")
                    Console.WriteLine("Animal is not found!");
            }
        }

        public static void ShowReceipt()
        {
            Receipt receipt = new();

            Console.WriteLine("Available Animals to see the receipt:");
            foreach (var dog in Animals)
            {
                if (dog.Status)
                    Console.WriteLine(dog.Name);
            }

            Console.WriteLine("\nEnter the dog's name: ");
            var dogToReceiptName = Console.ReadLine().ToLower();

            foreach (var dog in Animals.Where(x => x.Status == true))
            {
                if (dogToReceiptName == dog.Name.ToLower())
                {
                    if (dog.Washing && dog.Clipping == false)
                        Console.WriteLine($"\nStaying: {receipt.Price} SEK\nWashing: {receipt.WashingPrice} SEK\n--------------------\nTotal price: {receipt.Price + receipt.WashingPrice} SEK");
                    else if (dog.Clipping && dog.Washing == false)
                        Console.WriteLine($"\nStaying: {receipt.Price} SEK\nClipping: {receipt.ClippingPrice} SEK\n--------------------\nTotal price: {receipt.Price + receipt.ClippingPrice} SEK");
                    else if (dog.Washing && dog.Clipping)
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
