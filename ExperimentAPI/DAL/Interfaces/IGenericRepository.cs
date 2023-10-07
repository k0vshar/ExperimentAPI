namespace ExperimentAPI.DAL.Interfaces
{
    public interface IGenericRepository<T>
    {
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
        T Read(T entity);
    }
}
