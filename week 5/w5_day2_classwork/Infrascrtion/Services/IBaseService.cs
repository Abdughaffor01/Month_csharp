namespace Infrascrtion.Services;
using Domein.Models;
public interface IBaseService<T> where T : class
{
   List<T> GetAll();
   Response<T> GetById(int id);
   Response<T> Add(T entt);
   Response<T> Update(T entt);
   Response<T> Remove(int id);
}
