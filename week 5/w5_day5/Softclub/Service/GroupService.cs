using Softclub.Model;
using Softclub.Service.Generic;
namespace Softclub.Service
{
    public class GroupService : IBaseService<Group>
    {
        List<Group> groups = new List<Group>();
        int id = 1;
        public async Task<Response<Group>> Add(Group c)
        {
            return await Task.Run(() =>
            {
                c.Id = id++;
                groups.Add(c);
                return new Response<Group>("Группа добавлено");
            });
        }
        public async Task<List<Group>> GetAll() { return await Task.FromResult(groups.ToList()); }
        public async Task<Response<Group>> GetById(int id)
        {
            return await Task.Run(() =>
            {
                var group = groups.FirstOrDefault(x => x.Id == id);
                if (group != null) return new Response<Group>("Группа найден ", group);
                return new Response<Group>("Группа не найден");
            });
        }
        public async Task<Response<Group>> Remove(int id)
        {
            return await Task.Run(() =>
            {
                var group = groups.FirstOrDefault(x => x.Id == id);
                if (group != null)
                {
                    groups.Remove(group);
                    return new Response<Group>("Группа удалено");
                }
                return new Response<Group>("Группа не найден");
            });
        }
        public async Task<Response<Group>> Update(Group c)
        {
            return await Task.Run(() =>
            {
                var group = groups.FirstOrDefault(x => x.Id == id);
                if (group != null)
                {
                    group.GroupName = c.GroupName;
                    group.CourseId = c.CourseId;
                    return new Response<Group>("Группа изменено");
                }
                return new Response<Group>("Группа не найден");
            });
        }
    }
}
