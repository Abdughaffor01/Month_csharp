using Softclub.Model;
using Softclub.Service.Generic;
namespace Softclub.Service;
public class DepartmentService : IBaseService<Department>
{
    List<Department> Departments = new List<Department>();
    int id = 1;
    public async Task<Response<Department>> Add(Department c)
    {
        return await Task.Run(() =>
        {
            c.Id = id++;
            Departments.Add(c);
            return new Response<Department>("Отдел добавлено");
        });
    }
    public async Task<List<Department>> GetAll() { return await Task.FromResult(Departments.ToList()); }
    public async Task<Response<Department>> GetById(int id)
    {
        return await Task.Run(() =>
        {
            var departments = Departments.FirstOrDefault(x => x.Id == id);
            if (departments != null) return new Response<Department>("Отдел найден", departments);
            return new Response<Department>("Отдел не найден");
        });
    }
    public async Task<Response<Department>> Remove(int id)
    {
        return await Task.Run(() =>
        {
            var departments = Departments.FirstOrDefault(x => x.Id == id);
            if (departments != null)
            {
                Departments.Remove(departments);
                return new Response<Department>("Отдел удалено");
            }
            return new Response<Department>("Отдел не найден");
        });
    }
    public async Task<Response<Department>> Update(Department c)
    {
        return await Task.Run(() =>
        {
            var departments = Departments.FirstOrDefault(x => x.Id == c.Id);
            if (departments != null)
            {
                departments.Name = c.Name;
                departments.EducationCenterId = c.EducationCenterId;
                return new Response<Department>("Отдел изменено");
            }
            return new Response<Department>("Отдел не найден");
        });
    }
}
