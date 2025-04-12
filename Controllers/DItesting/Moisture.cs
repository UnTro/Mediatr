namespace MediatrStudying.Controllers.DItesting
{
    public interface IMoisture
    {
         float MoistureContent();
    }
    public class Moisture:IMoisture
    {
        float moist;
        public float MoistureContent() 
        {
            Random rng = new Random();
            int rand1 = rng.Next(0, 100);
            return rand1;
        }
        public class MyClass { }

    }
}
