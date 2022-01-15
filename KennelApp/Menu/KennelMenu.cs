using KennelApp.Models;
using System;
using System.Collections.Generic;

namespace KennelApp.Menu
{
    class KennelMenu : IKennelMenu
    {
        private readonly IMenuManager MenuManager;
        private readonly IAnimalRegistration AnimalRegistration;
        private readonly ICustomerRegistration CustomerRegistration;

        public KennelMenu(IMenuManager menuManager, IAnimalRegistration animalRegistration, ICustomerRegistration customerRegistration)
        {
            MenuManager = menuManager;
            AnimalRegistration = animalRegistration;
            CustomerRegistration = customerRegistration;
        }
        public void Init()
        {
            // Creates the menu
            MenuManager.CreateMenu("Paradise Animal Hotel.\n(Press x to exit.)\n");
            MenuManager.CreateMenuItem(1, "Register a new customer", CustomerRegistration.AddCustomer);
            MenuManager.CreateMenuItem(2, "Register a new animal", AnimalRegistration.AddAnimal);
            MenuManager.CreateMenuItem(3, "Show customers", CustomerRegistration.CustomerList);
            MenuManager.CreateMenuItem(4, "Show animals", AnimalRegistration.AnimalList);
            MenuManager.CreateMenuItem(5, "Checked-in animal", AnimalRegistration.Checkin);
            MenuManager.CreateMenuItem(6, "Checked-out animal", AnimalRegistration.Checkout);
            MenuManager.CreateMenuItem(7, "Washing", AnimalRegistration.AddWashingService);
            MenuManager.CreateMenuItem(8, "Clipping", AnimalRegistration.AddClippingService);
            MenuManager.ShowMenu();
        }

        public void UserChoice()
        {
            while (true)
            {
                var userInput = Console.ReadKey(true);

                foreach (var menuItem in MenuManager.GetMenu().MenuItems)
                {
                    if (menuItem.Selector.ToString() == userInput.KeyChar.ToString())
                    {
                        Console.Clear();
                        MenuManager.ShowMenu();
                        menuItem.RunThis();
                    }
                    else if (userInput.KeyChar == 'x')
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
