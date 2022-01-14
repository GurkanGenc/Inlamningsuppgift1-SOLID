using System.Collections.Generic;

namespace KennelApp.Models
{
    public interface IAnimalOperations
    {
        void Checkin(IList<IAnimal> animals);
    }
}