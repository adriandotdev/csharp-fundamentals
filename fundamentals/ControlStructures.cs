public class ControlStructures
{
    
    public static void DisplayControlStructures()
    {
        // This code demonstrates the use of control structures in C# 13.0

        int number = 10;

        // If-Else statement
        if (number > 0)
        {
            Console.WriteLine($"{number} is a positive number.");
        }
        else if (number < 0)
        {
            Console.WriteLine($"{number} is a negative number.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        // Switch statement
        switch (number)
        {
            case 0:
                Console.WriteLine("The number is zero.");
                break;
            case > 0:
                Console.WriteLine($"{number} is a positive number.");
                break;
            default:
                Console.WriteLine($"{number} is a negative number.");
                break;
        }

        // For loop
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }

        // While loop
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine($"Count is {count}");
            count++;
        }

        // Do-While loop
        count = 0;
        do
        {
            Console.WriteLine($"Count is {count}");
            count++;
        } while (count < 5);

        // Foreach loop
        string[] fruits = { "Apple", "Banana", "Cherry" };
        foreach (var fruit in fruits)
        {
            Console.WriteLine($"Fruit: {fruit}");
        }
    }
}