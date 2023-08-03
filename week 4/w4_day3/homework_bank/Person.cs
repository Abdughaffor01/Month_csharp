public class Person
{
   string name;
   public Person() => name = "No name yet.";
   public Person(string name) => this.name = name;
   public void SetName(string newName) => name = newName;
   public string GetName() => name;
   public string ToString() => $"Name: {name}";
   public bool Equals(Object p) => name.Equals(p);
}