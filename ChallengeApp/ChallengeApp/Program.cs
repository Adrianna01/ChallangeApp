using ChallengeApp;
using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee1 = new Employee("Artur", "Kowalski", "32");
        Employee employee2 = new Employee("Anna", "Nowak", "28");
        Employee employee3 = new Employee("Sylwia", "Mak", "40");



        employee1.AddScore(6);
        employee1.AddScore(3);
        employee1.AddScore(5);
        employee1.AddScore(5);
        employee1.AddScore(9);

        employee2.AddScore(6);
        employee2.AddScore(8);
        employee2.AddScore(5);
        employee2.AddScore(8);
        employee2.AddScore(9);

        employee3.AddScore(7);
        employee3.AddScore(8);
        employee3.AddScore(6);
        employee3.AddScore(9);
        employee3.AddScore(9);

        int result1 = employee1.Result;
        int result2 = employee2.Result;
        int result3 = employee3.Result;



        List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3

};

        var maxResult = 0;
        Employee employeeWithMaxResult = null;

        foreach (var employee in employees)
        {
            if (employee.Result > maxResult)
            {
                employeeWithMaxResult = employee;
            }
        }

        Console.WriteLine(" The best result:\n" + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + ",lat " + employeeWithMaxResult.Age+ "\n"+ "Result:  " + employeeWithMaxResult.Result);
        
    }
}

class Employee
{
   
    private List<int> score = new List<int>();

    public Employee(string name, string surname, string age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }

    public string Name { get; private set; }

    public string Surname{ get; private set; }

    public string Age { get; private set; }
    public int Result

    {
        get
        {
            return this.score.Sum();
        }
    }
    public void AddScore(int result)
    {
        this.score.Add(result);
    }
}
