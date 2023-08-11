using Technology.Iclass;

namespace Technology.Model;

public class Laptop : Technology, ITechnology
{
    public bool SensorControl { get; set; } = false;
    public string TypeKeyboard { get; set; }

    public string GetInFo() =>$"Type={TypeTechnologyy}[Model={Name}, Ram={OZU}, Storage={Storage},Displey={Displey} ]";

    public void SetRam(int ram) => OZU = ram;

    public void SetStorage(int storage) => Storage = storage;
}
