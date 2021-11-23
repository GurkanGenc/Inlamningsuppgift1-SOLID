using System;

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