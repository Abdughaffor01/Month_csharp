using task4;
User users=new User();
while (true)
{
   User user = new User();
   Console.Write("Firstname: ");
   user.FirstName = Console.ReadLine();
   Console.Write("Lastname: ");
   user.LastName = Console.ReadLine();
   Console.Write("Username: ");
   user.UserName = Console.ReadLine();
   Console.Write("Password: ");
   user.Password = Console.ReadLine();
   Console.WriteLine();
   users.AddUser(user);

   Console.WriteLine("stop? ");
   string stop = Console.ReadLine();
   if (stop == "yes") { break; }
}

while (true)
{
   Console.WriteLine("pres 1 get info users");
   Console.WriteLine("pres 2 login");
   int s = Convert.ToInt32(Console.ReadLine());
   if (s == 1)
   {
      users.GetInfo();
   }
   else if(s == 2)
   {
      Console.WriteLine("Введите username");
      string usernm=Console.ReadLine();
      Console.WriteLine("Введите password");
      string passw=Console.ReadLine();
      Console.WriteLine(users.Login(usernm,passw));
      Console.WriteLine();
    }
}
