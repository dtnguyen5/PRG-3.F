# Dědičnost – pokročilé použití a práce s polem (C#)

---

## 1. Na co si dát pozor u dědičnosti

| ⚠️ Problém                        | Vysvětlení                                                                                             | Jak tomu předejít                                                                                                             |
|----------------------------------|--------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------|
| **Nevolání konstruktoru rodiče** | Pokud rodič inicializuje důležité atributy, potomek je musí zavolat pomocí `base(...)`.                | Vždy definuj vhodný konstruktor v rodiči a v potomkovi ho volej jako první příkaz (pomocí `: base(...)`).                     |
| **Skrytí (shadowing) atributů**  | `string Name` v rodiči a znovu `string Name` v potomkovi vede ke dvěma různým proměnným.               | Nepoužívej stejné názvy atributů; používej `private` pole + veřejné vlastnosti (`public string Name { get; set; }`).          |
| **Omyly při přepisování**        | Chybějící `override` nebo jiné parametry ⇒ metoda se **nepřepíše** ale může být **skryta** (`new`).    | Označ metodu `override` v potomkovi; pokud úmyslně skrýváš, použij `new` a dokumentuj to.                                      |
| **`private` vs `protected`**     | `private` členy nejsou vidět v potomkovi; studenti pak sahají přímo do atributů → porušení zapouzdření. | Označ pole `private` a poskytni `protected` nebo `public` vlastnosti/metody pro kontrolovaný přístup.                           |
| **`sealed` třídy/metody**        | `sealed` zabraňuje dědění nebo přepisování – to je v pořádku, ale musíš o tom vědět.                   | Pokud plánuješ dědit, třída/metoda nesmí být `sealed`.                                                                          |
| **Kovariance polí (viz níže)**   | `Animal[]` může odkazovat na `Dog[]`, ale při zápisu jiného typu se objeví běhová výjimka `ArrayTypeMismatchException`. | Nepoužívej míchání typů v poli, které vzniklo jako konkrétní podtřída; místo toho použij generické kolekce `List<Animal>` apod. |

---

## 2. Dědičnost a pole v praxi

### 2.1 Polymorfní pole

```csharp
using System;

class Program
{
    static void Main()
    {
        Animal[] zoo = {
            new Dog("Rex"),
            new Cat("Micka"),
            new Dog("Azor")
        };

        foreach (var a in zoo)
        {
            a.MakeNoise(); // volá správnou přepsanou verzi podle skutečného typu
        }
    }
}

abstract class Animal
{
    protected string Name;
    public Animal(string name) => Name = name;
    public abstract void MakeNoise();
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override void MakeNoise() => Console.WriteLine("Haf haf");
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override void MakeNoise() => Console.WriteLine("Mňau");
}
```

Výstup:
```
Haf haf
Mňau
Haf haf
```

Díky polymorfismu nemusíme řešit, jaký konkrétní druh zvířete v poli je — CLR to zjistí až za běhu.

---

### 2.2 Kovariance polí

V C# (stejně jako v Javě) jsou pole kovariantní: lze přiřadit `Dog[]` do `Animal[]`. To kompilátor povolí, ale při pokusu zapsat jiný typ nastane běhová výjimka.

```csharp
Dog[] dogs = new Dog[2];
Animal[] animals = dogs; // kompilátor povolí

animals[0] = new Cat("Micka"); // Běhová výjimka: ArrayTypeMismatchException
```

Závěr: nikdy nemíchej typy v poli, které fyzicky obsahuje konkrétní podtřídu. Raději použij generické kolekce (např. List<Animal>) nebo vytvoř nové pole správného typu.

---

### 2.3 Pole a přepsané (override) metody

```csharp
using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Rectangle : Shape
{
    private double w, h;
    public Rectangle(double w, double h) { this.w = w; this.h = h; }
    public override double GetArea() => w * h;
}

class Circle : Shape
{
    private double r;
    public Circle(double r) { this.r = r; }
    public override double GetArea() => Math.PI * r * r;
}

class ShapesDemo
{
    static void Main()
    {
        Shape[] shapes = { new Rectangle(3, 4), new Circle(2) };
        double total = 0;
        foreach (var s in shapes) total += s.GetArea();
        Console.WriteLine("Celkový obsah: " + total);
    }
}
```

Každý prvek vrátí svou vlastní implementaci `GetArea()`. Pole tak umožní jednotné zpracování různých tvarů.

---

## 3. Kompletní příklady

### 3.1 Malá ZOO

```csharp
using System;
using System.Collections.Generic;

abstract class Animal
{
    protected string name;
    public Animal(string name) => this.name = name;
    public abstract void MakeNoise();
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void MakeNoise()
    {
        Console.WriteLine("Haf haf – jsem " + name);
    }

    public void FetchStick()
    {
        Console.WriteLine(name + " aportuje klacek!");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeNoise()
    {
        Console.WriteLine("Mňau – jsem " + name);
    }
}

class ZooDemo
{
    static void Main()
    {
        Animal[] zoo = { new Dog("Rex"), new Cat("Micka") };
        foreach (var a in zoo) a.MakeNoise();
    }
}
```

---

### 3.2 Geometrické tvary a součet plochy

```csharp
using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Rectangle : Shape
{
    private double w, h;
    public Rectangle(double w, double h) { this.w = w; this.h = h; }
    public override double GetArea() => w * h;
}

class Circle : Shape
{
    private double r;
    public Circle(double r) { this.r = r; }
    public override double GetArea() => Math.PI * r * r;
}

class ShapesDemo
{
    static void Main()
    {
        Shape[] shapes = { new Rectangle(3, 4), new Circle(2) };
        double total = 0;
        foreach (var s in shapes) total += s.GetArea();
        Console.WriteLine("Celkový obsah: " + total);
    }
}
```

---

### 3.3 Hlídaná psů (ukázka chyby - kovariance polí)

```csharp
using System;

class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override void MakeNoise() => Console.WriteLine("Haf");
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override void MakeNoise() => Console.WriteLine("Mňau");
}

abstract class Animal
{
    protected string name;
    public Animal(string name) => this.name = name;
    public abstract void MakeNoise();
}

class CovarianceDemo
{
    static void Main()
    {
        Dog[] dogs = { new Dog("Rex"), new Dog("Blesk") };
        Animal[] animals = dogs; // stále jde o Dog[] fyzicky

        // Následující řádek vyhodí ArrayTypeMismatchException v C#
        animals[1] = new Cat("Micka"); // Chyba!!
    }
}
```

---

## 4. Shrnutí

- Polymorfismus dovoluje zpracovat různé potomky jednotně pomocí pole rodičovského typu.
- Pole jsou v C# také kovariantní — `Child[]` lze přiřadit do `Parent[]`, což může vést k běhové chybě (`ArrayTypeMismatchException`).
- Vždy kontroluj přepisování metod pomocí klíčového slova `override` a vyhýbej se zbytečnému skrývání členů (shadowing).
- Pro flexibilnější práci se smíšenými objekty používej generické kolekce (`List<Super>`) — tam kompilátor řeší typovou bezpečnost lépe než pole.
- Preferuj `private` pole + veřejné vlastnosti (gettery/settery) místo přímého přístupu k atributům z potomků.

---

### Otázky k diskusi

1. Proč je při práci s polem vhodné volat metody (polymorfismus) místo přímého přístupu k atributům?  
2. Kdy použít `protected` a kdy raději soukromé atributy s vlastnostmi (gettery/settery)?  
3. Jak bys předělal příklad se zvířaty, aby k běhové chybě nikdy nedošlo?  
