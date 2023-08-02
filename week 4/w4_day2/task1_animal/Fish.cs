namespace task1_animal;

public class Fish:Pet
{  
   string name;
   public Fish(string name):base(0)=> this.name=name;
   public override string GetName()=>name; 
   public override void SetName(string name)=>this.name=name; 
   public override string Play()=>$"I am {name} i fish I playing in weter";
   public override string Walk()=>$"Я рыба я не могу хидит я могу плават";
   public override string Eat()=>$"I am {name} i fish I eating bread";
}
