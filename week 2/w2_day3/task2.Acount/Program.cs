using task2.Acount;


Acount ac1 = new Acount(987849660, 56.4);
Console.WriteLine(ac1.getNumber());
Console.WriteLine(ac1.getBalance());
ac1.credit(20.5);
Console.WriteLine(ac1.toString());
ac1.debit(40.2);
Console.WriteLine(ac1.toString());

Acount ac2 = new Acount(918455419, 20);
ac1.transferTo(10.3,ac2);
Console.WriteLine(ac1.toString());
Console.WriteLine(ac2.toString());