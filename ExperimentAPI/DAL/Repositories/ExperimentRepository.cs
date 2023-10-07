using ExperimentAPI.Core;
using ExperimentAPI.Core.Abstractions;
using ExperimentAPI.DAL.Interfaces;

namespace ExperimentAPI.DAL.Repositories
{
    public class ExperimentRepository : IGenericRepository<Experiment>
    {
        readonly string _connectingString;

        public ExperimentRepository(string connectingString)
        {
            _connectingString = connectingString;
        }

        public IResponse<Experiment> Add(string tableName, Experiment entity, int? foreginId = null)
        {
            throw new NotImplementedException();
        }

        public IResponse<Experiment> Get(string tableName, int id)
        {
            throw new NotImplementedException();
        }

        public IResponse<List<Experiment>> GetAll(string tableName)
        {
            throw new NotImplementedException();
        }
    }
}
