public class Author{
   string a_name;
   string a_email;
   char a_gender;
   public Author(string name,string email,char gender)
   {
      a_name=name;
      a_email=email;
      a_gender=gender;
   }
   public void SetEmail(string email)=> a_email=email;

   public virtual string ToString()=> $"{a_name} ({a_gender}) at {a_email}";

}