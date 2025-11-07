namespace MyNamespace;

public class PasswordGenerator
{
    // <---------------------- Vlastnosti třídy ---------------------->
    public int Length { get; set; }
    public bool UseNumbers { get; set; }
    public bool UseSpecialChars  { get; set; }
    
    private static Random rng = new Random();
    
    // <---------------------- Konstruktor třídy ---------------------->
    public PasswordGenerator(int length, bool useNumbers, bool useSpecialChars)
    {
        Length = length;
        UseNumbers = useNumbers;
        UseSpecialChars = useSpecialChars;
    }
    
    // <---------------------- Metoda pro generování hesla ---------------------->
    public string Generate()
    {
        string lowerLetters = "abcdefghijklmnopqrstuvwxyz";
        string upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "0123456789";
        string special = "!@#$%";
        
        string allChars  = lowerLetters + upperLetters;
        
        if (UseNumbers)
        {
            allChars += numbers;
        }
        
        if (UseSpecialChars)
        {
            allChars += special;
        }
        
        string password = "";
        
        for (int i = 0; i < Length; i++)
        {
            int index = rng.Next(allChars.Length);
            password += allChars[index];
        }
        
        return password;
    }
    
    // <---------------------- Metoda pro vypsání hesla do konzole ---------------------->
    public void PrintPassword()
    {
        string password = Generate();
        Console.WriteLine($"Vygenerované heslo: {password}");
    }
}