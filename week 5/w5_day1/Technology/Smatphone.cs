namespace Technology;
public class Smatphone:Computer
{
   int countSelf=0;
   public void TakeSelf()=>countSelf++;
   public int CountSelf()=> countSelf;
   public override void AddRam(int ram)=>Ram=ram;
   public override void AddStorage(int storage)=>Storage=storage;
}
