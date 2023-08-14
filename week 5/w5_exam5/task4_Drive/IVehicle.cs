namespace task4_Drive
{
    public interface IVehicle
    {
        int Speed { get; set; }
        string Start();
        string Drive();
        string Stop();
        bool IsRunning();
    }
}

