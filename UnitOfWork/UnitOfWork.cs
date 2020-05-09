using Microsoft.AspNetCore.Mvc;
using MyCollection.Context;
using MyCollection.Repository;
using System;

namespace MyCollection.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        Repository.RepositoryUser userRepository;
        Repository.RepositoryItens itensRepository;
        private ContextCT contextCt;

        public UnitOfWork([FromServices]ContextCT contextMy)
        {
            this.contextCt = contextMy;
        }

        public RepositoryUser UserRepository
        {
            get
            {
                return userRepository = userRepository ?? new RepositoryUser(this.contextCt);
            }
        }

        public RepositoryItens ItensRepository
        {
            get
            {
                return itensRepository = itensRepository ?? new RepositoryItens(this.contextCt);
            }
        }

        public void Save()
        {
            this.contextCt.SaveChanges();
        }
    }
}
