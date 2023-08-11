using Technology.Model;
namespace Technology.Services;
public class LaptopService : IService<Laptop>
{
   List<Laptop> laptops = new List<Laptop>();
   int id = 1;
   public Response<Laptop> Add(Laptop entt)
   {
      entt.ID = id;
      laptops.Add(entt);
      id++;
      return new Response<Laptop>("Успешно добавилос информация");
   }
   public List<Laptop> GetAll() => laptops;
   public Response<Laptop> GetById(int id)
   {
      var laptop = laptops.FirstOrDefault(x => x.ID == id);
      if (laptop != null) return new Response<Laptop>("Вот и нашёл", laptop);
      return new Response<Laptop>("Такого информация нету в базе");
   }
   public Response<Laptop> Remove(int id)
   {
      var laptop = laptops.FirstOrDefault(x => x.ID == id);
      if (laptop != null)
      {
         laptops.Remove(laptop);
         return new Response<Laptop>("Успешно удалено");
      }
      return new Response<Laptop>("Такого информация нету в базе");
   }

   public Response<Laptop> Update(Laptop entt)
   {
      var laptop = laptops.FirstOrDefault(x => x.ID == entt.ID);
      if (laptop != null)
      {
         laptop.Name = entt.Name;
         laptop.OZU = entt.OZU;
         laptop.CPU = entt.CPU;
         laptop.Displey= entt.Displey;
         laptop.GPU= entt.GPU;
         laptop.SensorControl= entt.SensorControl;
         laptop.TypeKeyboard= entt.TypeKeyboard;
         return new Response<Laptop>("Успешно изменено");
      }
      return new Response<Laptop>("Такого информация нету в базе");
   }

}
