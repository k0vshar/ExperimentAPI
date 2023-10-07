using ExperimentAPI.Core.Abstractions;

namespace ExperimentAPI.Core
{
    public class Response<T> : IResponse<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; } = string.Empty;
        public T Data { get; set; }
    }
}
