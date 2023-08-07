namespace Technology;
public abstract class  Computer
{
   public int Ram { get; set; }
   public int Storage { get; set; }
   public string Keyboard { get; set; }
   public virtual void AddRam(int ram){}
   public virtual void AddStorage(int ram){}
}
