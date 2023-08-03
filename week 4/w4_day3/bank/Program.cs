namespace Bank
{
   class Program
   {
      static void Main(string[] args)
      {
         int input;
         DOB dob = new DOB();
         IDGENERATOR id = new IDGENERATOR();
         Credit creat = new Credit();
         Debit debit = new Debit();
         Savings saving = new Savings();
         Bank bank = new Bank();
         Console.WriteLine("** Welcome to my Bank GHafforbank **");
         while (true)
         {
            Console.WriteLine("What you want to do:");
            Console.WriteLine("0. Create account");
            Console.WriteLine("1. Show account information");
            Console.WriteLine("2. Deposit from account");
            Console.WriteLine("3. Withdraw from account");
            Console.WriteLine("4. Show all account with id");
            Console.WriteLine("5. Clear screen");
            Console.WriteLine("6. Exit");
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 0)
            {
               Console.WriteLine("Enter account Type :");
               bank.create_account();
            }
            else if (input == 1)
            {
               Console.Write("Enter account Number :");
               bank.showInfo();
            }
            else if (input == 2)
            {
               Console.WriteLine("Enter Account Id: ");
               bank.deposit();
            }
            else if (input == 3)
            {
               Console.WriteLine("Enter Account Id: ");
               bank.withdraw();
            }
            else if (input == 4)
            {
               bank.showAll();
            }
            else if (input == 5)
            {
               Console.Clear();
            }
            else if (input == 6)
            {
               Environment.Exit(0);
            }
            Console.ReadKey();
         }
      }
   }
}