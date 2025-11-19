# Pole v C#

Pole v C# jsou datové struktury, které umožňují uložit více hodnot stejného datového typu pod jedním názvem proměnné. V C# existují i pole s pevnou délkou (ostatně jako v Javě) a také „jagged“ (zubatá) pole.

---

## Deklarace a inicializace pole

### Deklarace pole
- Pole se deklaruje pomocí hranatých závorek `[]` za názvem datového typu.
- Při deklaraci se obvykle neurčuje velikost pole.

Příklad:
```csharp
int[] cisla;
string[] slova;
```

### Inicializace pole
- Při inicializaci se určuje velikost pole.
- Všechny prvky pole jsou automaticky inicializovány výchozí hodnotou (např. `0` pro `int`, `null` pro `string`).

Příklad:
```csharp
int[] cisla = new int[5]; // Pole s 5 prvky (výchozí hodnoty 0)
```

- Pole lze také přímo inicializovat konkrétními hodnotami:

```csharp
int[] cisla = { 1, 2, 3, 4, 5 };
string[] slova = { "Ahoj", "Svět", "C#" };
```

---

## Přístup k prvkům pole
- K jednotlivým prvkům pole se přistupuje pomocí indexu (číslováno od `0`).
- Indexace začíná na `0`, poslední prvek má index `velikost - 1`.

Příklad:
```csharp
int[] cisla = { 10, 20, 30 };
Console.WriteLine(cisla[0]); // Výstup: 10
Console.WriteLine(cisla[2]); // Výstup: 30

// Změna hodnoty prvku pole:
cisla[1] = 50; // Změna druhého prvku
Console.WriteLine(cisla[1]); // Výstup: 50
```

---

## Procházení pole

### Pomocí `for` cyklu
Nejčastější způsob iterace přes pole je použití klasického `for` cyklu.

```csharp
int[] cisla = { 10, 20, 30, 40 };
for (int i = 0; i < cisla.Length; i++)
{
    Console.WriteLine($"Prvek na indexu {i}: {cisla[i]}");
}
```

### Pomocí `foreach` cyklu
`foreach` se používá pro jednoduché iterace přes všechna data v poli.

```csharp
foreach (int cislo in cisla)
{
    Console.WriteLine("Hodnota: " + cislo);
}
```

---

## Délka pole
- Délku pole lze zjistit pomocí vlastnosti `.Length`.

Příklad:
```csharp
Console.WriteLine("Délka pole: " + cisla.Length);
```

---

## Vícedimenzionální pole
- V C# existují dvě hlavní možnosti: více-rozměrné (rectangular) pole a jagged (pole polí).

Rectangular (dvoudimenzionální) pole:
```csharp
int[,] matice = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};
Console.WriteLine(matice[1, 2]); // Výstup: 6

// Procházení:
for (int i = 0; i < matice.GetLength(0); i++)
{
    for (int j = 0; j < matice.GetLength(1); j++)
    {
        Console.Write(matice[i, j] + " ");
    }
    Console.WriteLine();
}
```

Jagged (pole polí):
```csharp
int[][] jagged = new int[][]
{
    new int[] {1, 2, 3},
    new int[] {4, 5},
    new int[] {6, 7, 8, 9}
};

// Přístup k prvkům:
Console.WriteLine(jagged[1][1]); // Výstup: 5

// Procházení jagged pole:
for (int i = 0; i < jagged.Length; i++)
{
    for (int j = 0; j < jagged[i].Length; j++)
    {
        Console.Write(jagged[i][j] + " ");
    }
    Console.WriteLine();
}
```

---

## Kopírování pole
- V C# lze použít Array.Copy, CopyTo, Clone nebo LINQ `.ToArray()`.

Příklad:
```csharp
using System;
using System.Linq;

int[] original = { 1, 2, 3 };

// 1) Array.Copy
int[] kopie1 = new int[original.Length];
Array.Copy(original, kopie1, original.Length);

// 2) Clone (vrací object, potřeba přetypovat)
int[] kopie2 = (int[])original.Clone();

// 3) LINQ ToArray (vyžaduje using System.Linq)
int[] kopie3 = original.ToArray();

// Výpis (pomocí string.Join)
Console.WriteLine("Kopie: [" + string.Join(", ", kopie1) + "]"); // Výstup: [1, 2, 3]
```

---

## Třídění pole
- Pro třídění lze použít Array.Sort.

Příklad:
```csharp
int[] cisla = { 5, 3, 8, 1 };
Array.Sort(cisla);
Console.WriteLine("Seřazeno: [" + string.Join(", ", cisla) + "]"); // Výstup: [1, 3, 5, 8]
```

---

## Shrnutí
1. Pole jsou struktury, které uchovávají více hodnot stejného typu.
2. Přístup k prvkům se provádí přes index (od `0`).
3. Procházení pole je možné klasickým `for` cyklem nebo `foreach` cyklem.
4. Pole mají pevnou délku, která se nemění po inicializaci (pro dynamické velikosti používejte např. List<T>).
5. Vícedimenzionální pole umožňují uchovávat složitější struktury dat; v C# jsou dostupné jak rectangular (např. `int[,]`), tak jagged (`int[][]`) pole.
6. Kopírování a třídění pole se provádí pomocí metod v třídě `Array` nebo pomocí LINQ.

Pole jsou základní součástí programování v C# a slouží jako podklad pro pokročilejší datové struktury jako `List<T>`, `Dictionary<TKey, TValue>` apod.
