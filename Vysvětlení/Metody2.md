# Užitečné metody v C#

Matematické metody (`Math`)
Třída `Math` poskytuje užitečné metody pro matematické výpočty. Je součástí základní knihovny .NET, není nutné nic importovat.

### Nejužitečnější metody

- `Math.Abs(x)`: Vrací absolutní hodnotu čísla.

```csharp
Console.WriteLine(Math.Abs(-10)); // 10
```

- `Math.Pow(base, exponent)`: Vrací mocninu čísla.

```csharp
Console.WriteLine(Math.Pow(2, 3)); // 8
```

- `Math.Sqrt(x)`: Vrací druhou odmocninu čísla.

```csharp
Console.WriteLine(Math.Sqrt(16)); // 4
```

- `Math.Max(a, b)` / `Math.Min(a, b)`: Vrací větší/menší zadanou hodnotu.

```csharp
Console.WriteLine(Math.Max(5, 10)); // 10
```

- `Math.Round(x)`: Zaokrouhluje číslo na nejbližší celé číslo.

```csharp
Console.WriteLine(Math.Round(3.6)); // 4
```

- `Random`: Pro generování náhodných čísel použijte třídu `Random`:

```csharp
Random rnd = new Random();
Console.WriteLine(rnd.NextDouble()); // Náhodné číslo mezi 0.0 a 1.0
```

---

Metody pro práci s časem (`DateTime`, `TimeSpan`)
Třída `DateTime` poskytuje nástroje pro práci s datem a časem.
### Nejužitečnější metody

- **Aktuální datum:**

```csharp
DateTime today = DateTime.Now.Date;
Console.WriteLine(today); // Např. 15.11.2025
```

- **Aktuální čas:**

```csharp
TimeSpan nowTime = DateTime.Now.TimeOfDay;
Console.WriteLine(nowTime); // Např. 22:10:00
```

- **Aktuální datum a čas:**

```csharp
DateTime now = DateTime.Now;
Console.WriteLine(now); // Např. 15.11.2025 22:10:00
```

- **Přidávání a odebírání dnů, měsíců a let:**

```csharp
DateTime tomorrow = today.AddDays(1);
Console.WriteLine(tomorrow); // Např. 16.11.2025
```

- **Formátování data:**

```csharp
string formatted = today.ToString("dd.MM.yyyy");
Console.WriteLine(formatted); // Např. 15.11.2025
```

---

## Metody tříd základních datových typů

`int` – práce s celými čísly
- `int.Parse(string s)`: Převádí řetězec na celé číslo.

```csharp
int num = int.Parse("123");
Console.WriteLine(num); // 123
```

- `ToString()`: Převádí celé číslo na řetězec.

```csharp
string str = 123.ToString();
Console.WriteLine(str); // "123"
```

- `int.MaxValue` / `int.MinValue`: Maximální a minimální hodnota typu `int`.

```csharp
Console.WriteLine(int.MaxValue); // 2147483647
```

---

`char` – práce s jednotlivými znaky
- `char.IsDigit(char c)`: Kontroluje, zda je znak číslice.

```csharp
Console.WriteLine(char.IsDigit('5')); // true
```

- `char.IsLetter(char c)`: Kontroluje, zda je znak písmeno.

```csharp
Console.WriteLine(char.IsLetter('a')); // true
```

- `char.ToUpper(char c)` / `char.ToLower(char c)`: Převádí znak na velké/malé písmeno.

```csharp
Console.WriteLine(char.ToUpper('a')); // 'A'
```

---

`double` – práce s desetinnými čísly
- `double.Parse(string s)`: Převádí řetězec na desetinné číslo.

```csharp
double num = double.Parse("3.14");
Console.WriteLine(num); // 3.14
```

- `ToString()`: Převádí desetinné číslo na řetězec.

```csharp
string str = 3.14.ToString();
Console.WriteLine(str); // "3.14"
```

---

### Shrnutí

1. **Matematické metody** jsou užitečné pro rychlé výpočty (např. odmocniny, mocniny, náhodná čísla).

2. **Metody pro práci s časem** umožňují snadné získání aktuálního data/času a jejich formátování.

3. **Metody základních typů** usnadňují konverze mezi řetězci a čísly nebo analýzu znaků.
