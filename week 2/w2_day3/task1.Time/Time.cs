namespace task1.Time;

public class Time
{
   int second;
   int minute;
   int hour;
   public Time()
   {
      second = DateTime.Now.Second;
      minute = DateTime.Now.Minute;
      hour = DateTime.Now.Hour;
   }
   public Time(int hour, int minute, int second)
   {
      if ((hour >= 0 && hour <= 12) && (minute >= 0 && minute <= 60) && (second >= 0 && second <= 60))
      {
         this.second = second;
         this.minute = minute;
         this.hour = hour;
      }
      else System.Console.WriteLine("Неправилно ввели время");
   }
   public void print()
   {
      System.Console.WriteLine($"{hour}:{minute}:{second}");
   }
   public int getHour()
   {
      return hour;
   }
   public int getMinute()
   {
      return minute;
   }
   public int getSecond()
   {
      return second;
   }
   public void setHour(int hour)
   {
      if (hour >= 0 && hour < 13) this.hour = hour;
      else System.Console.WriteLine("Неправилно ввели часу");
   }
   public void setMinute(int minute)
   {
      if (minute >= 0 && minute < 61) this.minute = minute;
      else System.Console.WriteLine("Неправилно ввели минуту");
   }
   public void setSecond(int second)
   {
      if (second >= 0 && second < 61) this.second = second;
      else System.Console.WriteLine("Неправилно ввели секунду");
   }
   public string toString()
   {
      return $"{hour / 10}{hour % 10}:{minute / 10}{minute % 10}:{second / 10}{second % 10}";
   }
   public void setTime(int hour, int minute, int second)
   {
      if ((hour >= 0 && hour <= 12) && (minute >= 0 && minute <= 60) && (second >= 0 && second <= 60))
      {
         this.second = second;
         this.minute = minute;
         this.hour = hour;
      }
      else System.Console.WriteLine("Неправилно ввели время");
   }

   public Time nextSecond()
   {
      ++second;
      if (second >= 60)
      {
         second = 0;
         ++minute;
         if (minute >= 60)
         {
            minute = 0;
            ++hour;
            if (hour >= 24)
            {
               hour = 0;
            }
         }
      }
      return this;                    
   }
}
