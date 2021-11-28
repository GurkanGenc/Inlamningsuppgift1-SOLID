namespace KennelApp.Models
{
    public interface ICustomer
    {
        string Name { get; set; }
        string OwnerOf { get; set; }
    }
}