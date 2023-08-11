using Technology.Model;
namespace Technology.Services;
public class PhoneService : IService<Phone>
{
   List<Phone> phones = new List<Phone>();
   int id = 1;
   public Response<Phone> Add(Phone entt)
   {
      entt.ID = id;
      phones.Add(entt);
      return new Response<Phone>("Успешно добавилос информация");
   }
   public List<Phone> GetAll() => phones;
   public Response<Phone> GetById(int id)
   {
      var phone = phones.FirstOrDefault(x => x.ID == id);
      if (phone != null) return new Response<Phone>("Вот и нашёл", phone);
      return new Response<Phone>("Такого информация нету в базе");
   }
   public Response<Phone> Remove(int id)
   {
      var phone = phones.FirstOrDefault(x => x.ID == id);
      if (phone != null)
      {
         phones.Remove(phone);
         return new Response<Phone>("Успешно удалено");
      }
      return new Response<Phone>("Такого информация нету в базе");
   }

   public Response<Phone> Update(Phone entt)
   {
      var phone = phones.FirstOrDefault(x => x.ID == entt.ID);
      if (phone != null)
      {
         phone.Name = entt.Name;
         phone.OZU = entt.OZU;
         phone.CPU = entt.CPU;
         phone.Displey= entt.Displey;
         phone.GPU= entt.GPU;
         phone.NumCamera=entt.NumCamera;
         phone.PixCamera= entt.PixCamera;
         return new Response<Phone>("Успешно изменено");
      }
      return new Response<Phone>("Такого информация нету в базе");
   }

}
