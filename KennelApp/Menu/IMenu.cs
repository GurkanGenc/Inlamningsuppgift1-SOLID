using System.Collections.Generic;

namespace KennelApp.Menu
{
    interface IMenu
    {
        List<IMenuItem> MenuItems { get; set; }
        string Title { get; set; }
    }
}