
List<Figther> list = new List<Figther>();
Random random = new Random();
while (true)
{
   Console.WriteLine("Pres 1 add figther");
   Console.WriteLine("Pres 2 Show figthers");
   Console.WriteLine("Pres 3 start game");
   int num = Convert.ToInt32(Console.ReadLine());
   if (num == 1)
   {
      while (true)
      {
         Console.Write("Введите имя : ");
         string name = Console.ReadLine();
         int level = random.Next(1, 10);
         int health, demage, bron;
         if (level < 3)
         {
            health = random.Next(100, 150);
            demage = random.Next(30, 35);
            bron = random.Next(10, 15);
         }
         else if (level < 6)
         {
            health = random.Next(150, 200);
            demage = random.Next(35, 40);
            bron = random.Next(15, 20);
         }
         else
         {
            health = random.Next(200, 250);
            demage = random.Next(40, 45);
            bron = random.Next(20, 25);
         }
         Figther f = new Figther(name, health, demage, bron, level);
         list.Add(f);
         Console.WriteLine($"Хотите выйти  yes?");
         string n = Console.ReadLine();
         if (n.ToLower().Trim() == "yes") break;
      }
   }
   else if (num == 2)
   {
      Console.WriteLine();
      foreach (var item in list) Console.WriteLine(item.InfoFigther());
      Console.WriteLine();
   }
   else if (num == 3)
   {
      while (true)
      {
         if (list.Count < 2)
         {
            Console.WriteLine("Добавьте персонаж");
            Console.Beep();
            Thread.Sleep(1000);
            break;
         }
         var p1 = list[random.Next(0, list.Count)];
         var p2 = list[random.Next(0, list.Count)];
         if (p1 != p2)
         {
            p1.TakeDamage(p2.Demage);
            p2.TakeDamage(p1.Demage);
            foreach (var i in list)
            {
               if (i.Health <= 0)
               {
                  Console.WriteLine($"{i.Name} вы погибли для продолжения жмите любую клавишу");
                  list.Remove(i);
                  Console.ReadLine();
                  break;
               }
            }
            if (list.Count == 1)
            {
               foreach (var i in list)
               {
                  Console.WriteLine();
                  Console.WriteLine(i.InfoFigther());
                  Console.WriteLine("Вы победили");
                  Console.WriteLine();
               }
               list.Clear();
               break;
            }
            Console.WriteLine();
            foreach (var i in list)
            {
               Console.WriteLine(i.ShowHealth());
               Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.WriteLine("Для продолжения жмите люой клавишу");
            Console.ReadLine();
         }
         else { Console.WriteLine(); }
      }
   }
}