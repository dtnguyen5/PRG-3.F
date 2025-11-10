namespace MyNamespace;

public class PasswordGenerator
/*
Úloha 1 – PasswordGenerator
Zadání:
Vytvořte třídu PasswordGenerator, která slouží k vytváření náhodných hesel.

Třída má vlastnosti:    
    int Length – délka generovaného hesla
    bool UseNumbers – určuje, zda se mají používat čísla
    bool UseSpecialChars – určuje, zda se mají používat speciální znaky

Má konstruktor, který všechny tři hodnoty nastaví.

Obsahuje metodu:
    string Generate()
        vygeneruje náhodné heslo podle nastavených pravidel
        pokud UseNumbers == true, přidá do sady znaků čísla 0–9
        pokud UseSpecialChars == true, přidá i speciální znaky !@#$%
        z takto vytvořené sady znaků vygeneruje heslo délky Length

Metoda PrintPassword() vypíše heslo na konzoli.

Ukázka použití:
public class Program {
    public static void Main(string[] args){
        var generator = new PasswordGenerator(10, true, true);
        generator.PrintPassword();
    }
}
--- Konzole ---
/*
Vygenerované heslo: A7m!rK@9pQ
* /
 */
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