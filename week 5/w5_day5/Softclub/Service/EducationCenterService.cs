using Softclub.Model;
using Softclub.Service.Generic;
namespace Softclub.Service;
public class EducationCenterService : IBaseService<EducationCenter>
{
    List<EducationCenter> EducationCenter = new List<EducationCenter>();
    int id = 1;
    public async Task<Response<EducationCenter>> Add(EducationCenter c)
    {
        return await Task.Run(() =>
        {
            var cours = EducationCenter.FirstOrDefault(x => x.Name.ToLower().Trim() == c.Name.ToLower().Trim());
            if (cours == null)
            {
                c.Id = id++;
                EducationCenter.Add(c);
                return new Response<EducationCenter>("Образовательный центр добавлено");
            }
            else return new Response<EducationCenter>("Такого образовательный центр уже есть");
        });
    }
    public async Task<List<EducationCenter>> GetAll() { return await Task.FromResult(EducationCenter.ToList()); }
    public async Task<Response<EducationCenter>> GetById(int id)
    {
        return await Task.Run(() =>
        {
            var educationcenter = EducationCenter.FirstOrDefault(x => x.Id == id);
            if (educationcenter != null) return new Response<EducationCenter>("Образовательный центр :", educationcenter);
            return new Response<EducationCenter>("Образовательный центр нету в базу");
        });
    }
    public async Task<Response<EducationCenter>> Remove(int id)
    {
        return await Task.Run(() =>
        {
            var educationcenter = EducationCenter.FirstOrDefault(x => x.Id == id);
            if (educationcenter != null)
            {
                EducationCenter.Remove(educationcenter);
                return new Response<EducationCenter>("Образовательный центр успешно удалено");
            }
            return new Response<EducationCenter>("Нету такого Образовательный центр");
        });
    }
    public async Task<Response<EducationCenter>> Update(EducationCenter c)
    {
        return await Task.Run(() =>
        {
            var educationcenter = EducationCenter.FirstOrDefault(x => x.Id == c.Id);
            if (educationcenter != null)
            {
                educationcenter.Name = c.Name;
                educationcenter.Departments = c.Departments;
                return new Response<EducationCenter>("Образовательный центр изменено");
            }
            return new Response<EducationCenter>("Нету такого Образовательный центр");
        });
    }
}
