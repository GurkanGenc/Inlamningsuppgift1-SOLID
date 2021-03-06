using KennelApp.Menu;
using KennelApp.Models;
using System;
using System.Collections.Generic;

namespace KennelApp
{
    public class Application : IApplication
    {
        private readonly IKennelMenu kennelMenu;

        public Application(IKennelMenu kennelMenu)
        {
            this.kennelMenu = kennelMenu;
        }

        public void Run()
        {
            CustomerRegistration.CustomerDatabase();
            AnimalRegistration.AnimalDatabase();

            // Create Menu and Show It
            kennelMenu.Init();

            // Ask user for input and run the choice
            kennelMenu.UserChoice();
        }
    }
}