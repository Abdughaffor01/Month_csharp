using Softclub.Model;
using Softclub.Service.Generic;
namespace Softclub.Service
{
    public class EmployeeService : IBaseService<Employee>
    {
        List<Employee> employees = new List<Employee>();
        int id = 1;
        public async Task<Response<Employee>> Add(Employee c)
        {
            return await Task.Run(() =>
            {
                c.Id = id++;
                employees.Add(c);
                return new Response<Employee>("Работник успешно добавлен");
            });
        }
        public async Task<List<Employee>> GetAll() { return await Task.FromResult(employees.ToList()); }
        public async Task<Response<Employee>> GetById(int id)
        {
            return await Task.Run(() =>
            {
                var employee = employees.FirstOrDefault(x => x.Id == id);
                if (employee != null) return new Response<Employee>("Работник найден", employee);
                return new Response<Employee>("Работник не найден");
            });
        }
        public async Task<Response<Employee>> Remove(int id)
        {
            return await Task.Run(() =>
            {
                var employee = employees.FirstOrDefault(x => x.Id == id);
                if (employee != null)
                {
                    employees.Remove(employee);
                    return new Response<Employee>("Работник удалено");
                }
                return new Response<Employee>("Работник не найден");
            });
        }
        public async Task<Response<Employee>> Update(Employee c)
        {
            return await Task.Run(() =>
            {
                var employee = employees.FirstOrDefault(x => x.Id == id);
                if (employee != null)
                {
                    employees.Remove(employee);
                    return new Response<Employee>("Работник удалено");
                }
                return new Response<Employee>("Работник не найден");
            });
        }
    }
}
