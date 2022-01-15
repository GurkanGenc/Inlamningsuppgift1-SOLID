using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Models
{
    interface IAnimalRegistration
    {
        void AddAnimal();
        void AnimalList();
        void Checkin();
        void Checkout();
        void AddWashingService();
        void AddClippingService();
        void ShowReceipt(string animalName);
    }
}
