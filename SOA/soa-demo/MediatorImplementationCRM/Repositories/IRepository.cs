namespace MediatorImplementationCRM.Repositories
{
    public interface IRepository<T>
    {
        public T Create(T element);
    }
}