using System.Collections.Generic;

namespace KennelApp.Models
{
    public interface IKennelOperations
    {
        void Checkin(List<IAnimal> animals);
    }
}