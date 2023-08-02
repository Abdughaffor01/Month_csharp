namespace task2_animal;

public class Shake : Animal
{
   string color;
   public Shake() { }
   public Shake(string species):base(species){}
   public Shake(string name, string color, string species):base(name,0,species)=>this.color=color;
   public string GetColor()=>color;
   public void SetColor(string color)=>this.color=color;
   
   public override string GetSound() => $"I shake my name is {GetName()} fs fs fs";
   public override bool IsScary() => true;
   public override string ToString() => $"My name is {GetName()} i am {GetLegs()} legs i is scary";
}
