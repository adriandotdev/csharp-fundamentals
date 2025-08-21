public class Employee
{
    private decimal _salary;

    private string _position = string.Empty;

    public string Name { get; }

    public Employee(string name, string position, decimal salary)
    {
        Name = name;
        Position = position;
        Salary = salary; 
    }

    public decimal Salary
    {
        get { return _salary; }

        set
        {

            if (value < 0)
            {
                throw new ArgumentException("Salary cannot be negative.");
            }

            _salary = value;
        }

    }

    public string Position
    {
        get { return _position; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Position cannot be null or empty.");
            }
            _position = value;
        }
    }

    public virtual void Work()
    {
        Console.WriteLine($"{Name} is working as a {Position}.");    
    }

    public override string ToString()
    {
        return $"Name: {Name}, Position: {Position}, Salary: {Salary:C}";
    }
}

public class SoftwareEngineer : Employee
{
    private static readonly string POSITION = "Software Engineer";
    private readonly List<string> _techStacks;

    public SoftwareEngineer(string name, decimal salary, List<string> techStacks) : base(name, POSITION, salary)
    {
        this._techStacks = techStacks;
    }


    public override void Work()
    {
        base.Work();
        Console.WriteLine($"{Name} is proficient in: {string.Join(", ", _techStacks)}.");
    }

    public void AddTechStack(string techStack)
    {
        if (string.IsNullOrWhiteSpace(techStack))
        {
            throw new ArgumentException("Tech stack cannot be null or empty.");
        }

        this._techStacks.Add(techStack);
    }

    public override string ToString()
    {
        return base.ToString() + $", Programming Languages: {string.Join(", ", _techStacks)}";
    }
}

public class InheritanceExample
{

    public static void DisplayInheritanceExample()
    {
        // Create an instance of Employee with type of SoftwareEngineer
        Employee employee = new SoftwareEngineer("John", 80_000, ["JavaScript", "C#", "Python"]);
        employee.Work();
        Console.WriteLine(employee.ToString());
        ((SoftwareEngineer)employee).AddTechStack("TypeScript");
        employee.Position = "Senior Software Engineer"; // Change position
        employee.Salary = 90_000; // Change salary
        Console.WriteLine(employee.ToString());
    }
}