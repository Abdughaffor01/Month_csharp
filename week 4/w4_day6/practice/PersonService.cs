namespace practice;

public class PersonService:Person
{
   List<Person> persons = new List<Person>();
   public List<Person> GetPersons() => persons;
   public void AddPerson(Person person) => persons.Add(person);
   public void UpdatePerson(Person person)
   {
      var personup = persons.FirstOrDefault(x => x.Id == person.Id);
      personup.FirstName = person.FirstName;
      personup.LastName = person.LastName;
      personup.Age = person.Age;
   }
   public void RemovePerson(int id)
   {
      var personup = persons.FirstOrDefault(x => x.Id == id);
      persons.Remove(personup);
   }
   public Person PersonGetById(int id)
   {
      var personup = persons.FirstOrDefault(x => x.Id == id);
      if (personup == null) System.Console.WriteLine("Нету данни по вашу запрос");
      return personup;
   }
}
