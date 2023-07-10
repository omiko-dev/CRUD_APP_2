namespace nika_2.Models
{
    public class ShelvesRepository : IShelvesRepository
    {

        private List<Shelves> _Shelves;

        public ShelvesRepository()
        {
            _Shelves = new List<Shelves>()
            {
                new Shelves() { Id=1, Name="name_1", Location="location_1", Capacity=100 },
                new Shelves() { Id=2, Name="name_2", Location="location_2", Capacity=400 },
                new Shelves() { Id=3, Name="name_3", Location="location_3", Capacity=900 },
            };
        }

        public Shelves Delete(int id)
        {
            var _shelves = _Shelves.Find(x => x.Id == id);

            _Shelves.Remove(_shelves);

            return _shelves;
        }

        public IEnumerable<Shelves> GetAllShelves()
        {
            return _Shelves;
        }

        public Shelves SetShelves()
        {
            Shelves newShelves = new Shelves();

            newShelves.Id = _Shelves.Count + 1;

            _Shelves.Add(newShelves);

            return newShelves;
        }

        public IEnumerable<Shelves> UpdateShelves(int id, Shelves newShelves)
        {
            var _shelves = _Shelves.FirstOrDefault(S => S.Id == id);

            if (_shelves == null)
                return null;

            _shelves.Name = newShelves.Name;
            _shelves.Location = newShelves.Location;
            _shelves.Capacity = newShelves.Capacity;

            return _Shelves;
        }
    }
}
