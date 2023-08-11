namespace Students.Service;
using Students.Model;

public class SubjectService : IBase<Subject>
{
   List<Subject> subjects = new List<Subject>();
   int id = 1;
   public List<Subject> GetAll() => subjects;
   public Response<Subject> Add(Subject entt)
   {
      entt.SetCourseID(id);
      subjects.Add(entt);
      id++;
      return new Response<Subject>("Успешно добавилос предмет");
   }
   public Response<Subject> GetById(int id)
   {
      var subject = subjects.FirstOrDefault(x => x.GetCourseID() == id);
      if (subject != null) return new Response<Subject>("Вот и нашёл", subject);
      return new Response<Subject>("Такого информация нету в базе");
   }
   public Response<Subject> Remove(int id)
   {
      var subject = subjects.FirstOrDefault(x => x.GetCourseID() == id);
      if (subject != null)
      {
         subjects.Remove(subject);
         return new Response<Subject>("Успешно удалено");
      }
      return new Response<Subject>("Такого информация нету в базе");
   }
   public Response<Subject> Update(Subject entt)
   {
      var subject = subjects.FirstOrDefault(x => x.GetCourseID() == id);
      if (subject != null)
      {
         subject.SetSubjectName(entt.GetSubjectName());
         subject.SetNumberOfCredits(entt.GetNumberOfCredits());
         subject.SetCourseID(entt.GetCourseID());
         
         return new Response<Subject>("Успешно изменено",subject);
      }
      return new Response<Subject>("Такого информация нету в базе");
   }
}
