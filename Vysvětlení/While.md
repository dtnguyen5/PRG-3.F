# Cyklus

- Cyklus v programování je velmi užitečný nástroj, protože nám umožňuje opakovat určitý blok kódu, dokud není splněna nějaká podmínka.
- To je skvělé, když potřebujeme vykonávat stejnou operaci vícekrát a nechceme psát kód pořád dokola.
- Například, když chceme 10krát vypočítat něco nebo zobrazit čísla od 1 do 100.
- Cyklus nám umožní napsat kód elegantně a krátce.

### Proč bychom chtěli cyklus?

- Už víte, jak funguje větvení pomocí podmínek (např. `if-else`), které určují směr programu.
- Cyklus souvisí s podmínkami v tom, že nám umožňuje **opakovat** blok kódu, dokud je nějaká podmínka splněna.

#### Příklad intuice:

- Máte seznam lidí, kteří se účastní závodu.
- Chcete vypsat každého člověka ze seznamu.
- Namísto aby jste to dělali ručně pro každý prvek, použijete cyklus, který projde celý seznam a vypíše jména.

```csharp
// Výpis číslic 1 - 10 bez cyklu
Console.WriteLine(1);
Console.WriteLine(2);
// ...
Console.WriteLine(10);

// Výpis jmen ze seznamu bez cyklu
string[] seznamJmen = { "Karel", "Pepa", "Honza", "Jarmila", "Libor", "Jana" };
Console.WriteLine(seznamJmen[0]); // Karel
Console.WriteLine(seznamJmen[1]); // Pepa
Console.WriteLine(seznamJmen[2]); // Honza
Console.WriteLine(seznamJmen[3]); // Jarmila
Console.WriteLine(seznamJmen[4]); // Libor
Console.WriteLine(seznamJmen[5]); // Jana
```

### Cyklus s podmínkou na začátku

- `while` cyklus opakuje blok kódu, dokud je podmínka **pravdivá**.
- Jakmile podmínka přestane být pravdivá, cyklus skončí.

##### Syntaxe:

```csharp
while (podminka) {
    // kód, který se má opakovat
}
```

#### Příklad:

```csharp
// Výpis číslicí 1 - 10 pomocí while
int i = 1;
while (i <= 10) {
    Console.WriteLine(i);
    i++;
}

// Výpis lidí ze seznamu pomocí while
string[] seznamJmen = { "Karel", "Pepa", "Honza", "Jarmila", "Libor", "Jana" };
int pozice = 0;
int pocetJmen = seznamJmen.Length;

while (pozice < pocetJmen) {
    string jmeno = seznamJmen[pozice];
    Console.WriteLine(jmeno);
    pozice++;
}
```

### Cyklus s podmínkou na konci

- `do-while` cyklus
- Na rozdíl od cyklu `while`, kde se nejdříve testuje podmínka, cyklus `do-while` nejdříve vykoná blok kódu a teprve potom ověří podmínku.
- To znamená, že se cyklus **vždy provede alespoň jednou**, i kdyby podmínka nebyla splněna hned na začátku.

##### Syntaxe:

```csharp
do {
    // kód, který se má opakovat
} while (podminka);
```

#### Příklad:

```csharp
int i = 1;
do {
    Console.WriteLine(i++);
} while (i <= 10);
```

### Užitečné informace a tipy

1. **Nekonečný cyklus** : Pokud zapomenete změnit podmínku uvnitř cyklu, může se stát, že cyklus poběží **nekonečně dlouho**.  
Například, pokud byste zapomněli na `i++`, program by stále tiskl číslo `1`, protože hodnota `i` by se nikdy nezměnila.

```csharp
while (true) {
    Console.WriteLine("Tento cyklus nikdy neskončí!");
}
```

Tomu se říká **nekonečný cyklus** a může způsobit zamrznutí programu. Je třeba se ujistit, že podmínka cyklu se někdy stane nepravdivou.

2. **Použití cyklu s uživatelským vstupem** : Často používáme cykly pro opakované získávání vstupu od uživatele, dokud nezadá správné údaje.

```csharp
int number;
do {
    Console.WriteLine("Zadej číslo větší než 0:");
    number = int.Parse(Console.ReadLine());
} while (number <= 0);  // cyklus pokračuje, dokud uživatel nezadá správné číslo
```

3. **Vlajky (flags)** : Někdy lze použít proměnné jako **vlajky**, které pomohou řídit, kdy cyklus skončí.

```csharp
bool running = true;
while (running) {
    // nějaký kód
    if (nejakaPodminka) {
        running = false; // když je podmínka splněna, cyklus skončí
    }
}
```

### Shrnutí:

- Cyklus nám umožňuje **opakovaně provádět kód**, což šetří čas a zjednodušuje program.
- `while` cyklus ověřuje podmínku **před každým opakováním**.
- `do-while` cyklus ověřuje podmínku **až po prvním provedení kódu**, takže se vždy vykoná alespoň jednou.
- Je důležité zajistit, aby cyklus měl způsob, jak skončit – jinak hrozí nekonečný běh.
