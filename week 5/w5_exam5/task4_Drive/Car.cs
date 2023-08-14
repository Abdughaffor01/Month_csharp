
namespace task4_Drive
{
    public class Car : IVehicle
    {
        bool klch=false;
        public int Speed { get; set;}
        public Car(int speed)=>Speed = speed;
        public string Drive() => $"Driving at {Speed} mph";
        public bool IsRunning() => klch;

        public string Start()
        {
            klch = true;
            return $"Starting car engine";
        }

        public string Stop()
        {
            klch = false;
            return $"Stopping car engine";
        }
    }
}
