using System;
namespace task2.Acount;

public class Acount
{
   int number;
   double balance;
   public Acount(int number)
   {
      this.number = number;
   }
   public Acount(int number, double balance)
   {
      this.number = number;
      this.balance = balance;
   }
   public int getNumber()
   {
      return number;
   }
   public double getBalance()
   {
      return balance;
   }
   public string toString()
   {
      return $"Account [ number = {number} , balance = {balance} ]";
   }
   public void credit(double amount)
   {
      balance += amount;
   }
   public void debit(double amount)
   {
      if (balance >= amount) balance -= amount;
      else Console.WriteLine("amount exeeded");
   }
   public void transferTo(double amount,Acount sum )
   {
      if (balance >= amount)
      {
         balance -= amount;
         sum.credit(amount);
      }
      else Console.WriteLine("Маблаг кофи нест");
   }
}
