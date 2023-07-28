List<Person> list = new List<Person>();

while (true)
{
   Console.WriteLine("Pres 1 add person");
   Console.WriteLine("Pres 2 get person");
   Console.WriteLine("Pres 3 finish");
   int a = Convert.ToInt32(Console.ReadLine());
   if (a == 1)
   {
      Console.WriteLine("read exit");
      while (true)
      {
         Person pers = new Person();
         Console.Write("Name : ");
         string name = Console.ReadLine();
         if (name == "exit")
         {
            Console.WriteLine();
            break;
         }
         pers.Name = name;
         list.Add(pers);
      }
   }
   else if (a == 2)
   {
      foreach (var i in list)
      {
         Console.WriteLine(i.ToString());
      }
      Console.WriteLine();
   }
   else if (a == 3)
   {
      return 0;
   }
}