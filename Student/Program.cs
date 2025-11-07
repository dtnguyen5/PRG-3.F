namespace MyNamespace;

class Program
{
    public static void Main(string[] args)
    {
        var student = new Student("Petr", new int[] { 1, 2, 1, 1, 2 });
        student.PrintResult();
    }
}