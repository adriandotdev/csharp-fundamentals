namespace Fundamentals;

public class LINQ
{
    public static void DisplayLINQExample()
    {

        var employees = new List<Employee>()
        {
            new SoftwareEngineer("Alice", 80000, ["C#", "JavaScript" ]),
            new("Bob", "Manager", 90000),
            new SoftwareEngineer("Charlie", 75000, ["Python", "Java"]),
            new("Diana", "HR", 60000),
            new SoftwareEngineer("Eve", 85000, ["Go", "Rust"]),
            new("Frank", "Intern", 30000),
            new("Arian", "Sales & Marketing Associate", 30000),
        };

        // Filtering using .Where(predicate)
        Console.WriteLine();
        Console.WriteLine("Filtering using .Where(predicate)");
        employees
            .Where(e => e.Salary > 60_000)
            .OrderByDescending(e => e.Salary)
            .Select(e => e)
            .ToList()
            .ForEach(Console.WriteLine);

        // Projection using .Select
        Console.WriteLine();
        Console.WriteLine("Projection using .Select()");
        employees
        .Select(e => new
        {
            e.Name,
            SalaryWithTaxDeduction = e.Salary - 0.10m
        })
        .ToList()
        .ForEach(Console.WriteLine);

        Console.WriteLine();
        Console.WriteLine("Sorting: .OrderBy");
        employees
            .Select(e => e.Salary)
            .OrderBy(salary => salary)
            .ToList()
            .ForEach(Console.WriteLine);

        Console.WriteLine();
        Console.WriteLine("Sorting: .OrderByDescending");
        employees
            .Select(e => e.Salary)
            .OrderByDescending(salary => salary)
            .ToList()
            .ForEach(Console.WriteLine);

        Console.WriteLine();
        Console.WriteLine("Sorting: .ThenBy (Example: If same salary then sort (ascending) by name)");
        employees
            .Select(e => new
            {
                e.Name,
                e.Salary
            })
            .OrderBy(e => e.Salary)
            .ThenBy(e => e.Name)
            .ToList()
            .ForEach(Console.WriteLine);

        Console.WriteLine();
        Console.WriteLine("Sorting: .ThenByDescending (Example: If same salary then sort (descending) by name)");
        employees
            .Select(e => new
            {
                e.Name,
                e.Salary
            })
            .OrderBy(e => e.Salary)
            .ThenByDescending(e => e.Name)
            .ToList()
            .ForEach(Console.WriteLine);

        // Display all employee positions with sum of its total salary
        Console.WriteLine();
        Console.WriteLine("Grouping: Display all employee positions with sum of its total salary");
        employees.GroupBy(e => e.Position)
        .Select(group => new
        {
            Position = group.Key,
            TotalSalary = group.Sum(e => e.Salary)
        })
        .OrderByDescending(e => e.TotalSalary)
        .ToList()
        .ForEach(Console.WriteLine);

        Console.WriteLine();
        Console.WriteLine("==== Quantifiers ====");

        Console.WriteLine();
        Console.WriteLine("Set Operation: Any");
        Console.WriteLine($"Employee who has 30k salary: {employees.Any(e => e.Salary == 30000)}");
        Console.WriteLine($"Check if company has an intern: {employees.Contains(new SoftwareEngineer("Charlie", 75000, ["Python", "Java"]))}");

        Console.WriteLine();
        Console.WriteLine("==== Aggregation ====");
        Console.WriteLine($"Total of all employees salaries: {employees.Sum(e => e.Salary):C}");
        Console.WriteLine($"Highest Salary: {employees.Max(e => e.Salary):C}");
        Console.WriteLine($"Lowest Salary excluding Intern {employees.Where(e => e.Position != "Intern").Min(e => e.Salary):C}");
        Console.WriteLine($"Average salaries of all Software Engineers: {employees.Select(e => e.Salary).Average(e => e):C2}");


        Console.WriteLine();
        Console.WriteLine("==== Element Operators ====");

        Console.WriteLine("\nUsing FirstOrDefault()");
        var employeeWithSalaryOfSixtyThousands = employees.FirstOrDefault(e => e.Salary == 620000, new("N/A", "N/A", 0));

        Console.WriteLine($"Employee with 60000: {employeeWithSalaryOfSixtyThousands}");
    }
}