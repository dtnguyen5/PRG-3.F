# Proměnné

- slouží jako kontejnery pro uchování dat
- v C# **musí** mít každá proměnná definovaný datový typ
- proměnné se můžou jmenovat téměř jakkoliv, ale platí jistá pravidla
    - proměnné mohou obsahovat písmena, číslice a `_`, ale **nesmí** začínat číslicí
    - **nelze** používat klíčová slova pro názvy proměnných.
    - Například: `class`, `static`, `int`, `using` a mnoho dalších ([seznam zde](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/))

### Jak pojmenovávat proměnné? (Zažité konvence)

1. Používejte camelCase = každé nové slovo v proměnné začíná velkým písmenem, až na 1. slovo.
   Příklad: `int pocetStudentu`, `double prumernaZnamka`
2. Nepoužívejte háčky, čárky a jiné znaky mimo základní ASCII znakovou sadu
3. názvy by měly být výstižné a srozumitelné
   1. `int a`, `bool x` <= takhle ne
   2. `int vek`, `int pocetKnih` <= lepší
4. **Konstanty** jsou speciální typ proměnné. 
   1. Hodnota se po inicializaci již nemění.
   2. V C# je klíčové slovo `const` (v Javě bylo `final`)
   3. Všechna písmena v názvu by měla být velká a oddělená znakem `_`

```csharp
// Příklady správně pojmenovaných proměnných
int vek = 25;
double prumernaTeplota = 36.6;
bool isStudent = true;
const int MAX_POCET = 50;

// Příklady špatně pojmenovaných proměnných
int 1cislo = 42;    // začíná číslem - špatně!
int static = 666;   // static je klíčové slovo C#
```

- proměnné lze **deklarovat**

```csharp
// deklarace => připravení proměnné pro následné použití
int cislo;
```

- a následně **inicializovat**

```csharp
// inicializace => první nastavení hodnoty
cislo = 15;
```

- lze provést obojí naráz

```csharp
// deklarace a inicializace zároveň
int cislo = 15;
```

## Datové typy

### 1. Primitivní (Value types)

- základní, jednoduché datové typy
- nejsou odvozené od jiných typů
- **Příklady:**
    - celá čísla: `byte`, `short`, `int`, `long`
    - čísla s desetinou čárkou: `float`, `double`, `decimal`
    - logická hodnota: `bool`
    - jeden znak: `char`
- mají pevnou velikost
- U proměnných typu `int`, `bool` atd. je výchozí hodnota 0 (pro čísla), false, \u0000 (pro char)

Hodnota value typu je přímo uložena v paměti – např. když deklarujete proměnnou `int a = 10;`, hodnota 10 je přímo uložena v proměnné `a`.

### 2. Referenční (Reference types)

- odkazují na objekty v paměti
- **Příklady:** Třídy, objekty, pole, rozhraní, např. `string`, `object`, pole `int[]`, uživatelsky definované třídy
- **Jak fungují?** U referenčních typů proměnná neukládá přímo hodnotu, ale odkaz (adresu) na místo v paměti, kde je uložen skutečný objekt. Například když deklarujete `string str = "Ahoj";`, proměnná `str` neukládá samotný text "Ahoj", ale adresu, kde je tento řetězec uložen v paměti.

#### 2.1 Vlastnosti:
- Neexistuje pevná velikost, závisí na objektu
- Pracuje se s nimi jako s objekty – mohou mít metody a vlastnosti (Vysvětleno později)
- Výchozí hodnota je `null` (neukazují na žádný objekt, dokud nejsou inicializovány)
