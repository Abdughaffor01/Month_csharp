namespace class_work_Animal;
public class Cat : Animal, IPet
{
   public Cat(string name) : base(name) => base.legs = 4;
   public Cat() {}
   public string GetName() => name;
   public void SetName(string name) =>base.name = name;
   public string Play() => $"I cat i playing";
   public override string Eat() => $"Heloo i am {name} i cat eating";
}
