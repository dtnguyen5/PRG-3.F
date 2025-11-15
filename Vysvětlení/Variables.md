# Proměnné

- slouží jako kontejnery pro uchování dat
- v C# **musí** mít každá proměnná definovaný datový typ
- proměnné se můžou jmenovat téměř jakkoliv, ale platí jistá pravidla
    - proměnné mohou obsahovat písmena, číslice a `_`, ale **nesmí** začínat číslicí
    - **nelze** používat klíčová slova pro názvy proměnných
    - Například: `class`, `static`, `int`, `using`, `namespace` a mnoho dalších

### Jak pojmenovávat proměnné? (Zažíté konvence)

1. Používejte camelCase = každé nové slovo v proměnné začíná velkým písmenem, až na 1. slovo.  
   Příklad: `int pocetStudentu`, `double prumernaZnamka`
2. Nepoužívejte háčky, čárky a jiné znaky mimo základní ASCII znakovou sadu
3. názvy by měly být výstižné a srozumitelné  
   1. `int a`, `bool x` <= takhle ne  
   2. `int vek`, `int pocetKnih` <= lepší
4. **Konstanty** jsou speciální typ proměnné  
   1. Po inicializaci se hodnota již nemění  
   2. V C# je klíčové slovo `const` (místo `final` v Javě)  
   3. Všechna písmena v názvu by měla být velká a oddělená znakem `_`

```csharp
// Příklady správně pojmenovaných proměnných
int vek = 25;
double prumernaTeplota = 36.6;
bool isStudent = true;
const int MAX_POCET = 50;

// Příklady špatně pojmenovaných proměnných
int 1cislo = 42;    // začíná číslem
int static = 666;   // static je klíčové slovo C#
