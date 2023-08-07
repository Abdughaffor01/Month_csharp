namespace Technology;
public class Laptop : Computer
{
   public double weight;
   public Laptop(double weight) => this.weight = weight;
   public string WeightChec()
   {
      if (weight > 3) return $"Ноутбукай ё мощин";
      if (weight < 1) return $"Ноутбукай ё телфон";
      else return $"Гап нест ноутбукда";
   }
   public override void AddRam(int ram)=>Ram=ram;
   public override void AddStorage(int storage)=>Storage=storage;
}
