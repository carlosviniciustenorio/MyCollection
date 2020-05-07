using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MyCollection
{
    public class RepositoryLocations : Repository<Locations>
    {
        public RepositoryLocations(CollectionContext context)
            : base(context)
        {}

        public void add(Locations place)
        {
            _dbSet.Add(place);
        }

        public Locations find(long id)
        {
            return _dbSet.Include(x => x.Place).FirstOrDefault(y => y.Id == id);
        }
        
        public IEnumerable<RepositoryLocations> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(long id)
        {
            //throw new System.NotImplementedException();
        }

        public void Update(RepositoryLocations location)
        {
            //throw new System.NotImplementedException();
        }
    }
}