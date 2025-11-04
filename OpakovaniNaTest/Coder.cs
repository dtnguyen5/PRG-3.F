namespace MyNamespace;

public class Coder
{
    private int _secret;

    public Coder(int secret)
    {
        _secret = secret;
    }

    public void Encode(string input)
    {
        input = input.ToLower();
        
        // ´a´ -> ´d´;
        // ´a´ posunuty o secret = ´d´
        foreach (var ch in input)
        {
            int hodnota = 'a' + _secret;
            char output = (char)hodnota;
            Console.WriteLine(output);   
        }
    }

    public void Decode(string input)
    {
        
    }
}