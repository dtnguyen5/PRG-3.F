using System;

class Program
{
    // <------------------------- 1. Úkol ------------------------->
    // Práce s řetězci
    // Je prázdný / jen mezery?
    // Úkol: Vrať true, když je null, prázdný nebo jen whitespace.
    // Signatura: bool IsBlank(string? s)
    // Příklad: " " → true

    private static bool IsBlank(string s)
    {
        if (s == null) 
        {
            return true; // když je null
        }

        s = s.Trim(); // odstraní mezery z kraje i konce

        if (s == "")
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    
    // <------------------------- 1. Úkol ------------------------->
    
    // <------------------------- 2. Úkol ------------------------->
    // Rodné číslo
    // Úkol: Ověř formát YYMMDD/XXXX nebo YYMMDDXXXX a že je datum validní (včetně února).
    // Signatura: bool IsCzechRCFormat(string input)
    // Příklad: "995229/1234" → false (neplatné datum)

    private static bool IsCzechRCFormat(string s)
    {
        if (s == null) return false;

        s = s.Replace("/", "");
        if (s.Length != 10) return false;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] < '0' || s[i] > '9') return false;
        }

        int rok = int.Parse(s.Substring(0, 2));
        int mesic = int.Parse(s.Substring(2, 2));
        int den = int.Parse(s.Substring(4, 2));

        if (mesic > 50) mesic -= 50; // ženy mají +50 k měsíci

        if (mesic < 1 || mesic > 12) return false;
        if (den < 1) return false;

        // přepočet roku na čtyřciferný
        int celeRok = (rok < 54 ? 2000 : 1900) + rok;

        // únor
        if (mesic == 2)
        {
            bool prestupny = (celeRok % 4 == 0 && celeRok % 100 != 0) || (celeRok % 400 == 0);
            if (den > 29 || (den == 29 && !prestupny)) return false;
        }
        else if (mesic == 4 || mesic == 6 || mesic == 9 || mesic == 11)
        {
            if (den > 30) return false;
        }
        else
        {
            if (den > 31) return false;
        }

        return true;
    }
    
    // <------------------------- 2. Úkol ------------------------->
    
    // <------------------------- 3. Úkol ------------------------->
    // Končí na suffix?
    // Úkol: Ověř, zda text končí zadaným suffixem.
    // Signatura: bool EndsWithSuffix(string s, string suffix)
    // Příklad: ("soubor.txt",".txt") → true

    private static bool EndsWithSuffix(string text, string suffix)
    {
        // pokud je text nebo suffix null, vrátíme false
        if (text == null || suffix == null)
            return false;

        // pokud je suffix delší než text, nemůže na něj končit
        if (text.Length < suffix.Length)
            return false;

        // vrátíme true, pokud konec textu odpovídá suffixu
        return text.EndsWith(suffix);
    }
        
    // <------------------------- 3. Úkol ------------------------->
    
    // <------------------------- 4. Úkol ------------------------->
    // Normalizace řetězce
    // Úkol: Odstraň z kraje i konce bílé znaky a zredukuj vícenásobné mezery uvnitř na jednu.
    // Signatura: string NormalizeSpaces(string input)
    // Příklad: " Ahoj světe " → "Ahoj světe"
    
    static string NormalizeSpaces(string text)
    {
        if (text == null)
        {
            return "";
        }

        text = text.Trim(); // odstraní mezery z kraje
            
        string vysledek = "";
        bool bylaMezera = false;

        for (int i = 0; i < text.Length; i++)
        {
                
            char znak = text[i];

            if (znak == ' ')
            {
                if (!bylaMezera)
                {
                    vysledek += ' ';  // přidá první mezeru
                    bylaMezera = true;
                }
            }
            else
            {
                vysledek += znak;
                bylaMezera = false;
            }
                
        }
        return vysledek;
    }
    
    // <------------------------- 4. Úkol ------------------------->
    
    // <------------------------- 5. Úkol ------------------------->
    // Normalizace řetězce
    // První písmeno velké (Title Case)
    // Úkol: Každé slovo začni velkým písmenem.
    // Signatura: string ToTitleCase(string input)
    // Příklad: "mistr a markétka" → "Mistr A Markétka"

    private static string ToTitleCase(string text)
    {
        if (text == null || text == "")
        {
            return "";
        }
        
        string[] slova = text.Split(' ');
        for (int i = 0; i < slova.Length; i++)
        {
            string slovo = slova[i];
            if (slovo.Length > 0)
            {
                string prvni = slovo[0].ToString().ToUpper();
                string zbytek = "";

                if (slovo.Length > 1)
                {   
                    zbytek = slovo.Substring(1).ToLower();
                }
                
                slova[i] = prvni + zbytek;
            }
        }
        
        string vysledek = string.Join(" ", slova);
        return vysledek;
    }
        
    // <------------------------- 5. Úkol ------------------------->
    
    public static void Main(string[] args)
    {
        // <------------------------- 1. Úkol ------------------------->
        // Práce s řetězci
        // Je prázdný / jen mezery?
        // Úkol: Vrať true, když je null, prázdný nebo jen whitespace.
        // Signatura: bool IsBlank(string? s)
        // Příklad: " " → true
        
        Console.WriteLine("1) Je prázdný / jen mezery?");
        Console.WriteLine(IsBlank("") );        // true
        Console.WriteLine(IsBlank("   "));      // true
        Console.WriteLine(IsBlank("text"));     // false
        Console.WriteLine();
        
        // <------------------------- 1. Úkol ------------------------->
        
        // <------------------------- 2. Úkol ------------------------->
        // Rodné číslo
        // Úkol: Ověř formát YYMMDD/XXXX nebo YYMMDDXXXX a že je datum validní (včetně února).
        // Signatura: bool IsCzechRCFormat(string input)
        // Příklad: "995229/1234" → false (neplatné datum)
        
        Console.WriteLine("2) Rodné číslo:");
        Console.WriteLine(IsCzechRCFormat("995229/1234")); // false
        Console.WriteLine(IsCzechRCFormat("995228/1234")); // true
        Console.WriteLine();
        
        // <------------------------- 2. Úkol ------------------------->
        
        // <------------------------- 3. Úkol ------------------------->
        // Končí na suffix?
        // Úkol: Ověř, zda text končí zadaným suffixem.
        // Signatura: bool EndsWithSuffix(string s, string suffix)
        // Příklad: ("soubor.txt",".txt") → true
        
        Console.WriteLine("3) Končí na suffix?");
        Console.WriteLine(EndsWithSuffix("soubor.txt", ".txt")); // true
        Console.WriteLine(EndsWithSuffix("soubor.txt", ".jpg")); // false
        Console.WriteLine();
        
        // <------------------------- 3. Úkol ------------------------->
        
        // <------------------------- 4. Úkol ------------------------->
        // Normalizace řetězce
        // Úkol: Odstraň z kraje i konce bílé znaky a zredukuj vícenásobné mezery uvnitř na jednu.
        // Signatura: string NormalizeSpaces(string input)
        // Příklad: " Ahoj světe " → "Ahoj světe"
        
        Console.WriteLine("4) Normalizace řetězce:");
        Console.WriteLine("'" + NormalizeSpaces("   Ahoj   světe   ") + "'"); // "Ahoj světe"
        Console.WriteLine();
        
        // <------------------------- 4. Úkol ------------------------->
        
        // <------------------------- 5. Úkol ------------------------->
        // Normalizace řetězce
        // První písmeno velké (Title Case)
        // Úkol: Každé slovo začni velkým písmenem.
        // Signatura: string ToTitleCase(string input)
        // Příklad: "mistr a markétka" → "Mistr A Markétka"
        
        Console.WriteLine("5) První písmeno velké:");
        Console.WriteLine(ToTitleCase("mistr a markétka")); // "Mistr A Markétka"
        Console.WriteLine();
        
        // <------------------------- 5. Úkol ------------------------->
        
    }
}