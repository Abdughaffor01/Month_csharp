namespace task4_Drive
{
    public class Motorcycle:IVehicle
    {
        bool klch = false;
        public int Speed { get; set; }
        public Motorcycle(int speed) => Speed = speed;
        public string Drive() => $"Driving at {Speed} mph";
        public bool IsRunning() => klch;

        public string Start()
        {
            klch = true;
            return $"Starting motorcycle engine";
        }

        public string Stop()
        {
            klch = false;
            return $"Stopping motorcycle engine";
        }
    }
}
