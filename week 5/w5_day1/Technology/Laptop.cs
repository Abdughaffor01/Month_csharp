namespace Technology;

public class Laptop:Computer
{
   public double weight;
   public Laptop(double weight)
   {
      this.weight=weight;
   }
    public string WeightChec(){
      if(weight>3) return $"Ноутбуктай ё мощин";
      if(weight<1) return $"Ноутбукай ё телфон";
      else return $"Гап нест ноутбукда";
    }
}
