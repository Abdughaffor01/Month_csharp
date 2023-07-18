public class Person{
   public string FirstName;
   public string LastName;
   public int age;
   public string address;
   public string FulName(){
      return $"FirstName : {FirstName} and LastName : {LastName}";
   }
   public string Birthday(){
      // int[] year= new DateTime.Today.Split(new char[] {'.'});
      return $"My birth year is {2023-age}.";
   }
}