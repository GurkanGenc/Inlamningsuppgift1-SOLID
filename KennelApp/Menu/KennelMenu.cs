using KennelApp.Models;
using System;
using System.Collections.Generic;

namespace KennelApp.Menu
{
    class KennelMenu : IKennelMenu
    {
        private IMenuManager MenuManager;

        public KennelMenu(IMenuManager menuManager)
        {
            MenuManager = menuManager;
        }
        public void Init()
        {
            // Creates the menu
            MenuManager.CreateMenu("Paradise Dog Hotel.\n(Press x to exit.)");
            MenuManager.CreateMenuItem(1, "Register a new customer", RegisterCustomer.AddCustomer);
            MenuManager.CreateMenuItem(2, "Register a new dog", RegisterDog.AddDog);
            MenuManager.CreateMenuItem(3, "Show customers", RegisterCustomer.CustomerList);
            MenuManager.CreateMenuItem(4, "Show dogs", RegisterDog.ListDogs);

            MenuManager.CreateMenuItem(5, "Checked-in dog", RegisterCustomer.CustomerList);
            MenuManager.CreateMenuItem(6, "Checked-out dog", RegisterCustomer.CustomerList);
            MenuManager.CreateMenuItem(7, "Extra Services", RegisterCustomer.CustomerList);
            MenuManager.CreateMenuItem(8, "Show receipt", RegisterCustomer.CustomerList);
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
