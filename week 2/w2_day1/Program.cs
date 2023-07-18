Post1 p1 = new Post1()
{
   Title = "GHaffor",
   Description = "hfhf",
   DateTime = DateTime.Today,
};
p1.Published();
p1.Comment("Молодец");
p1.Comment("Брашка");
p1.Comment("зр");
p1.Comment("Гапт надорм");
p1.PrintComment();
p1.Like();
p1.Like();
p1.Like();
System.Console.WriteLine($"Всего {p1.like} лайки");
System.Console.WriteLine();

Post1 p2 = new Post1()
{
   Title = "Idibek",
   DateTime = DateTime.Today
};
p2.Published();
p2.Comment("Питух бромади");
p2.Comment("Адирааа");
p2.Comment("Мошин гап не");
p2.Comment("Ба пеш");
p2.PrintComment();
p2.Like();
p2.Like();
p2.Like();
p2.Like();
p2.Like();
System.Console.WriteLine($"Всего {p2.like} лайки");
System.Console.WriteLine();


Post1 p3 = new Post1()
{
   Title = "Aminjon",
   Description = "Курси с# хондесай брашка",
   DateTime = DateTime.Today
};
p3.Published();
p3.Comment("ФПРаа");
p3.Comment("теория");
p3.Comment("Биологмя");
p3.Comment("Гапт надорм");
p3.PrintComment();

p3.Like();
p3.Like();
p3.Like();
p3.Like();
System.Console.WriteLine($"Всего {p3.like} лайки");
System.Console.WriteLine();