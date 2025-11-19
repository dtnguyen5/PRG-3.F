# 1. Co je konstruktor?

Konstruktor je speciální metoda (konstruktorová metoda) třídy, která se volá při vytvoření instance (objektu). Jeho hlavním úkolem je inicializace objektu — nastavit počáteční hodnoty jeho atributů a provést další potřebná nastavení.

- Specifika konstruktoru v C#:
  - Má stejný název jako třída.
  - Nemá návratový typ (ani `void`).
  - Volá se při použití operátoru `new`.
  - Pokud konstruktor explicitně neuvedete, C# pro třídu vytvoří implicitní bezparametrický konstruktor (pokud žádný konstruktor není definován).

---

# 2. Syntaxe konstruktoru

Základní syntaxe konstruktoru v C# vypadá takto:

```csharp
public class Osoba
{
    // Pole třídy
    private string jmeno;
    private int vek;

    // Konstruktor třídy Osoba
    public Osoba(string jmenoVstup, int vekVstup)
    {
        jmeno = jmenoVstup;
        vek = vekVstup;
    }
}
```

V tomto příkladu:
- Konstruktor `Osoba(string jmenoVstup, int vekVstup)` přijímá dva parametry a nastavuje příslušné pole.

Pro odlišení instančních polí od parametrů se v C# také používá klíčové slovo `this`:

```csharp
public class Osoba
{
    private string jmeno;
    private int vek;

    public Osoba(string jmeno, int vek)
    {
        this.jmeno = jmeno;
        this.vek = vek;
    }
}
```

---

# 3. Přetížení konstruktorů

C# umožňuje definovat více konstruktorů v jedné třídě (přetížení). Každý konstruktor se liší počtem nebo typem parametrů (tj. má odlišnou signaturu).

Příklad přetížených konstruktorů (včetně volání jiného konstruktoru):

```csharp
using System;

public class Osoba
{
    private string jmeno;
    private int vek;

    // Bezparametrický konstruktor — volá konstruktor s parametry
    public Osoba() : this("Neznámé jméno", 0)
    {
    }

    // Konstruktor s jedním parametrem — volá konstruktor s dvěma parametry
    public Osoba(string jmeno) : this(jmeno, 0)
    {
    }

    // Konstruktor s dvěma parametry
    public Osoba(string jmeno, int vek)
    {
        this.jmeno = jmeno;
        this.vek = vek;
    }

    public void VypisInfo()
    {
        Console.WriteLine($"Jméno: {jmeno}, Věk: {vek}");
    }

    // Testovací Main (může být i v jiné třídě)
    public static void Main()
    {
        Osoba o1 = new Osoba();
        Osoba o2 = new Osoba("Karel");
        Osoba o3 = new Osoba("Marie", 25);

        o1.VypisInfo();
        o2.VypisInfo();
        o3.VypisInfo();
    }
}
```

- První konstruktor je bezparametrický a deleguje inicializaci na konstruktor s parametry pomocí `: this(...)`.
- Druhý konstruktor nastaví pouze jméno a deleguje zbytek.
- Třetí konstruktor provádí skutečnou inicializaci.

---

# 4. Volání konstruktorů – klíčové slovo this

V C# se volání jiného konstruktoru ve stejné třídě provádí pomocí syntaktického zápisu v inicilizátordu konstruktoru:

```csharp
public Osoba() : this("Neznámé jméno", 0) { }
```

- Volání `: this(...)` (constructor chaining) musí být uvedeno v hlavičce konstruktoru (jako inicializátor) — nelze jej volat zevnitř těla konstruktoru.
- Pokud dědíte z jiné třídy, konstruktor od báze můžete volat pomocí `: base(...)`.

---

# 5. Další důležité poznámky

- Implicitní konstruktor: Pokud žádný konstruktor explicitně nenapíšete, C# vytvoří výchozí bezparametrický konstruktor, který pouze provede standardní inicializaci polí (nevolá žádnou vlastní logiku).
- Konstruktor vs. metoda: Konstruktor nemá návratový typ a slouží k inicializaci objektu. Metody mají návratový typ (nebo `void`) a provádějí akce.
- Chaining: Díky `: this(...)` lze vytvořit tzv. "constructor chaining", kde jeden konstruktor deleguje práci jinému konstruktoru ve stejné třídě.
- Volání konstruktoru nadřazené třídy: `public Derived(int x) : base(x) { }`
- Konstruktor může být `public`, `private`, `protected` nebo `internal` v závislosti na potřebě řízení přístupu (např. private konstruktor pro Singleton pattern).

---

# Shrnutí

1. Konstruktor je speciální metoda používaná k inicializaci objektu při jeho vytvoření.
2. Má stejný název jako třída a žádný návratový typ.
3. Volá se při použití `new`.
4. Lze je přetěžovat (více konstruktorů s různými parametry).
5. V C# se volání jiného konstruktoru v rámci třídy provádí pomocí `: this(...)` (constructor chaining).
6. Pokud žádný konstruktor nenapíšete, kompilátor vytvoří implicitní bezparametrický konstruktor.
