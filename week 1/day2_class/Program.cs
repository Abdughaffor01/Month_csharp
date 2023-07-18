
var person1 = new Person();
person1.Name = "Idibek";
person1.Age = 25;
person1.Height = 1.90f;
person1.FullInfo();
person1.Walk();
person1.Eat();
System.Console.WriteLine();

Rectange rec=new Rectange();
rec.Width=25;
rec.Height=25;
rec.GetArea();
rec.GetPerimeter();
System.Console.WriteLine();

Circle circle=new Circle();
circle.Radius=26;
circle.GetArea();
circle.GetCircumference();
System.Console.WriteLine();

Shape shape=new ();
shape.Color="red";
shape.Name="Map";
shape.PositionX=24;
shape.PositionY=24;
shape.GetPosition();
shape.GetFullInfo();
System.Console.WriteLine();

User user=new User();
user.FirstName="Abdughaffor";
user.LastName="Rahimov";
user.UserName="Kiler";
user.Password="GHaffor01";
user.Login("Kiler","GHaffor01");
System.Console.WriteLine(user.GetFullInfo());