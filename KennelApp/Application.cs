using KennelApp.Menu;
using KennelApp.Models;
using System;
using System.Collections.Generic;

namespace KennelApp
{
    public class Application : IApplication
    {
        private IKennelMenu kennelMenu;

        public Application(IKennelMenu kennelMenu)
        {
            this.kennelMenu = kennelMenu;
        }

        public void Run()
        {
            RegisterCustomer.CustomerDatabase();
            RegisterDog.DogDatabase();

            // Create Menu and Show It
            kennelMenu.Init();

            // Ask user for input and run the choice
            kennelMenu.UserChoice();
        }
    }
}