using Technology.Enum;
using Technology.Iclass;
namespace Technology.Model;
public class Phone : Technology,ITechnology
{
   public TypeSensor MyProperty { get; set; }
   public int NumCamera { get; set; }
   public int PixCamera { get; set; }
   public string GetInFo() => $"Type={TypeTechnologyy}[Model={Name}, Ram={OZU}, Storage={Storage},Displey={Displey},NumCamera={NumCamera}, PixCamera={PixCamera} ]";
   public void SetRam(int ram)=>OZU=ram;
   public void SetStorage(int storage)=>Storage=storage;

}
