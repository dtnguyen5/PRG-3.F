using System;

class Program
{
    static void Hraj()
    {
        while (true)
        {
            int hrac = VyberTah();
            if (hrac == 4) break;

            int ai = AI(hrac);
            VypisTah("Hráč", hrac);
            VypisTah("AI", ai);
            Console.WriteLine("Výsledek: AI NEPROHRÁLA.");
        }
    }

    static int VyberTah()
    {
        Console.WriteLine("Vyberte možnost:\n1. Kámen\n2. Nůžky\n3. Papír\n4. Ukončit hru");
        return int.TryParse(Console.ReadLine(), out int volba) ? volba : -1;
    }

    static int AI(int hrac)
    {
        return hrac % 3 + 1; 
    }

    static void VypisTah(string kdo, int tah)
    {
        Console.Write(kdo + ": ");
        if (tah == 1)
        {
            Console.WriteLine("Kámen");
        }
        else if (tah == 2) Console.WriteLine("Nůžky");
        else if (tah == 3) Console.WriteLine("Papír");
    }
    
    public static void Main(string[] args)
    {
        Hraj();
    }

}