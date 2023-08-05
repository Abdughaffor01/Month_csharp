namespace Vihiclee;
public class Car : IVehicle
{
   int amount;
   public Car(int amount) => this.amount = amount;
   void SetAmoung(int amount) => this.amount = amount;
   public void Drive()
   {
      while (true)
      {
         amount--;
         Thread.Sleep(100);
         if (this.amount > 0) Console.WriteLine($"Refuel={amount} Driving");
         if (amount == 0)
         {
            while (true)
            {
               Console.Beep();
               Console.Beep();
               Console.Beep();
               Console.WriteLine($"Refuel={amount} power car ");
               Console.Write("please refuel : ");
               SetAmoung(Convert.ToInt32(Console.ReadLine()));
               if(amount>0)break;
            }
         }
      }
   }
   public bool Refuel(int amount)
   {
      if ((this.amount + amount) > this.amount)
      {
         this.amount += amount;
         return true;
      }
      return false;
   }
}
