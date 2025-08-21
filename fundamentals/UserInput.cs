namespace Fundamentals;

public class UserInput
{
    public static void GetUserInput()
    {

        Console.Write("Please enter your name: ");
        string? name = Console.ReadLine();

        Console.Write("Please enter your age: ");
        int.TryParse(Console.ReadLine(), out int parsedAge);

        Console.WriteLine("hehehehe");
        Console.WriteLine($"Hello, {name}! You are {parsedAge} years old.");
    }
}