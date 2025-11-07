namespace MyNamespace;

class Program
{
    public static void Main(string[] args)
    {
        var generator = new PasswordGenerator(10, true, true);
        generator.PrintPassword();
    }
}