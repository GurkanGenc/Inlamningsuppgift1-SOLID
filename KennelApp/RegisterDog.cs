using KennelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KennelApp
{
    class RegisterDog
    {
        public static List<IAnimal> Dogs = new();
        private static List<IAnimal> CheckedInAnimals = new();

        public static void DogDatabase()
        {
            Dogs.Add(new Dog { Name = "Bilbo", Owner = "Bojan", Status = true, Washing = false, Clipping = false });
            Dogs.Add(new Dog { Name = "Steffie", Owner = "Bosse", Status = false, Washing = false, Clipping = false });
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
                Dogs.Add(Dog);
                Console.WriteLine("Dog has been registered!");
            }
            else
                Console.WriteLine("Enter valid inputs!");
        }

        internal static void ListDogs()
        {
            foreach (var dog in Dogs)
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
            Console.WriteLine("Avaiable dogs for checking-in:");
            foreach (var dog in Dogs)
            {
                if (!dog.Status)
                    Console.WriteLine(dog.Name);
            }

            DateTime dateTime = DateTime.Now;
            Console.WriteLine("\nEnter the dog's name to check-in: ");
            var animalToCheckin = Console.ReadLine().ToLower();
            
            
            foreach (var dog in Dogs)
            {
                if (animalToCheckin == dog.Name.ToLower())
                {
                    dog.Status = true;
                    CheckedInAnimals.Add(dog);

                    Console.WriteLine("Dog has been Checked-in!: " + dateTime.ToShortDateString());
                }
                else if (animalToCheckin.ToLower() != dog.Name.ToLower())
                {
                    Console.WriteLine("Animal is not found!");
                }
                else // Does not work
                {
                    Console.WriteLine("The animal is already checked-in!");
                }
            }
        }

        public static void Checkout()
        {
            Console.WriteLine("Avaiable dogs for checking-out:\n" + Dogs.FirstOrDefault(x => x.Status == true).Name);
            foreach (var checkedInDog in CheckedInAnimals)
            {
                if (checkedInDog.Status)
                    Console.WriteLine(checkedInDog.Name);
                else
                    Console.WriteLine("No avaiable animal found!");
            }

            DateTime dateTime = DateTime.Now;
            Console.WriteLine("\nEnter the dog's name to check-out: ");
            var animalToCheckout = Console.ReadLine().ToLower();

            foreach (var dog in Dogs)
            {
                if (animalToCheckout.ToLower() == dog.Name.ToLower())
                {
                    dog.Status = false;
                }
            }

            Console.WriteLine("Dog has been Checked-out!: " + dateTime.ToShortDateString());
        }

        public static void AddWashingService()
        {
            Console.WriteLine("Avaiable dogs for washing:");
            foreach (var dog in Dogs.Where(x => x.Status == true))
            {
                if (!dog.Washing)
                    Console.WriteLine(dog.Name);
                else
                    Console.WriteLine("No avaiable animal found!");
            }
           
            Console.WriteLine("\nEnter the dog's name: ");
            var animalToWash = Console.ReadLine().ToLower();

            foreach (var dog in Dogs)
            {
                if (dog.Washing)
                    Console.WriteLine("Animal already got this service!");
                else if (animalToWash == dog.Name.ToLower())
                {
                    dog.Washing = true;
                    Console.WriteLine("Washing service has been added! 100:-");
                }
            }
        }

        public static void AddClippingService()
        {
            Console.WriteLine("Avaiable dogs for clipping:");
            foreach (var dog in Dogs.Where(x => x.Status == true))
            {
                if (!dog.Clipping)
                    Console.WriteLine(dog.Name);
                else
                    Console.WriteLine("No avaiable animal found!");
            }

            Console.WriteLine("\nEnter the dog's name: ");
            var animalToClip = Console.ReadLine().ToLower();

            foreach (var dog in Dogs)
            {
                if (dog.Clipping)
                    Console.WriteLine("Animal already got this service!");
                else if (animalToClip == dog.Name.ToLower())
                {
                    dog.Clipping = true;
                    Console.WriteLine("Clipping service has been added! 50:-");
                }
            }
        }

        public static void ShowReceipt()
        {
            Receipt receipt = new();

            Console.WriteLine("Enter the dog's name: ");
            var dogToReceiptName = Console.ReadLine().ToLower();

            foreach (var dog in Dogs)
            {
                if (dogToReceiptName == dog.Name.ToLower())
                {
                    if (dog.Washing && dog.Clipping == false)
                        Console.WriteLine(receipt.Price + receipt.WashingPrice + " SEK");
                    else if (dog.Clipping && dog.Washing == false)
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
