using Domein.Models;
namespace Infrascrtion.Services;
public class CourseService : IBaseService<Course>
{
   List<Course> Courses = new List<Course>();
   public Response<Course> Add(Course entt)
   {
      var courses = Courses.ToList();
      int id = 0;
      if (courses.Count() != 0) id = courses.LastOrDefault().Id;
      id++;
      entt.Id = id;
      Courses.Add(entt);
      return new Response<Course>("Курс успешно добавлени");
   }
   public List<Course> GetAll() => Courses.ToList();
   public Response<Course> GetById(int id)
   {
      var course = Courses.FirstOrDefault(x => x.Id == id);
      if (course != null) return new Response<Course>("Курс найден  ", course);
      return new Response<Course>("Курс не найден");
   }
   public Response<Course> Remove(int id)
   {
      var course = Courses.FirstOrDefault(x => x.Id == id);
      if (course != null)
      {
         Courses.Remove(course);
         return new Response<Course>("Успешно удалено");
      }
      return new Response<Course>("Курс не найден");
   }
   public Response<Course> Update(Course entt)
   {
      var course = Courses.FirstOrDefault(x => x.Id == entt.Id);
      if(course != null){
         course.Name=entt.Name;
         return new Response<Course>("Успешно изменил даннии");
      }
      return new Response<Course>("Курс не найдено");
   }

}
