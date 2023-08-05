namespace Animal;

public abstract class Animall
{
   public string Name { get; set; }
   public  void SetName(string name)=>Name=name;
   public string GetName()=>Name;
   public abstract void Eat();
}
