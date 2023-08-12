using Softclub.Model;
using Softclub.Service.Generic;

namespace Softclub.Service
{
    public class CourseService : IBaseService<Course>{
        List<Course> courses=new List<Course>();
        int id = 1;
        public Response<Course> Add(Course c){
            var cours = courses.FirstOrDefault(x=>x.CourseName.ToLower().Trim()==c.CourseName.ToLower().Trim());
            if (cours == null){
                c.Id = id++;
                courses.Add(c);
                return new Response<Course>("Курс добавлено");
            }else return new Response<Course>("Такого курс уже есть");
        }
        public List<Course> GetAll() => courses;
        public Response<Course> GetById(int id) {
            var course = courses.FirstOrDefault(x=>x.Id==id);
            if (course != null) return new Response<Course>("Курс найден", course);
            return new Response<Course>("Курс не найден");
        }
        public Response<Course> Remove(int id){
            var course = courses.FirstOrDefault(x => x.Id == id);
            if (course != null) {
                courses.Remove(course);
                return new Response<Course>("Успешно курс удалено");
            }return new Response<Course> ("Не найдено курс");
        }
        public Response<Course> Update(Course c){
            var course = courses.FirstOrDefault(x => x.Id == id);
            if (course != null){
                courses.Remove(course);
                return new Response<Course>("Успешно курс удалено");
            } return new Response<Course>("Не найдено курс");
        }
    }
}
