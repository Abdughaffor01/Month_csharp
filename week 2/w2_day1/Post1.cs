public class Post1
{
   public string Title { get; set; }
   public string Description { get; set; }
   public DateTime DateTime { get; set; }
   public void Published()
   {
      if (Title != null && Description != null && DateTime != null)
      {
         System.Console.WriteLine("Published");
      }else {
         System.Console.WriteLine("Please enter you information");
      }
   }
   public int like=0;
   public void  Like(){
     like++; 
   }
   List<string> list = new List<string>();
   public void Comment(string message)
   {
      list.Add(message);
   }
   public void PrintComment()
   {
      System.Console.WriteLine($"Коментария от {Title}");
      foreach (var e in list)
      {
         System.Console.WriteLine(e);
      }
   }
}