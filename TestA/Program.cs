namespace MyNamespace;

class Prorgram
{
    public static void Main(string[] args)
    {
        // úkol 1
        Light l1 = new Light("Koupelna", false);
        l1.Toggle(); // v Koupelna svítí světlo.
        l1.Toggle(); // v Koupelna nesvítí světlo.

        // úkol 2
        int[] board = { 0, 1, 0,
                        2, 0, 1,
                        0, 2, 0 };

        for (int i = 0; i < board.Length; i++)
        {
            Console.Write("| ");
            switch (board[i])
            {
                case 0:
                    Console.Write("_");
                    break;
                case 1:
                    Console.Write("X");
                    break;
                case 2:
                    Console.Write("O");
                    break;
            }
            Console.Write(" ");

            // Nový řádek po každých 3 polích
            if ((i + 1) % 3 == 0)
            {
                Console.WriteLine("|");
            }
            
            // úkol 3
            var conv = new Converter();
            string binary = conv.HexToBin("3F"); // "111111"
            int dec = conv.BinToDec("1110"); // 14
            string hex = conv.DecToHex(255); // "FF"
        } 
    } 
} 
