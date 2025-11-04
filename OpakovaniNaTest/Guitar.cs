namespace MyNamespace;

public class Guitar
{
    public int NumberOfStrings { get; set; }
    public string Name { get; set; }
    public string Material { get; set; }

    public Guitar(int numberOfStrings, string name, string material)
    {
        NumberOfStrings = numberOfStrings;
        Name = name;
        Material = material;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Název: {Name}, Počet strun: {NumberOfStrings}, Materiál: {Material}");
    }

}