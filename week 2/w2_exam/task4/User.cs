namespace task4;

public class User
{
   List<User> list=new List<User>();
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string UserName { get; set; }
   public string Password { get; set; }
   public void GetInfo(){
      foreach (var i in list)
      {
      Console.WriteLine($"FirstName : {i.FirstName}");
      Console.WriteLine($"LastName : {i.LastName}");
      Console.WriteLine($"UserName : {i.UserName}");
      Console.WriteLine($"Password : {i.Password}");
      Console.WriteLine();
      }
   }
   public string Login(string username,string password){
      var userss=list.Find(x => x.UserName==username && x.Password==password);
      if(userss==null){
         return ("Login Failed");
      }
      return $"Login successful! Welcome mister {userss.FirstName} , {userss.LastName}";

   }
   public void AddUser(User user){
      list.Add(user);
   }
}
