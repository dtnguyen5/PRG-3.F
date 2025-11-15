# Switch

- Řídící konstrukce pro možnost širšího větvení kódu.
- Používá se místo delších bloků `if...else`.
- Na základě podmínky vybere jeden blok, který se provede.

### Syntax

```csharp
switch (expression) {
    case x:
        // kód
        break;
    case y:
        // kód
        break;
    default:
        // kód
        break;
}
```

### Jak to funguje?

- `expression` je vyhodnoceno pouze jednou.
- Hodnota výrazu se porovná s každou hodnotou `case`.
- Pokud se shoduje, provede se konkrétní blok.
- Pokud blok neukončíte slovem `break` a spustí se nějaký blok (například `case x:`), tak se provede **každý blok** od `case x` až dolů (tzv. "propadávání").

### Příklad

```csharp
int day = 4;
switch (day) {
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}
// Výstup: "Thursday" (day 4)
```
