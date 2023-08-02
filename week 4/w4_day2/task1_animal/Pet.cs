namespace task1_animal;

public abstract class Pet:Animal
{
   public Pet(int legs):base(legs){}
   public abstract string GetName();
   public abstract void SetName(string  name);
   public abstract string Play();

}
