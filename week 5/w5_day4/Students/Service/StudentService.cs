using Students.Model;
namespace Students.Service;
public class StudentService : IBase<Student>
{
    List<Student> students = new List<Student>();
    int id = 1;
    public List<Student> GetAll() => students;
    public Response<Student> Add(Student entt)
    {
        entt.SetStudentId(id);
        students.Add(entt);
        id++;
        return new Response<Student>("Успешно добавилос студент");
    }
    public Response<Student> GetById(int id)
    {
        var student = students.FirstOrDefault(x => x.GetStudentId() == id);
        if (student != null) return new Response<Student>("Вот и нашёл", student);
        return new Response<Student>("Такого информация нету в базе");
    }
    public Response<Student> Remove(int id)
    {
        var student = students.FirstOrDefault(x => x.GetStudentId() == id);
        if (student != null)
        {
            students.Remove(student);
            return new Response<Student>("Успешно удалено");
        }
        return new Response<Student>("Такого информация нету в базе");
    }
    public Response<Student> Update(Student entt)
    {
        var student = students.FirstOrDefault(x => x.GetStudentId() == entt.GetStudentId());
        if (student != null)
        {
            student.SetFirstName(entt.getFirstName());
            student.SetLastName(entt.getLastName());
            student.SetCity(entt.GetCity());
            student.SetStreet(entt.GetStreet());
            student.SetEmail(entt.GetEmail());
            student.SetMobile(entt.GetMobile());
            return new Response<Student>("Успешно изменено");
        }
        return new Response<Student>("Такого информация нету в базе");
    }
}
