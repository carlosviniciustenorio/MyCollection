using MyCollection.Context;
using MyCollection.Models;

namespace MyCollection.Repository
{
    public class RepositoryVinculo : Repository<Vinculo>
    {
        public RepositoryVinculo(ContextCT context)
            : base(context)
        {}


    }
}