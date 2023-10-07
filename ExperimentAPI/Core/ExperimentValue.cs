using ExperimentAPI.Core.Abstractions;

namespace ExperimentAPI.Core
{
    public class ExperimentValue : BaseEntity
    {
        public string Value { get; set; } = string.Empty;

        public decimal Chance { get; set; } = 0m;

        public ExperimentType ExperimentType { get; set; }
    }
}
