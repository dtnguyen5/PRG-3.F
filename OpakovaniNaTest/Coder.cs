namespace MyNamespace;

public class Coder
{
    private int _secret;

    public Coder(int secret)
    {
        _secret = secret;
        // _secret = secret % ('z' - 'a') + 1;
    }

    public void Encode(string input)
    {
        input = input.ToLower();
        
        // ´a´ -> ´d´;
        // ´a´ posunuty o secret = ´d´
        foreach (var ch in input)
        {
            // int hodnota = 'a' + _secret;
            // char output = (char)hodnota;
            // Console.WriteLine(output);

            char znak = (char)(ch + _secret);
            if (znak > 'z')
            {
                int pretek = znak - 'z';
                Console.Write((char)('a' + pretek));
            }
            else
            {
                Console.WriteLine(znak);
            }
            
        }
        Console.WriteLine();
    }

    public void Decode(string input)
    {
        input = input.ToLower();
        
        foreach (var ch in input)
        {
            char znak = (char)(ch - _secret);
            if (znak < 'a')
            {
                int pretek = 'a' - znak;
                Console.Write((char)('z' - pretek));
            }
            else
            {
                Console.WriteLine(znak);
            }
            
        }
        Console.WriteLine();
    }
}