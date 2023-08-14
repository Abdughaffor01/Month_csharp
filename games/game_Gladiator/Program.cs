Console.WriteLine("Welcome to my game");
List<Gladiator> list = new List<Gladiator>();
Random random = new Random();
while (true)
{

    Console.WriteLine();
    Console.WriteLine("Press 1 create character");
    Console.WriteLine("Press 2 start game");
    Console.WriteLine();
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 1)
    {
        Gladiator g = new Gladiator();
        Console.Write("Name gladiator : ");
        g.Name = Console.ReadLine();
        g.level = random.Next(1, 10);
        if (g.level < 4)
        {
            g.Helth = random.Next(100, 150);
            g.Atact = random.Next(20, 25);
        }
        else if (g.level < 7)
        {
            g.Helth = random.Next(150, 200);
            g.Atact = random.Next(25, 30);
        }
        else if (g.level < 11)
        {
            g.Helth = random.Next(200, 250);
            g.Atact = random.Next(35, 40);
        }
        list.Add(g);
    }
    else if (number == 2)
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
            list[random.Next(list.Count)].Helth -= list[random.Next(list.Count)].Atact;
            list[random.Next(list.Count)].Helth -= list[random.Next(list.Count)].Atact;
            foreach (var i in list)
            {
                if (i.Helth <= 0)
                {
                    Console.WriteLine($"{i.Name} вы погибли для продолжения жмите любую клавишу");
                    list.Remove(i);
                    Console.ReadLine();
                    break;
                }
            }
            if (list.Count() == 1)
            {
                foreach (var i in list)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Name  : {i.Name}");
                    Console.WriteLine($"Helth : {i.Helth}");
                    Console.WriteLine($"Atack : {i.Atact}");
                    Console.WriteLine($"Level : {i.level}");
                    Console.WriteLine();
                    Console.WriteLine("Вы победили");
                    list.Remove(i);
                }
                break;
            }

            foreach (var i in list)
            {
                Console.WriteLine();
                Console.WriteLine($"Name  : {i.Name}");
                Console.WriteLine($"Helth : {i.Helth}");
                Console.WriteLine($"Atack : {i.Atact}");
                Console.WriteLine($"Level : {i.level}");
                Console.WriteLine();
                Thread.Sleep(1000);
            }
            Console.WriteLine("Для продолжения жмите люой клавишу");
            Console.ReadLine();
        }
    }
}