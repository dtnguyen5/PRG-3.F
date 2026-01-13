using System;
using System.Threading;

namespace MyNamespace;

class Program
/*
 Úloha 4 – Traffic Simulation
    Zadání:
    Simulujte jednoduchý dopravní pruh, ve kterém se auta posouvají doleva.

        Vytvořte pole road délky 10, kde:
            0 = prázdné místo
            1 = auto

        Na začátku náhodně rozmístěte několik aut (např. 3–5 kusů).

        Vytvořte metodu static void MoveCars(int[] arr), která:
            posune všechna auta o 1 pozici doleva (auto ze začátku pole se „ztratí“)

        V každém kroku vykreslete stav silnice (_ = prázdné, 🚗 = auto).

    Ukázka výstupu:
    |_|_|🚗|_|_|🚗|_|🚗|_|_|   // jak vykreslíte mezery je zcela na Vás, zde je použit znak "|"
    |_|🚗|_|_|🚗|_|🚗|_|_|_|
    |🚗|_|_|🚗|_|🚗|_|_|_|_|
    💡 Bonus: Přidejte cyklus, který bude animaci opakovat několikrát (např. 5 tahů).

    Využijte
    Console.Clear(); // vyčistí konzoli
    Thread.Sleep(50); // pozastaví program na 50 ms, čas si upravte dle potřeb
*/
{
    // metoda pro posun aut doleva
    static void MoveCars(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[arr.Length - 1] = 0; // poslední místo je prázdné
    }

    // metoda pro vykreslení silnice
    static void DrawRoad(int[] arr)
    {
        Console.Write("|");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                Console.Write("A|");  // místo emoji použijeme písmeno A
            }
            else
            {
                Console.Write("_|");
            }
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] road = new int[10];

        // náhodný počet aut (3–5)
        int carsCount = rnd.Next(3, 6);

        // náhodné rozmístění aut
        for (int i = 0; i < carsCount; i++)
        {
            int pos;
            do
            {
                pos = rnd.Next(road.Length);
            } while (road[pos] == 1); // aby se auta nepřekrývala
            road[pos] = 1;
        }

        // animace – několik kroků
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            DrawRoad(road);
            MoveCars(road);
            Thread.Sleep(500); // 500 ms pauza
        }
    }
}
