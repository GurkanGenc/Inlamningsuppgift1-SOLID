namespace KennelApp.Models
{
    interface IDog
    {
        string Name { get; set; }
        string Owner { get; set; }
        bool Status { get; set; }

        bool Washing { get; set; }

        bool Clipping { get; set; }
    }
}