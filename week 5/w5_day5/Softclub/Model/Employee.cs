namespace Softclub.Model;
public class Employee : Person
{
    public int DepartmentId { get; set; }
    public string Position { get; set; }
    public Employee() { }
    public Employee(string firstName, string lastName, int age, char gender, string adress, string position, int departmentId) : base(firstName, lastName, age, gender, adress)
    {
        DepartmentId = departmentId;
        Position = position;
    }
    public override string GetFullInfo() => $"id={Id} [{FirstName} {LastName} [age={Age}, gender={Gender},adress={Adress},position={Position},departmentID={DepartmentId}]]";
    public override string GetFullName() => $"{FirstName} {LastName}";
}
