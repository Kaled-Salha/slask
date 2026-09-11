namespace simpleGit;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, Git!");
        Console.WriteLine(DoSomething("Kaled"));
    }

    static string DoSomething(string name)
    {
        return "Hello {name}...";
    }
}
