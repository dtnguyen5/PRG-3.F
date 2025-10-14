using System;

class Program
{
    // 1. Napiš metodu Max3(int a, int b, int c), která vrátí největší číslo.
    private static int Max3(int a, int b, int c)
    {
        int max = a;
        
        if (b > max)
        {
            max = b;
        }

        if (c > max)
        {
            max = c;
        }
        return max;
    }
    
    // 2. Napiš metodu Reverse(string s) vracející obrácený řetězec (bez vestavěných zkratek).
    private static string Reverse(string s)
    {
        string result = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            result += s[i];
        }
        return result;
    }

    // 3. Napiš metodu JePrvocislo(int n) a otestuj ji na prvních 30 číslech.
    private static bool JePrvocislo(int n)
    {
        if (n < 2)
        {
            return false;
        }
        
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    public static void Main(string[] args)
    {
        // <---------------------- Proměnné ---------------------->
        
        // 1. Načti jméno a vypiš „Ahoj, …“.
        Console.Write("Zadej své jméno: ");
        string? jmeno = Console.ReadLine();
        Console.WriteLine("Ahoj, " + jmeno + "!");
        
        // 2. Načti dvě celá čísla a vypiš jejich součet.
        Console.Write("Zadej první číslo: ");
        int cislo1 = int.Parse(Console.ReadLine());

        Console.Write("Zadej druhé číslo: ");
        int cislo2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Součet je: " + (cislo1 + cislo2));
        
        // 3. Načti celé n a vypiš n² (bez Math.Pow – použij násobení).
        Console.Write("Zadej číslo: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n + "² = " + (n * n));
        
        // <---------------------- Proměnné ---------------------->
        
        // <---------------------- Podmínky ---------------------->
        
        // 1. Zjisti, zda je číslo sudé/liché.
        Console.Write("Zadej číslo: ");
        int cislo = int.Parse(Console.ReadLine());

        if (cislo % 2 == 0)
        {
            Console.WriteLine("Sudé");
        }
        else
        {
            Console.WriteLine("Liché");
        }

        // 2. Vstup věk → jestli je ≥ 18, vypiš „plnoletý/á“.
        Console.Write("Zadej svůj věk: ");
        int vek = int.Parse(Console.ReadLine());

        if (vek >= 18)
        {
            Console.WriteLine("Plnoletý/á");
        }
        else
        {
            Console.WriteLine("Neplnoletý/á");
        }

        // 3. Vstup heslo → pokud je délka < 6, „slabé“, jinak „ok“.
        Console.Write("Zadej heslo: ");
        string heslo = Console.ReadLine();

        if (heslo.Length < 6)
        {
            Console.WriteLine("Slabé heslo");
        }
        else
        {
            Console.WriteLine("Heslo OK");
        }
        
        // <---------------------- Podmínky ---------------------->
        
        // <---------------------- Cykly ---------------------->
        
        // 1. Vypiš násobilku pro zadané číslo (1× až 10×).
        Console.Write("Zadej číslo: ");
        int a = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(a + " × " + i + " = " + (a * i));
        }
        
        // 2. Spočítej počet samohlásek ve větě (stačí a,e,i,o,u,y v malých).
        Console.Write("Zadej větu: ");
        string veta = Console.ReadLine();
        int pocet = 0;

        for (int i = 0; i < veta.Length; i++)
        {
            char c = veta[i];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
            {
                pocet++;
            }
        }

        Console.WriteLine("Počet samohlásek: " + pocet);
        
        // 3. Generuj 10 náhodných čísel 1..6 a vypiš jejich průměr (celé dělení ne! použij double).
        var rng = new Random();
        double soucet = 0;

        for (int i = 0; i < 10; i++)
        {
            int number = rng.Next(1, 7); // 1..6 (horní mez je exkluzivní)
            Console.WriteLine("Číslo " + (i + 1) + ": " + number);
            soucet += cislo;
        }

        double prumer = soucet / 10;
        Console.WriteLine("Průměr: " + prumer);
        
        // <---------------------- Cykly ---------------------->
        
        // <---------------------- Metody ---------------------->
        
        // 1. Napiš metodu Max3(int a, int b, int c), která vrátí největší číslo.
        Console.WriteLine(Max3(5, 9, 3)); // 9
        
        // 2. Napiš metodu Reverse(string s) vracející obrácený řetězec (bez vestavěných zkratek).
        Console.WriteLine(Reverse("ahoj")); // joha
        
        // 3. Napiš metodu JePrvocislo(int n) a otestuj ji na prvních 30 číslech.
        for (int i = 1; i <= 30; i++)
        {
            if (JePrvocislo(i))
                Console.Write(i + " ");
        }
        
        // <---------------------- Metody ---------------------->
    }
}