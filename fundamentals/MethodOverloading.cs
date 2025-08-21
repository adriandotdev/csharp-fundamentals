namespace Fundamentals;

/**
*   Method overlaoding allow you to define multiple methods with the same name but different parameters.
*   This is useful for creating methods that perform similar operations but with different types or numbers of parameters.
*   In this example, we will create a class with overloaded methods to display information about a person.
*/
public class MethodOverloading
{
    public static void DisplayInfo(string name)
    {
        Console.WriteLine($"Name: {name}");
    }

    public static void DisplayInfo(int age)
    {
        Console.WriteLine($"Age: {age}");
    }

    public static void DisplayInfo(float height)
    {
        Console.WriteLine($"Height: {height} m");
    }

    public static void DisplayInfo(double weight)
    {
        Console.WriteLine($"Weight: {weight} kg");
    }
}