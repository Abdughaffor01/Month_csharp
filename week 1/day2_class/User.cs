public class User
{

   public string FirstName;
   public string LastName;
   public string UserName;
   public string Password;
   public bool IsLoggedOn;
   public void Login(string username, string password)
   {
      if (UserName == username && Password == password)
      {
         System.Console.WriteLine("Пользователь успешно зарегистрирован");
         IsLoggedOn = true;
      }
      else
      {
         System.Console.WriteLine("Ваш пароль или имя пользователя неверны");
      }
   }
   public void Logout()
   {
      IsLoggedOn = false;
   }
   public string GetFullInfo(){
       return ($"{FirstName} {LastName} - {IsLoggedOn}");
   }

}