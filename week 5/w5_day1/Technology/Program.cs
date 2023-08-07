using Technology;
List<Laptop> lap = new List<Laptop>();
List<Smatphone> smart = new List<Smatphone>();

while (true)
{
   Console.WriteLine("Pres 1 add Laptop");
   Console.WriteLine("Pres 2 add Smartphone");
   Console.WriteLine("Pres 3 get infotmation");
   int a = Convert.ToInt32(Console.ReadLine());
   if (a == 1)
   {
      Console.WriteLine("Add laptop");
      while (true)
      {
         Console.WriteLine();
         Console.Write("Введите вес :");
         Laptop laptop = new Laptop(Convert.ToDouble(Console.ReadLine()));
         Console.Write("Ram : ");
         laptop.Ram = Convert.ToInt32(Console.ReadLine());
         Console.Write("Storage : ");
         laptop.Storage = Convert.ToInt32(Console.ReadLine());
         Console.Write("Keyboard : ");
         laptop.Keyboard = Console.ReadLine();
         lap.Add(laptop);
         Console.WriteLine("Эсли хотите выйти пишите end");
         Console.WriteLine("Эсли вы хотите добавит ram или storage пишите yes");
         string name = Console.ReadLine();
         if (name == "end")
         {
            Console.WriteLine();
            break;
         }
         else if (name == "yes")
         {
            Console.WriteLine("Чего?");
            Console.WriteLine("1-Ram ");
            Console.WriteLine("2-Storage");
            int add = Convert.ToInt32(Console.ReadLine());
            if (add == 1)
            {
               Console.WriteLine(laptop.Ram + "Gb");
               Console.Write("Сколко : ");
               int ram = Convert.ToInt32(Console.ReadLine());
               laptop.AddRam(ram);
               Console.WriteLine(laptop.Ram + "Gb");
            }
            else if (add == 2)
            {
               Console.WriteLine(laptop.Storage + "Gb");
               Console.Write("Сколко : ");
               int stor = Convert.ToInt32(Console.ReadLine());
               laptop.AddStorage(stor);
               Console.WriteLine(laptop.Storage + "Gb");
            }
         }
         // Console.WriteLine("Foto");
         // while (true)
         // {
         //    string foto = Console.ReadLine();
         //    if(foto=="yes"){
         //       laptop.
         //    }

         // }

      }
   }
   else if (a == 2)
   {
      // Console.WriteLine("Add smartphone");
      // while (true)
      // {
      //    Smatphone sphone = new Smatphone();
      //    Console.Write("Ram : ");
      //    sphone.Ram = Convert.ToInt32(Console.ReadLine());
      //    Console.Write("Storage : ");
      //    sphone.Storage = Convert.ToInt32(Console.ReadLine());
      //    Console.Write("Keyboard : ");
      //    sphone.Keyboard = Console.ReadLine();

      //    Console.WriteLine("Эсли хотите выйти пишите end");
      //    string name=Console.ReadLine();
      //    if (name == "end")
      //    {
      //       Console.WriteLine();
      //       break;
      //    }
      // }
   }
   else if (a == 3)
   {
      Console.WriteLine("Какая информатция вам нужно");
      Console.WriteLine("1-Laptop");
      Console.WriteLine("2-Smartphone");
      int inf = Convert.ToInt32(Console.ReadLine());
      if (inf == 1)
      {
         foreach (var i in lap)
         {
            Console.WriteLine($"Ram {i.Ram}Gb");
            Console.WriteLine($"Storage {i.Storage}Gb");
            Console.WriteLine($"Keyboard {i.Keyboard}");
            Console.WriteLine($"Weight {i.weight}");
            Console.WriteLine(i.WeightChec());
            Console.WriteLine();
         }
      }
   }
}