namespace MediatrStudying.Controllers.DItesting
{
    public interface ITemperature
    {
        public int TemperatureValue();
    }
    public class Temperature :ITemperature
    {
        private readonly IDItesting ?_ditesting;
        public Temperature(IDItesting ditesting)
        {
            _ditesting = ditesting;
        }
        public int TemperatureValue() 
        {
            Random rng = new Random();
            int rand1= rng.Next(20,40);
            return rand1; 
        }

    }
}
