using KennelApp.Menu;
using KennelApp.Models;
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
            // Create Menu and Show It
            kennelMenu.Init();

            // Ask user for input and run the choice
            kennelMenu.UserChoice();
        }
    }
}