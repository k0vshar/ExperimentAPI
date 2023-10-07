using ExperimentAPI.Core.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace ExperimentAPI.Core
{
    public class Experiment : BaseEntity
    {
        [Key]
        public int ExperimentTypeId { get; set; }

        public string DeviceToken { get; set; } = string.Empty;

        public string Value { get; set; } = string.Empty;

        public ExperimentType ExperimentType { get; set; }
    }
}
