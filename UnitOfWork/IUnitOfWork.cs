namespace MyCollection.UnitOfWork
{
    public interface IUnitOfWork
    {
        Repository.RepositoryUser UserRepository { get; }
        Repository.RepositoryItens ItensRepository { get; }
        void Save();
    }
}