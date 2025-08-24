public class Student
{
    private int id;
    private string firstName;
    private string lastName;
    public static string program = "BSCS";

    private static Random random = new Random();
    
    public Student(string firstName, string lastName)
    {
        this.id = Student.GenerateRandomId(); // Can be access like this ClassName.MethodName()
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public Student(int id, string firstName, string lastName)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    // Getters
    public int GetId()
    {
        return this.id;
    }

    public string GetFirstName()
    {
        return this.firstName;
    }

    public string GetLastName()
    {
        return this.lastName;
    }

    // Setters
    public void SetId(int id)
    {
        this.id = id;
    }

    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("ID : " + this.id);
        Console.WriteLine("FULL NAME : " + this.GetFullName());
        Console.WriteLine($"Program: {Student.program}");
    }

    public string GetFullName()
    {
        return this.firstName + " " + this.lastName;
    }

    public void PayTuition(double amount)
    {
        Console.WriteLine($"You paid {amount} pesos");
    }

    private static int GenerateRandomId()
    {
        return random.Next(1000, 9999);
    }

    public static void PrintClassName()
    {
        Console.WriteLine("Student");
    }
}