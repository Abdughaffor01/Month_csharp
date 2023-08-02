using task1_animal;

public class Cat : Pet
{
   string name;
   public Cat(string name) : base(4) => this.name = name;
   public override string GetName()=>name;
   public override void SetName(string name)=>this.name=name;
   public override string Play()=>$"I am cat my name is {name} i playing gta and assassins creed";
   public override string Walk() => $"I am cat my name is {name} i walking in city";
   public override string Eat() => $"I am cat my name is {name} i eat mouse";

}
