
public class Account
{
   double balance;
   int numberAcount;
   public Account(){}
   public Account(int a)
   {
      balance = 0.0;
      numberAcount = a;
   }
   public void Deposit(double sum)
   {
      if (sum > 0) balance += sum;
      else Console.WriteLine(("Account.deposit(...): " + "cannot deposit negative amount."));
   }
   public void WithDraw(double sum)
   {
      if (sum > 0) balance -= sum;
      else Console.WriteLine("Account.withdraw(...): " + "cannot withdraw negative amount.");
   }
   public double GetBalance() => balance;
   public double GetAccountNumber() => numberAcount;
   public string ToString() => $"Account  {numberAcount}  : balance = {balance}";
}