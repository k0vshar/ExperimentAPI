using ExperimentAPI.Core;
using ExperimentAPI.Core.Abstractions;
using ExperimentAPI.DAL.Interfaces;

namespace ExperimentAPI.DAL.Repositories
{
    public class ExperimentTypeRepository : IGenericRepository<ExperimentType>
    {
        readonly string _connectingString;

        public ExperimentTypeRepository(string connectingString)
        {
            _connectingString = connectingString;
        }

        public IResponse<ExperimentType> Add(string tableName, ExperimentType entity, int? foreginId = null)
        {
            throw new NotImplementedException();
        }

        public IResponse<ExperimentType> Get(string tableName, int id)
        {
            throw new NotImplementedException();
        }

        public IResponse<List<ExperimentType>> GetAll(string tableName)
        {
            throw new NotImplementedException();
        }
    }
}
