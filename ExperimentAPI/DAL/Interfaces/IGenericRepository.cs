using ExperimentAPI.Core.Abstractions;

namespace ExperimentAPI.DAL.Interfaces
{
    public interface IGenericRepository<T>
    {
        IResponse<T> Add(string tableName, T entity, int? foreginId = null);

        IResponse<T> Get(string tableName, int id);

        IResponse<List<T>> GetAll(string tableName);
    }
}
