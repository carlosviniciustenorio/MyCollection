using MyCollection.Context;
using MyCollection.Models;
using System.Data.Entity;
using System.Linq;

namespace MyCollection.Repository
{
    public class RepositoryItens : Repository<Itens>
    {
        public RepositoryItens(ContextCT context)
            : base(context)
        {}

        public Itens BuscarComInclud(int id)
        {
            return _context.Item.Include(x => x.Vinculo).FirstOrDefault();
        }

    }
}