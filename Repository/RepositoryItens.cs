using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MyCollection
{
    public class RepositoryItens : Repository<Itens>
    {
        public RepositoryItens(CollectionContext context)
            : base(context)
        {}

        public void add(Itens item)
        {
            _dbSet.Add(item);
        }

        public Itens find(long id)
        {
            return _dbSet.Include(x => x.Place).FirstOrDefault(y => y.Id == id);
        }
        
        public IEnumerable<RepositoryItens> GetAll()
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