using practice;
int idperson = 1;
PersonService personService = new PersonService();
while (true)
{
   Console.WriteLine();
   Console.WriteLine("add : add person ");
   Console.WriteLine("update : update person");
   Console.WriteLine("delete : delete person");
   Console.WriteLine("getid : get person");
   Console.WriteLine("get : get all persons");
   Console.Write("Enter comand : ");
   string num = Console.ReadLine();
   if (num.ToLower().Trim() == "add")
   {
      Person p = new Person();
      p.Id = idperson;
      Console.Write("Firstname : ");
      p.FirstName = Console.ReadLine();
      Console.Write("Lastname : ");
      p.LastName = Console.ReadLine();
      Console.Write("Age : ");
      p.Age = Convert.ToInt32(Console.ReadLine());
      personService.AddPerson(p);
      idperson++;
   }
   else if (num.ToLower().Trim() == "update")
   {
      Person p = new Person();
      Console.Write("Id : ");
      p.Id = Convert.ToInt32(Console.ReadLine());
      Console.Write("Firstname : ");
      p.FirstName = Console.ReadLine();
      Console.Write("Lastname : ");
      p.LastName = Console.ReadLine();
      Console.Write("Age : ");
      p.Age = Convert.ToInt32(Console.ReadLine());
      personService.UpdatePerson(p);
   }
   else if (num.ToLower().Trim() == "delete")
   {
      Console.Write("Person Id : ");
      int id = Convert.ToInt32(Console.ReadLine());
      personService.RemovePerson(id);
   }
   else if (num.ToLower().Trim() == "getid")
   {
      Console.Write("Id : ");
      int number = Convert.ToInt32(Console.ReadLine());
      var p = personService.PersonGetById(number);
      if (p == null) Console.WriteLine("Нету такого человека с таким Id");
      else
      {
         Console.WriteLine($"Firstname {p.FirstName}");
         Console.WriteLine($"Lastname {p.LastName}");
         Console.WriteLine($"Age {p.Age}");
      }
   }
   else if (num.ToLower().Trim() == "get")
   {
      List<Person> personss = personService.GetPersons();
      int cnt = 1;
      foreach (var i in personss)
      {
         Console.WriteLine($"{cnt} person");
         Console.WriteLine($"Id  {i.Id}");
         Console.WriteLine($"Firstname {i.FirstName}");
         Console.WriteLine($"Lastname {i.LastName}");
         Console.WriteLine($"Age {i.Age}");
         Console.WriteLine();
         cnt++;
      }
   }
}