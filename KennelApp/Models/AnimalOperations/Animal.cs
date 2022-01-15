using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Models
{
    class Animal : IAnimal
    {
        public Animal(string ownerName, string animalName, string animalType, bool status = false, bool washing = false, bool clipping = false)
        {
            Name = animalName;
            Owner = ownerName;
            Type = animalType;
            Status = status;
            Washing = washing;
            Clipping = clipping;
        }

        public string Name { get; set; }
        public string Owner { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; }

        public bool Washing { get; set; }
        public bool Clipping { get; set; }

    }
}
