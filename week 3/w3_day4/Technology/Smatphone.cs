namespace Technology;

public class Smatphone:Computer
{
   int countSelf=0;
   public void TakeSelf(){
      countSelf++;
   }
   public int CountSelf()=> countSelf;
}
