namespace task2_Person;

public class Teacher : Person
{
   int numCourses = 0;
   List<string> courses = new List<string>();
   public Teacher(string name, string addres) : base(name, addres) { }
   public override string ToString()
   {
      return $"Teacher : {Name}({Addres})";
   }
   public bool AddCourse(string course)
   {
      if (course == null) return false;
      courses.Add(course);
      return true;
   }
   public bool RemoveCourse(string course)
   {
      foreach (var i in courses)
      {
         if (i == course)
         {
            courses.Remove(i);
            return true;
         }
      }
      return false;
   }
}
