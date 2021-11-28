namespace KennelApp.Models
{
    interface IReceipt
    {
        int Price { get; }
        int WashingPrice { get; }
        int ClippingPrice { get; }
        int TotalPrice { get; }
    }
}