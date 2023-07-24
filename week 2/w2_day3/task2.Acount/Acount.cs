using System;
namespace task2.Acount;

public class Acount
{
   int number;
   decimal balance;
   public Acount(int number)
   {
      this.number = number;
   }
   public Acount(int number, decimal balance)
   {
      this.number = number;
      this.balance = balance;
   }
   public int getNumber()
   {
      return number;
   }
   public decimal getBalance()
   {
      return balance;
   }
   public string toString()
   {
      return $"Account [ number = {number} , balance = {balance} ]";
   }
   public void credit(decimal amount)
   {
      balance += amount;
   }
   public void debit(decimal amount)
   {
      if (balance >= amount) balance -= amount;
      else Console.WriteLine("amount exeeded");
   }
   public void transferTo(decimal amount,Acount sum )
   {
      if (balance >= amount)
      {
         balance -= amount;
         sum.credit(amount);
      }
      else Console.WriteLine("Маблаг кофи нест");
   }
}
