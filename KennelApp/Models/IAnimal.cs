namespace KennelApp.Models
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Owner { get; set; }
        string Type { get; set; }
        bool Status { get; set; }

        bool Washing { get; set; }
        bool Clipping { get; set; }
    }
}