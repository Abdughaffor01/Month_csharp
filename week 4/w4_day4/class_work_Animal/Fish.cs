namespace class_work_Animal;

public class Fish:Animal,IPet
{
   public Fish(string name):base(name)=>base.legs=0;
   public string GetName() => base.name;
   public void SetName(string name) => base.name = name;
   public string Play() => $"I fish i playing";
   public override string Walk() => $"Heloo i am {name} i fish  walking";
   public override string Eat() => $"Heloo i am {name} i fish eating";
}
