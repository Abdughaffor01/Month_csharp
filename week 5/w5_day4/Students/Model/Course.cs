namespace Students.Model;
public class Course
{
   int courseId;
   string courseName;
   public Course(string courseName)=>this.courseName=courseName;
   public int GetCourseId()=>courseId;
   public void SetCourseId(int id)=>this.courseId=id;
   public string GetCourseName()=>courseName;
   public void SetCourseName(string courseName)=>this.courseName=courseName;
}
