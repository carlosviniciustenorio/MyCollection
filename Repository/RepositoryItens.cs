using MyCollection.Context;
using MyCollection.Models;

namespace MyCollection.Repository
{
    public class RepositoryItens : Repository<Itens>
    {
        public RepositoryItens(ContextCT context)
            : base(context)
        {}


    }
}