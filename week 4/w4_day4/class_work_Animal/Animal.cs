namespace class_work_Animal;

public class Animal
{
   protected int legs;
   protected string name;
   public Animal()=>this.legs = 0;
   public Animal(string name)
   {
      this.name = name;
      this.legs=0;
   }
   public virtual string Walk() => $"Heloo i am {name} i animal  walking";
   public virtual string Eat() => $"Heloo i am {name} i animal eating";
}
