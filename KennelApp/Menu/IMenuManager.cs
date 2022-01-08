using KennelApp.Models;
using System;
using System.Collections.Generic;

namespace KennelApp.Menu
{
    interface IMenuManager
    {
        void CreateMenu(string title);
        void CreateMenuItem(int selector, string name, Action runThis);
        IMenu GetMenu();
        void ShowMenu();
    }
}