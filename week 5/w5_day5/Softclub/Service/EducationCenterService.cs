using Softclub.Model;
using Softclub.Service.Generic;
namespace Softclub.Service;
public class EducationCenterService : IBaseService<EducationCenter>{
   List<EducationCenter> EducationCenter = new List<EducationCenter>();
   int id = 1;
   public Response<EducationCenter> Add(EducationCenter c){
        var cours = EducationCenter.FirstOrDefault(x => x.Name.ToLower().Trim() == c.Name.ToLower().Trim());
        if (cours == null){
            c.Id = id++;
            EducationCenter.Add(c);
            return new Response<EducationCenter>("Образовательный центр добавлено");
        }else return new Response<EducationCenter>("Такого образовательный центр уже есть");
    }
   public List<EducationCenter> GetAll() => EducationCenter;
   public Response<EducationCenter> GetById(int id){
      var educationcenter = EducationCenter.FirstOrDefault(x => x.Id == id);
      if (educationcenter != null) return new Response<EducationCenter>("Образовательный центр :", educationcenter);
      return new Response<EducationCenter>("Образовательный центр нету в базу");
   }
   public Response<EducationCenter> Remove(int id){
      var educationcenter = EducationCenter.FirstOrDefault(x => x.Id == id);
      if (educationcenter != null){
         EducationCenter.Remove(educationcenter);
         return new Response<EducationCenter>("Образовательный центр успешно удалено");
      }return new Response<EducationCenter>("Нету такого Образовательный центр");
   }
   public Response<EducationCenter> Update(EducationCenter c){
      var educationcenter = EducationCenter.FirstOrDefault(x => x.Id ==c.Id);
      if (educationcenter != null){
         educationcenter.Name=c.Name;
         educationcenter.Departments=c.Departments;
         return new Response<EducationCenter>("Образовательный центр изменено");
      }return new Response<EducationCenter>("Нету такого Образовательный центр");
   }
}
