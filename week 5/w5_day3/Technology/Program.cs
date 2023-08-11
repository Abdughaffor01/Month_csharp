using Technology.Model;
using Technology.Services;
LaptopService laptopService = new LaptopService();
PhoneService phoneService = new PhoneService();
while (true)
{
    Console.WriteLine("Pres 1 add technology");
    Console.WriteLine("Pres 2 getall technology");
    Console.WriteLine("Pres 3 remove technology");
    Console.WriteLine("Pres 4 update technology");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a == 1)
    {
        Console.WriteLine("Pres 1 add laptop");
        Console.WriteLine("Pres 2 add phone");
        Console.WriteLine("Pres 3 выход");
        Console.Write("Enter : ");
        int c = Convert.ToInt32(Console.ReadLine());
        if (c == 1)
        {
            Laptop laptop = new Laptop();
            laptop.TypeTechnologyy=laptop.TypeTechnologyy;
            Console.WriteLine("Введите ");
            Console.WriteLine("Введите ");
            Console.WriteLine("Введите ");
            Console.WriteLine("Введите ");
            Console.WriteLine("Введите ");
        }
        if (c == 2)
        {
            Phone phone = new Phone();
            Console.WriteLine("Введите ");
            Console.WriteLine("Введите ");
            Console.WriteLine("Введите ");
            Console.WriteLine("Введите ");
            Console.WriteLine("Введите ");
        }

    }
}
