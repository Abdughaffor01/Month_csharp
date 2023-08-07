while (true)
{
   Random random = new Random();
   int number = random.Next(0, 101);
   int popitka = random.Next(3, 10);
   int nachala = random.Next(number - 10, number), kones = random.Next(number + 1, number + 10);
   Console.WriteLine($"Мы загадали число от {nachala} до {kones}");
   Console.WriteLine($"У вас {popitka} попитка :");
   Console.WriteLine();
   while (popitka-- > 0)
   {
      Console.Write("Ваш ответ :");
      int usernumber = Convert.ToInt32(Console.ReadLine());
      Thread.Sleep(1000);
      if (usernumber == number)
      {
         Console.WriteLine();
         Console.WriteLine($"Вы прави это было {number} 😎🙌");
         break;
      }
      else
      {
         Console.WriteLine($"Не верно попробуйте ешё раз у вас осталос {popitka} попитки");
         Console.Beep();
      }
   }
   Console.WriteLine();
   if (popitka < 0) Console.WriteLine("Вы  проиграли 😁");
   Console.WriteLine();
   Console.WriteLine("Хотите продолжат? ");
   Console.WriteLine("yes / no");
   while (true)
   {
      string koness = Console.ReadLine();
      if (koness.ToLower().Trim() == "yes")
      {
         break;
      }
      else if (koness.ToLower().Trim() == "no") return 0;
      Console.Beep();
      Console.WriteLine("Ошибка такого команда нету 🤷‍♀️");
   }
}


