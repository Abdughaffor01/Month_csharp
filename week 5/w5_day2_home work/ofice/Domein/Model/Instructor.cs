namespace Domein.Model;
using System.ComponentModel.DataAnnotations;
public class Instructor:Person
{
   [DataType(DataType.Date)]
   [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
   [Display(Name = "Enrollment Date")]
   public DateTime HireDate { get; set; }
   public  string FullName()=> LastName + ", " + FirstName;
   public virtual ICollection<Course> Courses { get; set; }
   public virtual OfficeAssignment OfficeAssignment { get; set; }
}