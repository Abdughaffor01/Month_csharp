namespace task2_Person;

public class Student:Person
{
   int numCourses=0;
   List<string> courses=new List<string>();
   List<int> gradle=new List<int>();
   public Student(string name,string addres):base(name,addres){}
   public override string ToString()
   {
      return $"Student : {Name}({Addres})";
   }
   public void AddCourseGrade(string course,int grade){
      courses.Add(course);
      gradle.Add(grade);
   }
   public void PrintGradle(){
      int cnt=1;
      foreach (var i in gradle)
      {
         Console.WriteLine($"{cnt} day {i}");
         cnt++;
      }
   }
   public double GetAverageGrade(){
      double sum=0;
      foreach (var i in gradle)
      {
         sum+=i;
      }
      return sum/(gradle.Count());
   }
}
