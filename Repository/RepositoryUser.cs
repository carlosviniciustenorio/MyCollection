﻿using MyCollection.Context;
using MyCollection.Models;

namespace MyCollection.Repository
{
    public class RepositoryUser : Repository<User>
    {
        public RepositoryUser(ContextCT context)
            : base(context)
        {}


    }
}