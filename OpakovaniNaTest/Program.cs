namespace MyNamespace;

class Program
{
    // 3.Pole (Lodě
    public static void DrawBoard(int[] arr, bool isVisible)
    {
        char[] symbols = { 'w', 'P', 'L', 'D'};
        foreach (var prvek in arr)
        {
            if (isVisible)
            {
                Console.WriteLine(symbols[prvek]);   
            }
            else
            {
                Console.WriteLine(symbols[0]);
            }
        }

        Console.WriteLine();
    }
    
    public static void Main(string[] args)
    {
        // 1. Jednoduchá třída
        var Kytara = new Guitar(24, "SCHECTER PT-8 MS Black Ops", "Eben");
        Kytara.PrintInfo();
        Kytara.PrintInfo();
        Kytara.PrintInfo();
        
        // 2. Komplikovanější třída
        var cd = new Coder(1);
        cd.Encode("ahoj");
        cd.Decode("Pizza");

        // 3.Pole (Lodě
        var board = new int[20];
        var rng = new Random();
        board[rng.Next(0, board.Length)] = 3;
        board[rng.Next(0, board.Length)] = 2;
        board[rng.Next(0, board.Length)] = 1;
        
        // board[2] = 3;
        // board[5] = 1;
        // board[13] = 2;

        while (true)
        {
            DrawBoard(board, false);
            Console.WriteLine("Vyber si poličko, které chceš zničit");
            int pos = int.Parse(Console.ReadLine()!);
            if (board[pos - 1] != 0)
            {
                Console.WriteLine("Good job!");
            }
            else
            {
                Console.WriteLine("Better luck next time :-C");
            }
        }
        
    }
}