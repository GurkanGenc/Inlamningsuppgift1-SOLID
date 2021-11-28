namespace KennelApp.Models
{
    interface IReceipt
    {
        string ExtraPrice { get; set; }
        string Price { get; }
    }
}