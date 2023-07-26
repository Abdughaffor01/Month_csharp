namespace task3;

public class Calculator
{
   int firstNumber { get; set; }
   int secondNumber { get; set; }
   public Calculator(int firstnumber,int secondnumber)
   {
      firstNumber=firstnumber;
      secondNumber=secondnumber;     
   }

   public string Sum(){
      return $"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}";
   }
   public string Subtract(){
      return $"{firstNumber} - {secondNumber} = {firstNumber-secondNumber}";
   }
   public string Multiplication(){
      return $"{firstNumber} * {secondNumber} = {firstNumber*secondNumber}";
   }
   public string Division(){
      return  $"{firstNumber} / {secondNumber} = {firstNumber/(double)secondNumber}";
   }

}
