namespace task2_animal;

public class Canis : Animal
{
   string species;
   public Canis() { }
   public Canis(string species) => this.species = species;
   public Canis(string name, string species) : base(name, 4)
   {
      SetName(name);
      this.species = species;
   }
   public string GetSpecies() => species;
   public void SetSpecies(string species) => this.species = species;
   public override string GetSound() => $"I canis my name is {GetName()} haf haf haf";
   public override bool IsScary() => true;
   public override string ToString() => $"My name is {GetName()} i am {GetLegs()} legs i is scary";
}
