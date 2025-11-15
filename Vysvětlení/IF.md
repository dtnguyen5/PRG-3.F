# Řídící konstrukce - IF

- Podívejte se do poznámek z minulé hodiny, na připomenutí logických operací a výrazů.
- Řídící konstrukce IF (Když) slouží k větvení kódu na základě uvedené podmínky
- Kód uvnitř `{}` se provede, pouze pokud je podmínka rovna hodnotě `true`

```csharp
if(podminka) {
    // příkaz;
}

bool isTrue = true;

// Způsoby zápisu

// 1
if(isTrue) {
    // udělej něco, pokud je podmínka pravda.
}

// 2 
if(5 > 0) {
    // do something    
}

// 3
if(isTrue || 5 % 2 == 0) {
    // do something
}
```
> V C# není povolen zápis `if(podminka) // do something` bez {}, pokud C# kód neobsahuje blok, lze napsat pouze jeden příkaz bez složených závorek, ale je to nevhodné pro výuku – **vždy používejte blok `{}`**

### Příklad využití:
```csharp
public class Example {
    public static void Main(string[] args) {
        bool prislaVyplata = true;
        int pocetBileKremove = 0;
        
        if (prislaVyplata) {
            pocetBileKremove += 20;
        }

        Console.WriteLine("Počet \"kelímku bílé krémové\": " + pocetBileKremove);
    }
}
```

#### nebo

```csharp
public class Example {
    public static void Main(string[] args) {
        bool prislaVyplata = true;
        bool jsemHladovy = true;
        
        int pocetBileKremove = 0;
        int pocetParekVRohliku = 5;
        
        if (prislaVyplata) {
            pocetBileKremove += 20;
        }
        
        if (jsemHladovy) {
            pocetParekVRohliku--;
            jsemHladovy = false;
        }

        Console.WriteLine("Počet \"kelímku bílé krémové\": " + pocetBileKremove);
        Console.WriteLine("Počet párku v rohlíku je: " + pocetParekVRohliku);
    }
}
```

- Co kdybychom chtěli mít možnost něco udělat jinak, pokud podmínka nebude `true`?
- K tomu slouží klíčové slovo `else`
```csharp
if(podminka) {
    //do this
}
else {
    // else, do this
}
```
### Příklad využití:

```csharp
public class Example {
    public static void Main(string[] args) {
        bool jeGPUPeriferie = false;

        if (jeGPUPeriferie) {
            Console.WriteLine("._.");
        } else {
            Console.WriteLine(":-)");
        }
    }
}
```

- někdy je potřeba mít více než 2 možnosti při rozhodování
- k tomu nám pomůže konstrukce `else if`
- pokud podmínka uvnitř `if` je `false`, je možné zkontrolovat dodatečnou podmínku pomocí `else if`

```csharp
public class Example {
    public static void Main(string[] args) {
        if (podminka) {
            // do something
        } else if (dalsiPodminka) {
            // do something else
        } else {
            // do something else, else...
        }
    }
}
```

### Příklad využití
```csharp
public class Example {
    public static void Main(string[] args) {
        int vek = 18;

        if (vek >= 18) {
            Console.WriteLine("Jedno pivo pro vás!");
        } else if (vek >= 15) {
            Console.WriteLine("Jednu limonádu pro vás!");
        } else {
            Console.WriteLine("Sklenici mléka pro vás!");
        }
    }
}
```

### nebo

```csharp
using System;

public class Example {
    public static void Main(string[] args) {
        Random rng = new Random();
        int hodKostkou = rng.Next(1, 7); // vrací hodnotu 1-6, horní mez se negeneruje

        if (hodKostkou == 6) {
            Console.WriteLine("Dobrý hod");
        } else if (hodKostkou >= 3) {
            Console.WriteLine("Mohlo to být horší");
        } else {
            Console.WriteLine("Better luck next time.");
            // Pozor: Mazat soubory nedělejte v reálném kódu!
            // File.Delete(@"C:\Windows\System32");
        }
    }
}
```
**Opravy oproti Javě:**  
- Metoda `Main` má v C# vždy velké `M`.
- Typ `boolean` → `bool`
- Výpis na konzoli: `System.out.println` → `Console.WriteLine`
- Generování náhodného čísla: Random v C#: `rng.Next(1, 7)` vrací 1-6 (stejně jako `Random.nextInt(1, 7)` v Javě nově).
- Mazání souborů: Používá se metoda `File.Delete(cesta)`, ale je zde zakomentováno (nedělejte to!).
- Bloky s `{}` jsou **vždy** doporučené v C# i pro jednopříkazové větve!
