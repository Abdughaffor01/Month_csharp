using Softclub.Model;
using Softclub.Service.Generic;
namespace Softclub.Service
{
    public class EmployeeService : IBaseService<Employee>{
        List<Employee> employees=new List<Employee>();
        int id = 1;
        public Response<Employee> Add(Employee c){
            c.Id = id++;
            employees.Add(c);
            return new Response<Employee>("Работник успешно добавлен");
        }
        public List<Employee> GetAll()=>employees.ToList();
        public Response<Employee> GetById(int id){
            var employee = employees.FirstOrDefault(x=>x.Id==id);
            if (employee != null) return new Response<Employee>("Работник найден",employee);
            return new Response<Employee>("Работник не найден");
        }
        public Response<Employee> Remove(int id){
            var employee = employees.FirstOrDefault(x => x.Id == id);
            if (employee != null) { 
                employees.Remove(employee);
                return new Response<Employee>("Работник удалено");
            }return new Response<Employee>("Работник не найден");
        }
        public Response<Employee> Update(Employee c){
            var employee = employees.FirstOrDefault(x => x.Id == id);
            if (employee != null){
                employees.Remove(employee);
                return new Response<Employee>("Работник удалено");
            } return new Response<Employee>("Работник не найден");
        }
    }
}
