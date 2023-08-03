using Circle;

RezizableCircle res=new RezizableCircle(45);
Console.WriteLine("Area circle : "+res.GetArea());
Console.WriteLine("Perimeter circle : "+res.GetPerimeter());
res.Resize(2);
Console.WriteLine();
Console.WriteLine("После изменени размера");
Console.WriteLine();
Console.WriteLine("Area circle : "+res.GetArea());
Console.WriteLine("Perimeter circle : "+res.GetPerimeter());