using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelApp.Menu
{
    class MenuItem : IMenuItem
    {
        // Assigna a key to the menu (1, 2, x, q, etc.)
        public int Selector { get; set; }

        // Lists the names (dogs, customers etc.)
        public string Name { get; set; }

        // The method to list the names
        public Action RunThis { get; set; }

        public MenuItem(int selector, string name, Action runThis)
        {
            Selector = selector;
            Name = name;
            RunThis = runThis;
        }
    }
}
