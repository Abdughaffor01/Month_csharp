using task1_animal;

class Program
{
   static void Main(string[] args)
   {
      Spider sp = new Spider("spider");
      Cat cat = new Cat("cat");
      Fish fish = new Fish("fish");


      Console.WriteLine(sp.Eat());
      Console.WriteLine(sp.GetName());
      sp.SetName("spider-man");
      Console.WriteLine(sp.GetName());
      Console.WriteLine(sp.Walk());
      Console.WriteLine(cat.Eat());
      Console.WriteLine(cat.Walk());
      Console.WriteLine(fish.Eat());
      Console.WriteLine(fish.Walk());
      // See https://aka.ms/new-console-template for more information
      Console.WriteLine("Hello, World!");
   }
}