# Přetížení a Rekurze v C#

## Přetížení metod

### Co je přetížení metod?
Přetížení metod znamená, že více metod může mít stejný název, ale liší se:
- Počtem parametrů,
- Typy parametrů,
- Pořadím parametrů.

C# rozlišuje přetížené metody podle jejich signatury (název metody + parametry). Stejně jako v Javě, přetížení nelze provést pouze změnou návratového typu.

### Příklad přetížení metod
```csharp
using System;

public class OverloadingExample
{
    // Metoda bez parametrů
    public static void PrintMessage()
    {
        Console.WriteLine("Ahoj světe!");
    }

    // Metoda s jedním parametrem
    public static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    // Metoda se dvěma parametry
    public static void PrintMessage(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(message);
        }
    }

    public static void Main(string[] args)
    {
        PrintMessage(); // Zavolá metodu bez parametrů
        PrintMessage("Hello C#!"); // Zavolá metodu s jedním parametrem
        PrintMessage("Opakuji", 3); // Zavolá metodu se dvěma parametry
    }
}
```

### Důležitá poznámka o přetížení
Nelze mít dvě metody se stejnou signaturou, které se liší pouze návratovým typem. Příklad níže v Java zdrojích byl chybný (dva stejné názvy a parametry, lišící se jen návratovým typem) — v C# i v Javě to neprojde. Opravil jsem ukázku tak, aby znázorňovala platné přetížení.

Chybný (neplatný) přístup — nelze přetížit pouze podle návratového typu:
```java
// NEPLATNÉ v Javě i C#:
// static void flipCoin() { ... }
// static boolean flipCoin() { ... } // nelze — stejná signatura, jiný návratový typ
```

Platná oprava (v C#): přetížením podle parametrů
```csharp
using System;

public class CoinExample
{
    private static readonly Random rng = new Random();

    // Metoda bez parametrů (vypíše výsledek)
    public static void FlipCoin()
    {
        if (rng.NextDouble() > 0.5)
        {
            Console.WriteLine("Head");
        }
        else
        {
            Console.WriteLine("Tails");
        }
    }

    // Přetížená metoda s parametrem — vrací true pro head, false pro tails
    // (diferentní signatura -> platné přetížení)
    public static bool FlipCoin(bool returnResult)
    {
        bool head = rng.NextDouble() > 0.5;
        if (head) Console.WriteLine("Head");
        else Console.WriteLine("Tails");
        return head;
    }

    public static void Main(string[] args)
    {
        FlipCoin();              // Volá verzi bez parametru
        bool result = FlipCoin(true); // Volá verzi, která vrací bool
        Console.WriteLine($"Výsledek (bool): {result}");
    }
}
```

---

## Rekurze

### Co je rekurze?
Rekurze je technika, kdy metoda volá sama sebe. Používá se často pro problémy, které lze rozdělit na menší části.

### Struktura rekurze
Každá rekurzivní metoda musí mít:
1. **Základní případ (base case):** Situace, kdy rekurze končí.
2. **Rekurzivní krok:** Volání metody sama na sebe s jinými (menšími) parametry.

### Příklad: Faktoriál čísla (rekurzivně)
Poznámka: v původním Java iterativním příkladu byl typ návratu `int`, ale proměnná `result` byla `long` — to v Javě kompilovat nebude. Opravil jsem typy tak, aby odpovídaly rozsahu čísel.

```csharp
using System;

public class RecursionExample
{
    // Rekurzivní metoda pro výpočet faktoriálu
    public static long FactorialRecursive(int n)
    {
        if (n == 0) // Základní případ
        {
            return 1;
        }
        else // Rekurzivní krok
        {
            return n * FactorialRecursive(n - 1);
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Faktoriál čísla 5 (rekurzivně): " + FactorialRecursive(5));
    }
}
```

### Iterativní přístup
```csharp
using System;

public class IterativeExample
{
    // Iterativní přístup — opravena návratová hodnota na long
    public static long FactorialIterative(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Faktoriál čísla 5 (iterativně): " + FactorialIterative(5));
    }
}
```

#### Výstup programu
```
Faktoriál čísla 5: 120
```

### Další příklad: Fibonacciho posloupnost

Rekurzivní verze:
```csharp
using System;

public class FibonacciExample
{
    // Rekurzivní metoda pro výpočet Fibonacciho čísla
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1) // Základní případy
            return n;
        else // Rekurzivní krok
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("10. Fibonacciho číslo (rekurzivně): " + FibonacciRecursive(10));
    }
}
```

Iterativní verze (efektivnější):
```csharp
using System;

public class FibonacciExampleIterative
{
    // Iterativní metoda pro výpočet Fibonacciho čísla
    public static int FibonacciIterative(int n)
    {
        int num1 = 0, num2 = 1, num3;

        for (int i = 0; i < n; i++)
        {
            num3 = num2 + num1;
            num1 = num2;
            num2 = num3;
        }
        return num1;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("10. Fibonacciho číslo (iterativně): " + FibonacciIterative(10));
    }
}
```

- Rekurze může být časově i paměťově náročná.
- Zkuste si metodu zavolat s argumentem 50 nebo 100 (u rekurzivní verze Fibonacciho to bude extrémně pomalé).
- Abychom počítači trochu ulehčili, můžeme metodu přepsat iterativním způsobem (tj. bez rekurze).
- Vymyslet iterativní náhradu rekurze je někdy náročné, ale často výrazně výkonnostně lepší.

### Iterace vs. Rekurze
| Vlastnost               | Rekurze                             | Iterace                           |
|------------------------|--------------------------------------|------------------------------------|
| Paměťová náročnost     | Vyšší (kvůli zásobníku volání)       | Nižší                             |
| Rychlost               | Pomalejší (často)                    | Rychlejší                         |
| Jednoduchost kódu      | Často jednodušší a čitelnější        | Může být složitější               |

---

## Shrnutí
1. Přetížení metod umožňuje definovat více metod se stejným názvem, ale různými parametry. Nelze přetížit pouze změnou návratového typu.
2. Rekurze je užitečná technika pro řešení problémů, které lze rozdělit na menší podproblémy, ale vyžaduje správné ošetření základního případu, aby nedošlo k nekonečné rekurzi.
3. Iterace a rekurze mohou být alternativními přístupy pro řešení některých problémů, ale mají různé vlastnosti týkající se paměťové a časové náročnosti.
