namespace task1_animal;

public class Spider : Pet
{
   string name;
   public Spider(string name) : base(8) => this.name = name;
   public override string Walk() => $"I am spider my name is {name} i walking in forest";
   public override string Eat() => $"I am spider my name is {name} i eating ant";
   public override string GetName()=>name;
   public override void SetName(string name)=>this.name=name;
   public override string Play()=>$"I am cat my name is {name} i playing gta and assassins creed";
}
