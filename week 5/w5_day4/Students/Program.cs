using Students.Model;
using Students.Service;

CourseService courseService = new CourseService();
StudentService studentService = new StudentService();
SubjectService subjectService = new SubjectService();
while (true)
{
   int id;
   string firstName;
   string lastName;
   string city;
   string street;
   string email;
   string mobile;
   string subjectname;
   int numofcredit;
   int courseID;
   Console.WriteLine("Pres 1 Course");
   Console.WriteLine("Pres 2 Subject");
   Console.WriteLine("Pres 3 Student");
   Console.WriteLine("Pres 4 exit");
   Console.Write("Введите команду : ");
   int number = Convert.ToInt32(Console.ReadLine());
   if (number == 1)
   {
      while (true)
      {
         Console.WriteLine();
         Console.WriteLine("Pres 1 add course");
         Console.WriteLine("Pres 2 add student");
         Console.WriteLine("Pres 3 add subject");
         Console.WriteLine("Pres 4 exit");
         Console.WriteLine("Pres 1 add course");
         Console.WriteLine("Pres 2 delete course");
         Console.WriteLine("Pres 3 update course");
         Console.WriteLine("Pres 4 getall course");
         Console.Write("Введите команду : ");
         Console.WriteLine();
         int number1 = Convert.ToInt32(Console.ReadLine());
         if (number1 == 1)
         {
            Console.Write("Name course : ");
            Course course = new Course(Console.ReadLine());
            var add = courseService.Add(course);
            Console.WriteLine(add.Message);
            Console.WriteLine("Хотите ешё добавить [yes and no]");
            string end = Console.ReadLine();
            if (end == "no") break;
         }
         else if (number1 == 2)
         {
            Console.Write("Firstname : ");
            firstName = Console.ReadLine();
            Console.Write("Latsname : ");
            lastName = Console.ReadLine();
            Console.Write("City : ");
            city = Console.ReadLine();
            Console.Write("Street : ");
            street = Console.ReadLine();
            Console.Write("Email : ");
            email = Console.ReadLine();
            Console.Write("Mobile : ");
            mobile = Console.ReadLine();
            Student student = new Student(firstName, lastName, city, street, email, mobile);
            var add = studentService.Add(student);
            Console.WriteLine(add.Message);
            Console.WriteLine("Хотите ешё добавить [yes and no]");
            string end = Console.ReadLine();
            if (end == "no") break;
         }
         else if (number1 == 3)
         {
            Console.Write("Subjectname : ");
            subjectname = Console.ReadLine();
            Console.Write("Numberofcourse : ");
            numofcredit = Convert.ToInt32(Console.ReadLine());
            Console.Write("CourseId : ");
            courseID = Convert.ToInt32(Console.ReadLine());
            Subject subject = new Subject(subjectname, numofcredit, courseID);
            var add = subjectService.Add(subject);
            Console.WriteLine(add.Message);
            Console.WriteLine("Хотите ешё добавить [yes and no]");
            string end = Console.ReadLine();
            if (end == "no") break;
         }
         else if (number1 == 4) break;
      }
   }
   else if (number == 2)
   {
      Console.WriteLine();
      Console.WriteLine("Pres 1 getall course");
      Console.WriteLine("Pres 2 getall student");
      Console.WriteLine("Pres 3 getall subject");
      Console.WriteLine("Pres 4 exit");
      Console.Write("Введите команду : ");
      Console.WriteLine();
      int number1 = Convert.ToInt32(Console.ReadLine());
      if (number1 == 1)
      {
         var all = courseService.GetAll();
         foreach (var item in all)
         {
            Console.WriteLine();
            Console.WriteLine($"Coursename : {item.GetCourseName}");
            Console.WriteLine();
         }
      }
      else if (number1 == 2)
      {
         var all = studentService.GetAll();
         foreach (var item in all)
         {
            Console.WriteLine();
            Console.WriteLine($"{item.GetFirstName()} {item.GetLastName()}, City {item.GetCity()}, Street : {item.GetStreet()}, Email : {item.GetEmail()}, Mobile : {item.GetMobile()}");
            Console.WriteLine();
         }
      }
      else if (number1 == 3)
      {
         var all = subjectService.GetAll();
         foreach (var item in all)
         {
            Console.WriteLine();
            Console.WriteLine($"Subjectname : {item.GetSubjectName()} , NumOfCredit {item.GetNumberOfCredits()} , CoursId {item.GetCourseID()}");
            Console.WriteLine();
         }
      }
      else if (number1 == 4) break;
   }
   else if (number == 3)
   {
      Console.WriteLine();
      Console.WriteLine("Pres 1 getbyID course");
      Console.WriteLine("Pres 2 getbyID student");
      Console.WriteLine("Pres 3 getbyID subject");
      Console.WriteLine("Pres 4 exit");
      Console.Write("Введите команду : ");
      Console.WriteLine();
      int number1 = Convert.ToInt32(Console.ReadLine());
      if (number1 == 1)
      {
         Console.Write("Введите id : ");
         var cours = courseService.GetById(Convert.ToInt32(Console.ReadLine()));
         if (cours != null)
         {
            Console.WriteLine(cours.Message);
            Console.WriteLine(cours.Data.GetCourseName());
         }
         else Console.WriteLine(cours.Message);
      }
      else if (number1 == 2)
      {
         Console.Write("Введите id : ");
         var student = studentService.GetById(Convert.ToInt32(Console.ReadLine()));
         if (student != null)
         {
            Console.WriteLine(student.Message);
            Console.WriteLine("Firstname " + student.Data.GetFirstName());
            Console.WriteLine("Lastname " + student.Data.GetLastName());
            Console.WriteLine("City " + student.Data.GetCity());
            Console.WriteLine("Street " + student.Data.GetStreet());
            Console.WriteLine("Email " + student.Data.GetEmail());
            Console.WriteLine("Mobile " + student.Data.GetMobile());
         }
         else Console.WriteLine(student.Message);
      }
      else if (number1 == 3)
      {
         Console.Write("Введите id : ");
         var subject = subjectService.GetById(Convert.ToInt32(Console.ReadLine()));
         if (subject != null)
         {
            Console.WriteLine(subject.Message);
            Console.WriteLine("Subjectname " + subject.Data.GetSubjectName());
            Console.WriteLine("Numofcredits " + subject.Data.GetNumberOfCredits());
            Console.WriteLine("Course id " + subject.Data.GetCourseID());
         }
         else Console.WriteLine(subject.Message);
      }
      else if (number1 == 4) break;
   }
   else if (number == 4)
   {
      Console.WriteLine();
      Console.WriteLine("Pres 1 update course");
      Console.WriteLine("Pres 2 update student");
      Console.WriteLine("Pres 3 update subject");
      Console.WriteLine("Pres 4 exit");
      Console.Write("Введите команду : ");
      Console.WriteLine();
      int number1 = Convert.ToInt32(Console.ReadLine());
      if (number1 == 1)
      {
         Console.Write("Введите id : ");
         id = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите coursname : ");
         Course cours = new Course(Console.ReadLine());
         cours.SetCourseId(id);
         var responce = courseService.Update(cours);
         if (responce != null)
         {
            Console.WriteLine(responce.Message);
            Console.WriteLine(responce.Data.GetCourseName());
         }
         else Console.WriteLine(responce.Message);
      }
      else if (number1 == 2)
      {
         Console.Write("Id Studenta : ");
         id = Convert.ToInt32(Console.ReadLine());
         Console.Write("Firstname : ");
         firstName = Console.ReadLine();
         Console.Write("Latsname : ");
         lastName = Console.ReadLine();
         Console.Write("City : ");
         city = Console.ReadLine();
         Console.Write("Street : ");
         street = Console.ReadLine();
         Console.Write("Email : ");
         email = Console.ReadLine();
         Console.Write("Mobile : ");
         mobile = Console.ReadLine();
         Student student = new Student(firstName, lastName, city, street, email, mobile);
         var responce = studentService.Update(student);
         Console.WriteLine(responce.Message);
      }
      else if (number1 == 3)
      {
         Console.Write("Subjectname : ");
         subjectname = Console.ReadLine();
         Console.Write("NumberOfCourse : ");
         numofcredit = Convert.ToInt32(Console.ReadLine());
         Console.Write("CourseId : ");
         courseID = Convert.ToInt32(Console.ReadLine());
         Subject subject = new Subject(subjectname, numofcredit, courseID);
         var responce = subjectService.Update(subject);
         if (responce != null)
         {
            Console.WriteLine(responce.Message);
            Console.WriteLine(responce.Data.GetSubjectName());
         }
         else Console.WriteLine(responce.Message);
      }
      else if (number1 == 4) break;
   }
   else if (number == 5)
   {
      Console.WriteLine();
      Console.WriteLine("Pres 1 delete course");
      Console.WriteLine("Pres 2 delete student");
      Console.WriteLine("Pres 3 delete subject");
      Console.WriteLine("Pres 4 exit");
      Console.Write("Введите команду : ");
      Console.WriteLine();
      int number1 = Convert.ToInt32(Console.ReadLine());
      if (number1 == 1)
      {
         Console.Write("Введите id cours : ");
         id = Convert.ToInt32(Console.ReadLine());
         var responce = courseService.Remove(id);
         Console.WriteLine(responce.Message);
      }
      else if (number1 == 2)
      {
         Console.Write("Введите id student : ");
         id = Convert.ToInt32(Console.ReadLine());
         var responce = studentService.Remove(id);
         Console.WriteLine(responce.Message);
      }
      else if (number1 == 3)
      {
         Console.Write("Введите id subject : ");
         id = Convert.ToInt32(Console.ReadLine());
         var responce = subjectService.Remove(id);
         Console.WriteLine(responce.Message);
      }
      else if (number1 == 4) break;
   }
}