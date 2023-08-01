public class Post
{
   public string Title { get; set; }
   public string Description { get; set; }
   public DateTime DateTime { get; set; }

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
      Console.WriteLine($"coment title}");
      foreach (var a in list)
      {
         Console.WriteLine(a);
      }
   }
}