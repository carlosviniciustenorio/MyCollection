using Microsoft.EntityFrameworkCore;
using MyCollection.Context;
using MyCollection.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyCollection.Repository
{
    public class RepositoryUser : Repository<User>
    {
        public RepositoryUser(ContextCT context)
            : base(context)
        {}


    }
}