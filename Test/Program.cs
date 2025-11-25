namespace MyNamespace;

class Program
{
    public static void Main(string[] args)
    {
        // Úloha 1
        Light l1 = new Light("Koupelna", false);
        l1.Toggle();
        l1.Toggle();
        
        // Úloha 2
        int[] pole = { 0, 1, 0,
                       2, 0, 1,
                       0, 2, 0 };

        for (int i = 0; i < pole.Length; i++)
        {
            char znak;
            if (pole[i] == 1)
            {
                znak = 'X';
            }
            else if (pole[i] == 2)
            {
                znak = 'O';
            }
            else
            {
                znak = '_';
            }

            Console.Write($"| {znak} ");
            
            if ((i + 1) % 3 == 0)
            {
                Console.WriteLine("|");
            }
        }
        
        // Úloha 3 
        
    }
}