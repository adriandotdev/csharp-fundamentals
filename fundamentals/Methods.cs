namespace Fundamentals;

/**
 PLEASE READ:
 To use this file in Program.cs, just instantiate the Methods class.
  
  new Methods();
*/
public class Methods
{
    // Example of non-returning (void) method.
    public static void DisplayName()
    {
        Console.WriteLine("Hello, John Doe!");
    }

    // Example of parameterized method.
    public static void DisplayName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    // Example of method with return type.
    public static string GetGreeting(string name)
    {
        return $"Hello, {name}!";
    }
}