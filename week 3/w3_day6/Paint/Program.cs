
Paint l=new Paint(10,20);
Paint r=new Paint(20,30);
Console.WriteLine(l.GetX());
l.SetX(50);
Console.WriteLine(l.GetX());



Line lin=new Line(l,r);
lin.SetEndX(9000);

Console.Write("x="+lin.GetBeginX()+" "+" y=");
Console.WriteLine(lin.GetBeginY());
lin.SetBeginXY(1000,200);
Console.WriteLine(lin.GetBeginX());
Console.WriteLine(lin.GetBeginY());
var m=lin.GetBeginXY();
Console.WriteLine(lin.ToString());


