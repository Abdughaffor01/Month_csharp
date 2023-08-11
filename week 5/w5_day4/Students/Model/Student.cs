namespace Students.Model;
public class Student : Person
{
   int studentId;
   public Student(string firstName, string lastName, string city, string street, string email, string mobile)
   {
      this.firstName = firstName;
      this.lastName = lastName;
      this.city = city;
      this.street = street;
      this.email = email;
      this.mobile = mobile;
   }
   public int GetStudentId() => studentId;
   public void SetStudentId(int studentId) => this.studentId = studentId;
   public string GetFirstName() => firstName;
   public void SetFirstName(string firstName) => this.firstName = firstName;
   public string GetLastName() => lastName;
   public void SetLastName(string lastName) => this.lastName = lastName;
   public string GetCity() => city;
   public void SetCity(string city) => this.city = city;
   public string GetStreet() => street;
   public void SetStreet(string street) => this.street = street;
   public string GetEmail() => email;
   public void SetEmail(string email)=> this.email = email;
   public string GetMobile()=>mobile;
   public void SetMobile(string mobile)=> this.mobile = mobile;
}