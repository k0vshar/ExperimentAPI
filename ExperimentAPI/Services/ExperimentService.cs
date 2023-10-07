using ExperimentAPI.Interfaces;
using ExperimentAPI.Response;
namespace ExperimentAPI.Services
{
    public class ExperimentService : IService
    {
        private string[] _colors = { "#FF0000", "#00FF00", "#0000FF" };
        private string RandColors()
        {
            var random = new Random();

            return _colors[random.Next(_colors.Length)];
        }

        public string GetColors()
        {
            ExperimentResponse color = new ExperimentResponse(RandColors(), "test");
            color.Value = RandColors();
            color.Key = "test";

            return color.Value;
        }
    }
}
