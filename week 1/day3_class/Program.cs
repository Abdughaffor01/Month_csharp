Person per = new Person()
{
   FirstName = "Abdughaffor",
   LastName = "Rahimov",
   age = 32,
   address = "Hksafkald_34"
};
Console.WriteLine(per.FulName());
Console.WriteLine(per.Birthday());
System.Console.WriteLine();

Rectange rec = new Rectange();
rec.Width = 34;
rec.Height = 34;
rec.GetArea();
rec.GetPerimeter();
Console.WriteLine();
Console.Write("Виведите ширина :");
rec.Width = Convert.ToInt32(Console.ReadLine());
Console.Write("Виведите длина :");
rec.Height = Convert.ToInt32(Console.ReadLine()); ;
rec.GetArea();
rec.GetPerimeter();
System.Console.WriteLine();

var list = new List<Student>();

Student s1 = new Student()
{
   Name = "Ali",
   Gradle = 3,
   Everage = new int[4] { 20, 40, 90, 40 }
};

Student s2 = new Student()
{
   Name = "Ghaffor",
   Gradle = 6,
   Everage = new int[4] { 70, 80, 90, 80 },
};

Student s3 = new Student()
{
   Name = "Idibek",
   Gradle = 10,
   Everage = new int[4] { 90, 90, 90, 90 }
};

Student s4 = new Student()
{
   Name = "Khuram",
   Gradle = 10,
   Everage = new int[4] { 90, 10, 80, 90 }
};

Student s5 = new Student()
{
   Name = "Umar",
   Gradle = 2,
   Everage = new int[4] { 20, 60, 90, 90 }
};

list.Add(s1);
list.Add(s2);
list.Add(s3);
list.Add(s4);
list.Add(s5);

foreach (var e in list)
{
   System.Console.WriteLine(e.Name);
   System.Console.WriteLine(e.Gradle);
   System.Console.WriteLine(e.Sredbal());
   if (e.Sredbal() > 85) Console.WriteLine($"{e.Name} брашка табрик гзашти");
   else if (e.Sredbal() > 70) Console.WriteLine($"{e.Name} брашка хондан даркор");
   else Console.WriteLine($"{e.Name} Карочи ай т програмист нмероя ");
   System.Console.WriteLine();
}