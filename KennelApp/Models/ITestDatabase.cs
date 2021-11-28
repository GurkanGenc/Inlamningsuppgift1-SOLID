using System.Collections.Generic;

namespace KennelApp.Models
{
    public interface ITestDatabase
    {
        List<ICustomer> customers { get; }
    }
}