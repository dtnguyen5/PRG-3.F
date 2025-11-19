# List v C#

V Java jste používali `ArrayList`. V C# existuje třída `ArrayList` v `System.Collections`, ale jde o legacy (negenerickou) třídu, která způsobuje boxing/unboxing u hodnotových typů. Moderní a doporučený ekvivalent je generická kolekce `List<T>` z `System.Collections.Generic`. Níže je převedený a upravený text s příklady v C#.

---

## Import (using)
- Pro `List<T>`:
```csharp
using System.Collections.Generic;
```
- Pro některé operace (LINQ, konverze) se hodí:
```csharp
using System.Linq;
```
- Poznámka: `using System.Collections;` obsahuje starší `ArrayList`, kterou je lepší se vyhnout.

---

## Deklarace a vytvoření Listu

### Deklarace
- Používáme generický typ `List<T>`:
```csharp
List<string> slova;
List<int> cisla;
```
Poznámka: v C# lze jako generický typ použít přímo hodnotové typy (např. `int`) bez nutnosti používat obalové třídy (v kontrastu s Java `ArrayList` před generiky).

### Inicializace (vytvoření instance)
```csharp
List<string> slova = new List<string>();
List<int> cisla = new List<int>();
// od C# 3.0 můžete použít syntaxi s inferencí v lokálním kontextu:
var slova2 = new List<string>();
```

---

## Přidávání prvků do Listu
Metoda Add():
```csharp
slova.Add("Ahoj");
slova.Add("Svět");
slova.Add("C#");
```

Přidání s určením indexu (Insert):
```csharp
slova.Insert(1, "Programování"); // prvek vložen na index 1, ostatní se posunou
```

---

## Přístup k prvkům
- V C# používáme indexer (`[]`) místo `get()`/`set()`:

```csharp
string prvniSlovo = slova[0];
Console.WriteLine(prvniSlovo); // Výstup: Ahoj

slova[1] = "Všichni";
Console.WriteLine(slova[1]); // Výstup: Všichni
```

---

## Odstraňování prvků
- RemoveAt(index) — odstraní podle indexu:
```csharp
slova.RemoveAt(1); // odstraní prvek na indexu 1
```
- Remove(value) — odstraní první výskyt hodnoty, vrací bool:
```csharp
slova.Remove("C#"); // zkusí odstranit "C#", true pokud existovalo
```
- Clear() — vyprázdní kolekci:
```csharp
slova.Clear();
```

---

## Velikost Listu
- V C# se používá vlastnost `Count`:
```csharp
Console.WriteLine("Počet prvků: " + slova.Count);
```

---

## Procházení Listu

### Pomocí `for` cyklu
```csharp
for (int i = 0; i < slova.Count; i++)
{
    Console.WriteLine($"Prvek na indexu {i}: {slova[i]}");
}
```

### Pomocí `foreach` cyklu
```csharp
foreach (string slovo in slova)
{
    Console.WriteLine("Hodnota: " + slovo);
}
```

---

## Třídění Listu
- Použijeme `List<T>.Sort()` nebo `List<T>.Sort(Comparison<T>)`/`Sort(IComparer<T>)` pro vlastní pořadí.
```csharp
List<int> cisla = new List<int> { 5, 3, 8, 1 };
cisla.Sort(); // [1, 3, 5, 8]
Console.WriteLine("Seřazeno: [" + string.Join(", ", cisla) + "]");

// Obrácené pořadí
cisla.Reverse(); // [8, 5, 3, 1]
```

---

## Převod mezi polem a Listem

1) Pole -> List:
```csharp
string[] pole = { "Ahoj", "Svět" };
List<string> list = new List<string>(pole);
// nebo pomocí LINQ
List<string> list2 = pole.ToList(); // vyžaduje using System.Linq;
```

2) List -> Pole:
```csharp
string[] novePole = list.ToArray();
```

Poznámka: pro primitivní typy (`int`, `double`, ...) není potřeba autoboxing u `List<int>` — C# generika podporují hodnotové typy přímo.

---

## Rozdíly mezi polem (Array) a List<T>

1. Velikost:
- Array má pevnou délku po vytvoření (`new int[5]`).
- List<T> se dynamicky rozšiřuje a zmenšuje.

2. Přístup:
- Array používá `[]` a má `.Length`.
- List<T> používá `[]` a má `.Count` plus metody (`Add`, `Remove` apod.)

3. Boxování:
- Non-generic `ArrayList` boxuje hodnoty (neefektivní).
- `List<T>` neboxuje hodnoty, pokud `T` je hodnotový typ (např. `int`).

4. Metody:
- Array má omezené metody; pro operace se používá třída `Array`.
- List<T> nabízí bohaté API: `Add`, `Insert`, `Remove`, `RemoveAt`, `Contains`, `IndexOf`, `Sort`, `Reverse` apod.

---

## Poznámka o starém ArrayList (System.Collections.ArrayList)
- Existuje i `ArrayList` (ne-generic):
```csharp
using System.Collections;
ArrayList legacy = new ArrayList();
legacy.Add(1);     // proběhne boxování int -> object
int x = (int)legacy[0]; // unboxing
```
- Doporučení: pokud nepotřebujete pracovat s heterogenními objekty, používejte `List<T>`.

---

## Krátké příklady (plně funkční)
```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var slova = new List<string> { "Ahoj", "Svět", "C#" };

        // Add a Insert
        slova.Add("Programování");
        slova.Insert(1, "Vlozeno");

        // Access
        Console.WriteLine(slova[0]); // Ahoj
        slova[1] = "Všichni";

        // Iterate
        foreach (var s in slova)
            Console.WriteLine(s);

        // Remove
        slova.Remove("C#");
        slova.RemoveAt(0);

        // Sort
        var cisla = new List<int> { 5, 3, 8, 1 };
        cisla.Sort();
        Console.WriteLine("Cisla: " + string.Join(", ", cisla));

        // Array <-> List
        string[] pole = { "A", "B" };
        var listFromArray = new List<string>(pole);
        string[] backToArray = listFromArray.ToArray();
        Console.WriteLine("Pole: [" + string.Join(", ", backToArray) + "]");

        Console.WriteLine("Počet prvků: " + slova.Count);
    }
}
```

---

## Shrnutí
1. V C# preferujeme `List<T>` místo starého `ArrayList`.
2. `List<T>` je dynamický, typově bezpečný a efektivní (žádné implicitní boxování pro hodnotové typy).
3. Pro operace s poli a seznamy použijte vhodné API (`Array`, `List<T>`, LINQ).
