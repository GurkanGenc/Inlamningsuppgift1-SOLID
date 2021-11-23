using System;

namespace KennelApp.Menu
{
    interface IMenuItem
    {
        string Name { get; set; }
        Action RunThis { get; set; }
        int Selector { get; set; }
    }
}