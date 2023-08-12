namespace Softclub.Service.Generic;

public interface IBaseService<T>
{
   List<T> GetAll();
   Response<T> GetById(int id);
   Response<T> Add(T c);
   Response<T> Remove(int id);
   Response<T> Update(T c);
}
