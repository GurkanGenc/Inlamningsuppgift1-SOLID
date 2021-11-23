using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Menu
{
    class MenuManager : IMenuManager
    {
        private IMenu Menu;
        // AutoFac has this "factory" function
        private Func<int, string, Action, IMenuItem> MenuItemFactory;

        // In the "Func": int is Selector, string is Name, Action is the method that we have in the constructor.
        public MenuManager(IMenu menu, Func<int, string, Action, IMenuItem> menuItemFactory)
        {
            Menu = menu;
            MenuItemFactory = menuItemFactory;
        }

        public void CreateMenu(string title)
        {
            Menu.Title = title;
            Menu.MenuItems = new(); // Creates List<IMenuItem>
        }

        public void CreateMenuItem(int selector, string name, Action runThis)
        {
            Menu.MenuItems.Add(MenuItemFactory(selector, name, runThis));
        }

        public void ShowMenu()
        {
            Console.WriteLine(Menu.Title);

            foreach (var menuItem in Menu.MenuItems)
            {
                Console.WriteLine(menuItem.Selector + ": " + menuItem.Name);
            }
        }

        public IMenu GetMenu()
        {
            return Menu;
        }
    }
}
