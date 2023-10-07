using System.ComponentModel.DataAnnotations;

namespace ExperimentAPI.Core.Abstractions
{
    abstract public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
