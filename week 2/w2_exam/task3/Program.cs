using task3;
while (true){
   Console.Write("The first number is: ");
   int firstnum=Convert.ToInt32(Console.ReadLine());
   Console.Write("The operation is: ");
   char operat= Convert.ToChar(Console.ReadLine());
   Console.Write("The second number is: ");
   int secondnum= Convert.ToInt32(Console.ReadLine());;
   Calculator cal=new Calculator(firstnum,secondnum);
   if(operat=='+'){
      Console.WriteLine(cal.Sum());
   }else if(operat=='-'){
      Console.WriteLine(cal.Subtract());
   }else if(operat=='*'){
      Console.WriteLine(cal.Multiplication());
   }else if(operat=='/'){
      Console.WriteLine(cal.Division());
   }
   Console.WriteLine();
}
