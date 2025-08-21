namespace Fundamentals;
public class DataTypes
{
    public static void DisplaySampleDataTypes()
    {
        // Copy and paste this code into Program.cs
        // This code demonstrates the use of various data types in C# 13.0

        string name = "John Doe";
        int age = 99;
        float height = 1.85f;
        double weight = 45.5;
        decimal accountBalance = 123456.78m;
        bool isActive = true;
        char initial = 'J';
        string[] hobbies = ["Reading", "Programming", "Traveling"];

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height} m");
        Console.WriteLine($"Weight: {weight} kg");
        Console.WriteLine($"Account Balance: {accountBalance:C}");
        Console.WriteLine($"Active User: {isActive}");
        Console.WriteLine($"Initial: {initial}");
        Console.WriteLine("Hobbies: " + string.Concat(string.Join(", ", hobbies), "  and more..."));
    }
}