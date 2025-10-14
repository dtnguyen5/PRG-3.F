namespace MyNamespace;

class program
{
    // <------------------- Bankomat ------------------->
    static int nacistCastkuOdUzivatele()
    {
        Console.WriteLine("Zadejte částku: ");
        int castka = int.Parse(Console.ReadLine());
        return castka;
    }

    static void vyhodnotitCastku(int castka)
    {
        if (castka < 0)
        {
            Console.WriteLine("Detekována krádež - prosíme, neutíkejte, přijde policie");
        }
        else if (castka <= 350000)
        {
            Console.WriteLine($"Úspěšně vloženo {castka} Kč.");
        }
        else
        {
            Console.WriteLine("Nelze vložit více než 350000 kč");
        }
    }
    // <------------------- Bankomat ------------------->
    
    // <------------------- Kámen nůžky papír vs AI ------------------->
    
    // <------------------- Kámen nůžky papír vs AI ------------------->
    public static void Main(string[] args)
    {
        // <------------------- Bankomat ------------------->
        // Nechte uživatele zadat libovolné kladné číslo.
        // Pokud uživatel zadá částku 0–350 000,
        //  - vypíšete hlášku Úspěšně vloženo "částka" Kč. (místo částka program doplní zadané číslo)
        // Pokud uživatel zadá zápornou částku,
        //  - vypíšete hlášku Detekována krádež – prosíme, neutíkejte, přijde policie.
        // Pokud uživatel zadá částku 350 001 a více,
        //  - základ: Nelze vložit více než 350 000 Kč
        // Bonus
        //  - Hodí se kostkou a pokud padne 6, akceptuje se vklad 350 000 a přebytek jde bance do kapsy.
        //  - Jinak se vklad zamítne a vypíše se Nelze vložit více než 350 000 Kč.

        int castka = nacistCastkuOdUzivatele();
        vyhodnotitCastku(castka);
        // <------------------- Bankomat ------------------->
        
        // <------------------- Kámen nůžky papír vs AI ------------------->
        // napište program, který bude do nekonečna hrát kámen nůžky papír proti hráči a nikdy neprohraje.
        // Uživatel nebude psát slova, ani ukazovat gesta na kameru.
        // Program zobrazí nabídku, která bude vypadat například takto:
        
        // <------------------- Kámen nůžky papír vs AI ------------------->
        
        

    }
}