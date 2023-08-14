namespace Softclub.Model;
public abstract class Person
{
    public Person(string firstName, string lastName, int age, char gender, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Gender = gender;
        Adress = address;
    }
    public Person()
    {
        Id++;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public char Gender { get; set; }
    public string Adress { get; set; }
    public abstract string GetFullInfo();
    public abstract string GetFullName();
}
