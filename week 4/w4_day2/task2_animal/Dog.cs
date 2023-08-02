namespace task2_animal;

public class Dog : Canis
{
   public Dog() { }
   public Dog(string name)
   {
      SetName(name);
      SetLegs(4);
   }
   public override string GetSound() => $"I dog my name is {GetName()} haf haf haf";
   public override bool IsScary() => true;
   public override string ToString() => $"My name is {GetName()} i am {GetLegs()} legs i is scary";
}
