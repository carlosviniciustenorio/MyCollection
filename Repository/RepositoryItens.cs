﻿using MyCollection.Context;
using MyCollection.Models;
using System.Linq;

namespace MyCollection.Repository
{
    public class RepositoryItens : Repository<Itens>
    {
        public RepositoryItens(ContextCT context)
            : base(context)
        {}

    }
}