namespace Students.Service;
using Students.Model;
public class CourseService:IBase<Course>
{
   List<Course> courses = new List<Course>();
   int id = 1;
   public List<Course> GetAll() => courses;
   public Response<Course> Add(Course entt)
   {
      entt.SetCourseId(id);
      courses.Add(entt);
      id++;
      return new Response<Course>("Успешно добавилос курса");
   }
   public Response<Course> GetById(int id)
   {
      var course = courses.FirstOrDefault(x => x.GetCourseId() == id);
      if (course != null) return new Response<Course>("Вот и нашёл", course);
      return new Response<Course>("Такого информация нету в базе");
   }
   public Response<Course> Remove(int id)
   {
      var course = courses.FirstOrDefault(x => x.GetCourseId() == id);
      if (course != null)
      {
         courses.Remove(course);
         return new Response<Course>("Успешно удалено");
      }
      return new Response<Course>("Такого информация нету в базе");
   }
   public Response<Course> Update(Course entt)
   {
      var course = courses.FirstOrDefault(x => x.GetCourseId() == id);
      if (course != null)
      {
         course.SetCourseName(entt.GetCourseName());
         return new Response<Course>("Успешно изменено",course);
      }
      return new Response<Course>("Такого информация нету в базе");
   }
}
