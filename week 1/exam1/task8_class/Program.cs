var l=new List<Person1>();
Person1 p1 = new Person1()
{
   Name = "Chanelle",
   Surname = "Philip",
   Age = 34
};
Person1 p2 = new Person1()
{
   Name = "Esha",
   Surname = "Barlow",
   Age = 20
};
Person1 p3 = new Person1()
{
   Name = "Lylah",
   Surname = "Gordon",
   Age = 21
};
l.Add(p1);
l.Add(p2);
l.Add(p3);
System.Console.WriteLine(p1.GetInfo());
System.Console.WriteLine(p2.GetInfo());
System.Console.WriteLine(p3.GetInfo());