namespace ExperimentAPI.Response
{
    public class ExperimentResponse
    {
        public string Value { get; set; }

        public string Key { get; set; }

        public ExperimentResponse(string value, string key)
        {
            Value = value;
            Key = key;
        }

        public ExperimentResponse()
        {
            
        }
    }
}
