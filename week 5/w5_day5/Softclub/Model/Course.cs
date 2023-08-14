namespace Softclub.Model;
public class Course
{
    public int Id { get; set; }
    public string CourseName { get; set; }
    public List<Group> Group { get; set; }
}
