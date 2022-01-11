using KennelApp.Models;

namespace KennelApp
{
    public class Factory
    {
        public static ICustomer RegisterCustomer()
        {
            return new Customer();
        }

        public static IAnimal RegisterAnimal()
        {
            return new Animal();
        }
    }
}
