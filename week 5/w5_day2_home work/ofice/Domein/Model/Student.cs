using System.ComponentModel.DataAnnotations;
namespace Domein.Model;
public class Student : Person
{
   [DataType(DataType.Date)]
   [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
   [Display(Name = "Enrollment Date")]
   public DateTime EnrollmentDate { get; set; }
   public virtual ICollection<Enrollment> Enrollments { get; set; }
}
