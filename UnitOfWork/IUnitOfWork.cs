namespace MyCollection.UnitOfWork
{
    public interface IUnitOfWork
    {
        Repository.RepositoryUser UserRepository { get; }
        void Save();
    }
}