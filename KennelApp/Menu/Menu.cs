using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Menu
{
    class Menu : IMenu
    {
        public string Title { get; set; }
        public List<IMenuItem> MenuItems { get; set; }
    }
}
