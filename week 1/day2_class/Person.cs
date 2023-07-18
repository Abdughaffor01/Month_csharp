public class Person
{
    public string? Name;
    public int Age;
    public float Height;

    public void FullInfo()
    {
        System.Console.WriteLine($"Name : {Name}  Age : {Age}  Height : {Height}");
    }
    public void Walk()
    {
        System.Console.WriteLine($"{Name} is walking");
    }
    public void Eat()
    {
        System.Console.WriteLine($"{Name} is eating");
    }
}