using System;
using System.Collections.Generic;
using System.Linq;

namespace KennelApp.Models
{
    public class AnimalOperations : IAnimalOperations
    {
        public void Checkin(IList<IAnimal> animals)
        {
            Console.WriteLine("Available Animals for checking-in:");
            foreach (var animal in animals)
            {
                if (!animal.Status)
                    Console.WriteLine(animal.Name);
            }

            DateTime dateTime = DateTime.Now;
            Console.WriteLine("\nEnter the animal's name to check-in: ");
            var animalToCheckin = Console.ReadLine().ToLower();

            foreach (var animal in animals.Where(x => x.Status == false))
            {
                if (animalToCheckin == animal.Name.ToLower())
                {
                    animal.Status = true;
                    Console.WriteLine($"{animal.Name} has been Checked-in!: {dateTime.ToShortDateString()}");
                    break;
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
    }
}
