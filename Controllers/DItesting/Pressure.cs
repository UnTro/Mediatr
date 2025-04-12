namespace MediatrStudying.Controllers.DItesting
{   public interface IPressure
    {
        public int PressureValue();
    }
    public class Pressure : IPressure
    {
        //IPressure pressure;
       
        //public Pressure(IPressure pressure)
        //{
        //    this.pressure = pressure;
        //}
        public int PressureValue() 
        {
            Random rng = new Random();
            int rand1 = rng.Next(650, 750);
            return rand1;
        }
    }
}
