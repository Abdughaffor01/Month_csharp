namespace Bank
{
   public class Bank
   {
      string id;
      public int id_number = 0;
      public string[] myId = new string[]{};
      public string[] myName = new string[]{};
      public string[] myAccType = new string[]{};
      public string[] myDob = new string[]{};
      public string[] myNominee = new string[]{};
      public double[] myBalance = new double[]{};
      IDGENERATOR id1 = new IDGENERATOR();
      DOB dob = new DOB();
      Credit cr = new Credit();
      Debit db = new Debit();
      Savings sv = new Savings();
      public bool val = true;
      public bool debval = true;
      private void GetAccount(string ID)
      {
         ID = this.id;
         myId[id_number] = ID;
         id_number++;
      }
      public void showAll()
      {
         Console.WriteLine("All accounts are:\n");
         for (int i = 0; i < id_number; i++) Console.WriteLine(myId[i]);
      }
      public void showInfo()
      {
         int indexNum;
         string inId = Convert.ToString(Console.ReadLine());
         if (myId.Contains(inId))
         {
            indexNum = Array.IndexOf(myId, inId);
            Console.WriteLine("Your details: ");
            Console.WriteLine("Name: " + myName[indexNum]);
            Console.WriteLine("Id: " + myId[indexNum]);
            Console.WriteLine("Acc Type: " + myAccType[indexNum]);
            Console.WriteLine("DOB: " + myDob[indexNum]);
            Console.WriteLine("Nominee: " + myNominee[indexNum]);
            Console.WriteLine("Balance: " + myBalance[indexNum]);
         }
         else
         {
            Console.WriteLine("Your id is wrong!");
         }
      }
      public void create_account()
      {
         string accType;
         string name;
         int d, m, y;
         string nominee;
         double balance;
         int input;
         Console.WriteLine("0. Debit Account");
         Console.WriteLine("1. Credit Account");
         Console.WriteLine("2. Savings Account");
         input = Convert.ToInt32(Console.ReadLine());
         if (input == 0)
         {
            accType = "Debit";
            myAccType[id_number] = accType;
            Console.Write("Name:");
            name = Console.ReadLine();
            myName[id_number] = name;
            while (val == true)
            {
               Console.WriteLine("Enter date: (Day,month,year)");
               d = Convert.ToInt32(Console.ReadLine());
               m = Convert.ToInt32(Console.ReadLine());
               y = Convert.ToInt32(Console.ReadLine());
               dob.set(d, m, y);
               if (dob.printDate() == false)
               {
                  myDob[id_number] = Convert.ToString(d + "-" + m + "-" + y);
                  val = false;
               }
               else val = true;
            }
            val = true;
            Console.WriteLine("Enter Nominee name: ");
            nominee = Console.ReadLine();
            myNominee[id_number] = nominee;
            while (debval == true)
            {
               Console.WriteLine("Enter account balance: ");
               balance = Convert.ToDouble(Console.ReadLine());
               if (balance > db.maxBalance)
               {
                  Console.WriteLine("Debit Account max value is 100000!");
                  debval = true;
               }
               else
               {
                  myBalance[id_number] = balance;
                  debval = false;
               }
            }
            debval = true;
            Console.WriteLine("Created debit account successfully...! ");
            id = id1.generate();
            id = id + "Deb";
            Console.WriteLine("Your Account Id : " + id);
            GetAccount(id);
         }
         else if (input == 1)
         {
            accType = "Credit";
            myAccType[id_number] = accType;
            Console.Write("Name:");
            name = Convert.ToString(Console.ReadLine());
            myName[id_number] = name;
            while (val == true)
            {
               Console.WriteLine("Enter date: ");
               d = Convert.ToInt32(Console.ReadLine());
               m = Convert.ToInt32(Console.ReadLine());
               y = Convert.ToInt32(Console.ReadLine());
               dob.set(d, m, y);
               if (dob.printDate() == false)
               {
                  myDob[id_number] = Convert.ToString(d + "-" + m + "-" + y);
                  val = false;
               }
               else val = true;
            }
            val = true;
            Console.WriteLine("Enter Nominee name: ");
            nominee = Console.ReadLine();
            myNominee[id_number] = nominee;
            while (debval == true)
            {
               Console.WriteLine("Enter account balance: ");
               balance = Convert.ToDouble(Console.ReadLine());
               if (balance < cr.minBalance)
               {
                  Console.WriteLine("Credit Account's min val is -100000!");
                  debval = true;
               }
               else
               {
                  myBalance[id_number] = balance;
                  debval = false;
               }
            }
            debval = true;
            Console.WriteLine("Created Credit account successfully...! ");
            id = id1.generate();
            id = id + "Cre";
            Console.WriteLine("Your Account Id : " + id);
            GetAccount(id);
         }
         else if (input == 2)
         {
            accType = "Savings";
            myAccType[id_number] = accType;
            Console.Write("Name:");
            name = Console.ReadLine();
            myName[id_number] = name;
            while (val == true)
            {
               Console.WriteLine("Enter date: ");
               d = Convert.ToInt32(Console.ReadLine());
               m = Convert.ToInt32(Console.ReadLine());
               y = Convert.ToInt32(Console.ReadLine());
               dob.set(d, m, y);
               if (dob.printDate() == false)
               {
                  myDob[id_number] = Convert.ToString(d + ":" + m + ":" + y);
                  val = false;
               }
               else val = true;
            }
            val = true;
            Console.WriteLine("Enter Nominee name: ");
            nominee = Convert.ToString(Console.ReadLine());
            myNominee[id_number] = nominee;
            Console.WriteLine("Enter account balance: ");
            balance = Convert.ToDouble(Console.ReadLine());
            myBalance[id_number] = balance;
            Console.WriteLine("Created Savings account successfully...! ");
            id = id1.generate();
            id = id + "Sav";
            Console.WriteLine("Your Account Id : " + id);
            GetAccount(id);
         }
      }
      public void deposit()
      {
         int indexNum;
         string inId = Convert.ToString(Console.ReadLine());
         if (myId.Contains(inId))
         {
            indexNum = Array.IndexOf(myId, inId);
            Console.WriteLine("Your Balance is: " + myBalance[indexNum]);
            Console.WriteLine("How much you want to deposit: ");
            double depval = Convert.ToDouble(Console.ReadLine());
            if (myAccType[indexNum] == "Debit")
            {
               db.balance = myBalance[indexNum];
               db.deposit(depval);
               myBalance[indexNum] = db.balance;
            }
            else if (myAccType[indexNum] == "Credit")
            {
               cr.balance = myBalance[indexNum];
               cr.deposit(depval);
               myBalance[indexNum] = db.balance;
            }
            else if (myAccType[indexNum] == "Savings")
            {
               sv.balance = myBalance[indexNum];
               sv.deposit(depval);
               myBalance[indexNum] = sv.balance;
            }
         }
         else  Console.WriteLine("Your id is wrong!");
      }
      public void withdraw()
      {
         int indexNum;
         string inId = Console.ReadLine();
         if (myId.Contains(inId))
         {
            indexNum = Array.IndexOf(myId, inId);
            Console.WriteLine("Your Balance is: " + myBalance[indexNum]);
            Console.WriteLine("How much you want to withdraw: ");
            double depval = Convert.ToDouble(Console.ReadLine());
            if (myAccType[indexNum] == "Debit")
            {
               db.balance = myBalance[indexNum];
               db.withdraw(depval);
               myBalance[indexNum] = db.balance;
            }
            else if (myAccType[indexNum] == "Credit")
            {
               cr.balance = myBalance[indexNum];
               cr.withdraw(depval);
               myBalance[indexNum] = cr.balance;
            }
            else if (myAccType[indexNum] == "Savings")
            {
               sv.balance = myBalance[indexNum];
               sv.withdraw(depval);
               myBalance[indexNum] = sv.balance;
            }
         }
         else Console.WriteLine("Your id is wrong!");
      }
   }
}
