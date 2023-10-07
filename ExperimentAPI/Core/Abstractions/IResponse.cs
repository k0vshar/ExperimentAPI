namespace ExperimentAPI.Core.Abstractions
{
    public interface IResponse<T>
    {
        bool Status { get; set; }
        string Message { get; set; }
        T Data { get; set; }
    }
}
