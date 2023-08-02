public abstract class Animal
{
   int legs;
   public Animal(int legs) => this.legs = legs;
   public abstract string Walk();
   public abstract string Eat();
}
