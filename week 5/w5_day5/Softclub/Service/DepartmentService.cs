using Softclub.Model;
using Softclub.Service.Generic;
namespace Softclub.Service;
public class DepartmentService : IBaseService<Department>{
    List<Department> Departments = new List<Department>();
    int id = 1;
    public Response<Department> Add(Department c){
        c.Id = id++;
        Departments.Add(c);
        return new Response<Department>("Отдел добавлено");
    }
    public List<Department> GetAll() => Departments;
    public Response<Department> GetById(int id){
        var departments = Departments.FirstOrDefault(x => x.Id == id);
        if (departments != null) return new Response<Department>("Отдел найден", departments);
        return new Response<Department>("Отдел не найден");
    }
    public Response<Department> Remove(int id){
        var departments = Departments.FirstOrDefault(x => x.Id == id);
        if (departments != null){
            Departments.Remove(departments);
            return new Response<Department>("Отдел удалено");
        }return new Response<Department>("Отдел не найден");
    }
    public Response<Department> Update(Department c){
        var departments = Departments.FirstOrDefault(x => x.Id == c.Id);
        if (departments != null){
            departments.Name= c.Name;
            departments.EducationCenterId = c.EducationCenterId;
            return new Response<Department>("Отдел изменено");
        }return new Response<Department>("Отдел не найден");
    }
}
