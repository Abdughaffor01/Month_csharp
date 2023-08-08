using Domein.Models;
using Infrascrtion.Services;
CourseService courseService = new CourseService();
while (true)
{
   Console.WriteLine("Pres 1 add course");
   Console.WriteLine("Pres 2 getById course");
   Console.WriteLine("Pres 3 getall course");
   Console.WriteLine("Pres 4 update course");
   Console.WriteLine("Pres 5 delete course");
   Console.Write("Введите команду : ");
   int number = Convert.ToInt32(Console.ReadLine());
   if (number == 1)
   {
      while (true)
      {
         Course course = new Course();
         Console.WriteLine("Name course : ");
         course.Name = Console.ReadLine();
         var add = courseService.Add(course);
         Console.WriteLine(add.Message);
         Console.WriteLine("Хотите ешё добавить [yes and no]");
         string end = Console.ReadLine();
         if (end == "no") break;
      }
   }
   else if (number == 2)
   {
      Console.WriteLine("Введите id : ");
      int id = Convert.ToInt32(Console.ReadLine());
      var response = courseService.GetById(id);
      Console.WriteLine($"{response.Message}");
      Console.WriteLine($"{response.Data.Id}");
      Console.WriteLine($"{response.Data.Name}");
   }
   else if (number == 3)
   {
      var courses = courseService.GetAll();
      if (courses != null)
      {
         foreach (var e in courses)
         {
            Console.WriteLine();
            Console.WriteLine($"Id : {e.Id}");
            Console.WriteLine($"Name : {e.Name}");
            Console.WriteLine();
         }
      }
   }
   else if (number == 4)
   {
      Course course = new Course();
      Console.WriteLine("Id : ");
      course.Id = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Name course : ");
      course.Name = Console.ReadLine();
      var update = courseService.Update(course);
      Console.WriteLine(update.Message);
   }
   else if (number == 5)
   {
      Console.WriteLine("Id : ");
      int Id = Convert.ToInt32(Console.ReadLine());
      var remove = courseService.Remove(Id);
      Console.WriteLine(remove.Message);
   }
}