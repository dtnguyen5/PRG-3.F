using System.Globalization;

namespace MyNamespace;

class MyClass
{
    public static void Main(string[] args)
    {
        // (String, int) dvojice = ("Rohlík", 150);
        // Console.WriteLine(dvojice.Item1);
        // Console.WriteLine("Cena " + dvojice.Item2);
        
        // <-------------------- Lepší přehled -------------------->
        (String name, int price) dvojice = ("Rohlík", 150);
        Console.WriteLine(dvojice.name);
        Console.WriteLine("Cena " + dvojice.price);;
        
        

        (String name1, int price1)[] sortiment =
        {
            ("Rohlík", 3),
            ("Chleba", 20),
            ("Pivo - nealko", 18),
            ("Bílej monster", 30),
            ("Crazy wolf - orange", 8),
            ("Špenát-sýr burek", 12),
            ("Čučo", 10)
        };

        int pocketMoney = 0;
        Console.WriteLine("Zadejte kolik ti dala mamka na svačinu");
        pocketMoney = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Zde je náš sortiment");
        for (int i = 0; i < sortiment.Length; i++)
        {
            var item = sortiment[i];
            Console.WriteLine($"Kup si{item.name1} za {item.price1} Kč- napiš {i + 1}");
        }

        
        while (true)
        {
            int option = int.Parse(Console.ReadLine()!);
            if (option < 1 || option >= sortiment.Length)
            {
                break; // Taky vyhazov
            }
            
            var item = sortiment[option - 1];

            if (item.price1 > pocketMoney)
            {
                break; // Vyhazov Jarmily
            }
            
            
            pocketMoney -= item.price1;
            Console.WriteLine($"Koupila sis {item.name1}");
        }
        
        
        
    }
}