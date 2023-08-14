namespace Softclub.Service.Generic;

public interface IBaseService<T>
{
    Task<List<T>> GetAll();
    Task<Response<T>> GetById(int id);
    Task<Response<T>> Add(T c);
    Task<Response<T>> Remove(int id);
    Task<Response<T>> Update(T c);
}
