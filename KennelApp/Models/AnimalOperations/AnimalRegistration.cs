using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Models
{
    public class AnimalRegistration : IAnimalRegistration
    {
        private static readonly List<IAnimal> Animals = new();

        public static void AnimalDatabase()
        {
            Animals.Add(new Animal ("Towe", "Steffie","Dog", true, false, false));
            Animals.Add(new Animal ("Sara", "Sniff", "Dog", false, false, false));
        }

        public static void AddAnimal(string ownerName, string animalName, string animalType)
        {
            Animals.Add(new Animal(ownerName, animalName, animalType, false, false, false));
        }
        public void AddAnimal()
        {
            Console.WriteLine("To register a new animal\nEnter the animal's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the owner's name: ");
            string owner = Console.ReadLine();
            Console.WriteLine("Enter the animal type: ");
            string type = Console.ReadLine();

            if (name != "" && owner != "" && type != "")
            {
                AddAnimal(owner, name, type);
                CustomerRegistration.AddCustomer(owner, name, type);
                Console.WriteLine($"{name} has been registered!");
            }
            else
                Console.WriteLine("Enter valid inputs!");
        }

        public void AnimalList()
        {
            foreach (var animal in Animals)
            {
                if (animal.Status == false)
                    Console.WriteLine($"Animal's name: {animal.Name} | Owner: {animal.Owner} | Type: {animal.Type} | Status: NOT checked-in");
                else if (animal.Status == true && animal.Washing == true && animal.Clipping == false)
                    Console.WriteLine($"Animal's name: {animal.Name} | Owner: {animal.Owner} | Type: {animal.Type} | Status: Checked-in | Washing Service: Yes");
                else if (animal.Status == true && animal.Clipping == true && animal.Washing == false)
                    Console.WriteLine($"Animal's name: {animal.Name} | Owner: {animal.Owner} | Type: {animal.Type} | Status: Checked-in | Clipping Service: Yes");
                else if (animal.Status == true && animal.Washing == true && animal.Clipping == true)
                    Console.WriteLine($"Animal's name: {animal.Name} | Owner: {animal.Owner} | Type: {animal.Type} | Status: Checked-in | Washing Service: Yes | Clipping Service: Yes");
                else if (animal.Status)
                    Console.WriteLine($"Animal's name: {animal.Name} | Owner: {animal.Owner} | Type: {animal.Type} | Status: Checked-in");
            }
        }

        // Checks-in animal.
        public void Checkin()
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
                    Console.WriteLine($"{animal.Name} has been Checked-in!: {dateTime.ToShortDateString()}");
                }
                else if (animalToCheckin != animal.Name.ToLower())
                {
                    Console.WriteLine("Animal is not found!");
                }
            }
        }

        public void Checkout()
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
                    Console.WriteLine($"{animal.Name} has been Checked-out!: {dateTime.ToShortDateString()}");
                    ShowReceipt(animalToCheckout.ToLower());
                }
                else if (animalToCheckout != animal.Name.ToLower())
                {
                    Console.WriteLine("Animal is not found!");
                }
            }
        }

        public void AddWashingService()
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

        public void AddClippingService()
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

        public void ShowReceipt(string animalName)
        {
            Receipt receipt = new();

            foreach (var animal in Animals.Where(x => x.Status == false))
            {
                if (animalName.ToLower() == animal.Name.ToLower())
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
                        Console.WriteLine("\nStaying: " + receipt.Price + " SEK");
                }
                else
                    Console.WriteLine("Animal is not found!");
            }
        }
    }
}
