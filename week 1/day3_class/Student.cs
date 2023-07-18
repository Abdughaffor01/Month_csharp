public class Student
{
   public string Name;
   public int Gradle;
   public int[] Everage;

   public int Sredbal()
   {
      int sum = 0;
      foreach (var e in Everage)
      {
         sum += e;
      }
      return (sum / Everage.Length);
   }
}
