using ExperimentAPI.Core;
using ExperimentAPI.Core.Abstractions;
using ExperimentAPI.DAL.Interfaces;

namespace ExperimentAPI.DAL.Repositories
{
    public class ExperimentValueRepository : IGenericRepository<ExperimentValue>
    {
        readonly string _connectingString;

        public ExperimentValueRepository(string connectingString)
        {
            _connectingString = connectingString;
        }

        public IResponse<ExperimentValue> Add(string tableName, ExperimentValue entity, int? foreginId = null)
        {
            throw new NotImplementedException();
        }

        public IResponse<ExperimentValue> Get(string tableName, int id)
        {
            throw new NotImplementedException();
        }

        public IResponse<List<ExperimentValue>> GetAll(string tableName)
        {
            throw new NotImplementedException();
        }
    }
}
