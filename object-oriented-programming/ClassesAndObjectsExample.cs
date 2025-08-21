namespace ObjectOrientedProgramming;
public class ProgrammingLanguage
{
    private string _name;
    private string _version;
    private int _yearCreated;

    public ProgrammingLanguage(string name, string version, int yearCreated)
    {
        this._name = name;
        this._version = version;
        this._yearCreated = yearCreated;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Language: {this._name}");
        Console.WriteLine($"Version: {this._version}");
        Console.WriteLine($"Year Created: {this._yearCreated}");
    }

    public string GetName()
    {
        return this._name;
    }

    public string GetVersion()
    {
        return this._version;
    }

    public int GetYearCreated()
    {
        return this._yearCreated;
    }

    public void SetVersion(string version)
    {
        if (!string.IsNullOrEmpty(version))
        {
            this._version = version;
        }
    }
}

public class ClassesAndObjectsExample
{
    public static void DisplayClassesAndObjects()
    {
        // This code demonstrates the use of classes and objects;

        // Create instances of programming languages
        ProgrammingLanguage csharp = new ProgrammingLanguage("C#", "13.0", 2000);

        // To call the methods of an instance, you can follow this pattern: {objectName}.{MethodName}();
        csharp.DisplayInfo();

        ProgrammingLanguage python = new ProgrammingLanguage("Python", "3.11", 1991);
        python.DisplayInfo();

        Console.WriteLine($"The programming language {csharp.GetName()} is at version {csharp.GetVersion()} and was created in {csharp.GetYearCreated()}.");
        Console.WriteLine($"The programming language {python.GetName()} is at version {python.GetVersion()} and was created in {python.GetYearCreated()}.");
    }
}