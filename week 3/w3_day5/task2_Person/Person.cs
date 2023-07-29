namespace task2_Person;

public class Person
{
   public string  Name { get; set; }
   public string  Addres { get; set; }
   public Person(string name,string addres)
   {
      Name=name;
      Addres=addres;
   }
   public void SetAddres(string addres){
      Addres=addres;
   }
   public override string ToString()
   {
      return $"{Name}({Addres})";
   }
}

