

using task2_animal;

Shake shake=new Shake("rex","red","ala");
Dog dog=new Dog("Barsik");

Console.WriteLine(shake.GetLegs());
Console.WriteLine(shake.IsScary());
Console.WriteLine(shake.GetSound());
Console.WriteLine(shake.ToString());

System.Console.WriteLine();
Console.WriteLine(dog.GetLegs());
Console.WriteLine(dog.IsScary());
Console.WriteLine(dog.GetSound());
Console.WriteLine(dog.ToString());
