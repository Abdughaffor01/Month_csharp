using Students.Enums;
namespace Students.Model;
public class Teacher:Person
{
   int salary;
   public EducationLevels EducationLevels { get; set; }=EducationLevels.Molodoy;
   public int GetSalary()=>salary;
   public void SetSalary(int salary)=>this.salary=salary;
}
