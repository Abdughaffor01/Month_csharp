namespace Students.Model;
public class Student : Person
{
   int studentId;
   public Student(string firstName, string lastName, string city, string street, string email, string mobile)
   {
      FirstName = firstName;
      LastName = lastName;
      City = city;
      Street = street;
      Email = email;
      Mobile = mobile;
   }
   public int GetStudentId() => studentId;
   public void SetStudentId(int studentId) => this.studentId = studentId;
}