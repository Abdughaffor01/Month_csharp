namespace task2_animal;

public abstract class Animal
{
   string name;
   int legs;
   public Animal() { }
   public Animal(string name, int legs)
   {
      this.name = name;
      this.legs = legs;
   }
   public string GetName() => name;
   public int GetLegs() => legs;
   public void SetName(string name) => this.name = name;
   public void SetLegs(int legs) => this.legs = legs;
   public abstract string GetSound();
   public abstract bool IsScary();
   public override abstract string ToString();
}
