namespace task1_Employee
{
    public class Employee
    {
        int id;
        string firstName;
        string lastName;
        int salary;
        public Employee(int id,string firstname,string lastname,int salary)
        {
            this.id = id;
            firstName = firstname;
            lastName = lastname;
            this.salary = salary;
        }
        public int GetId() => id;
        public string GetFirstname() => firstName;
        public string GetLastname()=>lastName;
        public string GetName() => $"{firstName} {lastName}";
        public int GetSalary()=>salary;
        public void SetSalary(int salary)=>this.salary = salary;
        public int GetAnnualSalary() => salary * 12;
        public int RaiseSalary(int persent) => salary += (salary * persent / 100);
        public override string ToString() => $"Employee[id={id}, name={firstName} {lastName}, salary={salary}]";
    }
}
