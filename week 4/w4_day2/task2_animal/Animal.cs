namespace task2_animal;

public abstract class Animal
{
   string name;
   int legs;
   string species;
   public Animal(){}
   public Animal(string species)=>this.species=species;
   public Animal(string name, int legs,string species)
   {
      this.name = name;
      this.legs = legs;
      this.species=species;
   }
   public string GetName() => name;
   public int GetLegs() => legs;
   public string GetSpecies() => species;
   public void SetSpecies(string species) => this.species=species;
   public void SetName(string name) => this.name = name;
   public void SetLegs(int legs) => this.legs = legs;
   public abstract string GetSound();
   public abstract bool IsScary();
   public override abstract string ToString();
}
