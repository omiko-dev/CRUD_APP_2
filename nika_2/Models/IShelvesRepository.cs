using System.Diagnostics.Eventing.Reader;

namespace nika_2.Models
{
    public interface IShelvesRepository
    {

        public IEnumerable<Shelves> GetAllShelves();

        public Shelves Delete(int id);

        public Shelves SetShelves();

        public IEnumerable<Shelves> UpdateShelves(int id, Shelves newShelves);


    }
}
