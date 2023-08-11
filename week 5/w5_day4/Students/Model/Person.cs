namespace Students.Model;
public abstract class Person
{
   protected string firstName;
   protected string lastName;
   protected string city;
   protected string street;
   protected string email;
   protected string mobile;
   public string getFirstName()=>firstName;
   public void setFirstName(string firstName)=>this.firstName = firstName;
   public string getLastName()=>lastName;
   public void setLastName(string lastName)=>this.lastName = lastName;
   public string getCity()=>city;
   public void setCity(string city)=>this.city = city;
   public string getStreet()=>street;
   public void setStreet(string street)=>this.street = street;
   public string getEmail()=>email;
   public void setEmail(string email)=>this.email = email;
   public string getMobile()=>mobile;
   public void setMobile(string mobile)=>this.mobile = mobile;
   public virtual void setWorkingHours(int hours){}
   public virtual int getWorkingHours(){return 0;}
}
