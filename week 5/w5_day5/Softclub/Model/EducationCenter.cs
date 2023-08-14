namespace Softclub.Model;

public class EducationCenter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Department> Departments { get; set; }
}
