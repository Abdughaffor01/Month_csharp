public class BirdCount
{
   int[] _week;
   public BirdCount(int[] week)
   {
      _week = week;
   }
   public void LastWeek()
   {
      foreach (var e in _week)
      {
         Console.Write(e + " ");
      }
      Console.WriteLine();
   }
   public void Today()
   {
      Console.WriteLine("посетивших ваш сад сегодня: " + _week[_week.Length - 1]);
   }
   public void IncrementTodaysCount()
   {
      _week[_week.Length - 1]++;
   }
   public bool HasDayWithoutBirds()
   {
      foreach (var i in _week)
      {
         if (i == 0) return true;
      }
      return false;
   }
   public void CountForFirstDays(int a){
      int b=0;
      for (int i = 0; i < a; i++)
      {
         b+=_week[i];
      }
      Console.WriteLine($"За {a} дней {b} птиц посетивших ваш сад");
   }
   public void BusyDays(){
      int a=0;
      foreach (var i in _week)
      {
         if(i>4)a++;
      }
      Console.WriteLine("Загруженных дней: "+a);
   }
}