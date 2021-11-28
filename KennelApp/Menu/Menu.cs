using System.Collections.Generic;

namespace KennelApp.Menu
{
    class Menu : IMenu
    {
        public string Title { get; set; }
        public List<IMenuItem> MenuItems { get; set; }
    }
}
