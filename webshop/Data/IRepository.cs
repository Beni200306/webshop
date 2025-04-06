namespace webshop.Data
{
    public interface IRepository<T>
    {
        void Create(T entity);
        IEnumerable<T> Read();
        T Read(int id);
        void Delete(int id);
        IEnumerable<T> Filter (Predicate<T> condition);

    }
}
