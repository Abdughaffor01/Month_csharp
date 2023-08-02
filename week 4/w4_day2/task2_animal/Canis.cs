namespace task2_animal;

public class Canis : Animal
{
   public Canis() { }
   public Canis(string species):base(species){}
   public Canis(string name, string species) : base(name, 4,species){}
   public override string GetSound() => $"I canis my name is {GetName()} haf haf haf";
   public override bool IsScary() => true;
   public override string ToString() => $"My name is {GetName()} i am {GetLegs()} legs i is scary";
}
