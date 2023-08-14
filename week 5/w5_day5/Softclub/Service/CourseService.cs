using Softclub.Model;
using Softclub.Service.Generic;

namespace Softclub.Service
{
    public class CourseService : IBaseService<Course>
    {
        List<Course> courses = new List<Course>();
        int id = 1;
        public async Task<Response<Course>> Add(Course c)
        {
            return await Task.Run(() =>
            {
                var cours = courses.FirstOrDefault(x => x.CourseName.ToLower().Trim() == c.CourseName.ToLower().Trim());
                if (cours == null)
                {
                    c.Id = id++;
                    courses.Add(c);
                    return new Response<Course>("Курс добавлено");
                }
                else return new Response<Course>("Такого курс уже есть");
            });
        }
        public async Task<List<Course>> GetAll() { return await Task.FromResult(courses.ToList()); }
        public async Task<Response<Course>> GetById(int id)
        {
            return await Task.Run(() =>
            {
                var course = courses.FirstOrDefault(x => x.Id == id);
                if (course != null) return new Response<Course>("Курс найден", course);
                return new Response<Course>("Курс не найден");
            });
        }
        public async Task<Response<Course>> Remove(int id)
        {
            return await Task.Run(() =>
            {
                var course = courses.FirstOrDefault(x => x.Id == id);
                if (course != null)
                {
                    courses.Remove(course);
                    return new Response<Course>("Успешно курс удалено");
                }
                return new Response<Course>("Не найдено курс");
            });
        }
        public async Task<Response<Course>> Update(Course c)
        {
            return await Task.Run(() =>
            {
                var course = courses.FirstOrDefault(x => x.Id == id);
                if (course != null)
                {
                    courses.Remove(course);
                    return new Response<Course>("Успешно курс удалено");
                }
                return new Response<Course>("Не найдено курс");
            });
        }
    }
}
