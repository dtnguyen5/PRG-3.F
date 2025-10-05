namespace MyNamespace;

class program
{
    private static bool EndsWithSuffix(string input, string suffix)
    {
        // input.EndsWith(suffix);

        if (suffix.Length > input.Length)
        {
            return false;
        }

        for (int i = 0; i < suffix.Length; i++)
        {
            if (input[input.Length - 1 - i] == suffix[suffix.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
    
    private static string ToTitleCase(string input)
    {
        var slova = input.Split(" ");

        string celek = "";

        foreach (var slovo in slova)
        {
            // převést slovo na -> Slovo
            char capilatised = (char) (slovo[0] - 32);
            celek += capilatised + slovo.Substring(1);
        }
        return celek.TrimEnd();
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine(EndsWithSuffix("Ahoj.txt", "aaaaaaaaaahoj.txt"));
    }
}