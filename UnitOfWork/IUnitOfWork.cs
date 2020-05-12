namespace MyCollection.UnitOfWork
{
    public interface IUnitOfWork
    {
        Repository.RepositoryUser UserRepository { get; }
        Repository.RepositoryItens ItensRepository { get; }
        Repository.RepositoryVinculo VinculoRepository { get; }

        void Save();
    }
}