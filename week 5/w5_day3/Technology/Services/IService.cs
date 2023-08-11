namespace Technology.Services;
public interface IService<T>
{
   List<T> GetAll();
   Response<T> GetById(int id);
   Response<T> Add(T entt);
   Response<T> Update(T entt);
   Response<T> Remove(int id);
}
