# Metody

Metody v C# jsou bloky kódu, které vykonávají specifické úkoly. Umožňují znovupoužitelnost kódu a zlepšují čitelnost programu.

---

## Argumenty a Parametry

### Co jsou parametry?
- Parametry jsou proměnné definované v hlavičce metody.
- Slouží k předání hodnot do metody.
- Každý parametr musí mít datový typ.

**Příklad:**
```csharp
public void VypisPozdrav(string jmeno)
{
    Console.WriteLine("Ahoj, " + jmeno + "!");
}
```
- `string jmeno` je parametr metody `VypisPozdrav`.

---

### Co jsou argumenty?
- Argumenty jsou hodnoty, které jsou předány metodě při jejím volání.
- Musí odpovídat počtem, typem a pořadím parametrům definovaným v metodě.

**Příklad:**
```csharp
VypisPozdrav("Karle");
```
- "Karle" je argument předaný metodě `VypisPozdrav`.

---

### Počet parametrů v metodě
Metoda může mít libovolný počet parametrů, včetně žádného.

1. **Metoda bez parametrů:**
   ```csharp
   public void Pozdrav()
   {
       Console.WriteLine("Ahoj!");
   }

   Pozdrav(); // Volání metody
   ```

2. **Metoda s jedním parametrem:**
   ```csharp
   public void VypisCislo(int cislo)
   {
       Console.WriteLine("Zadané číslo je: " + cislo);
   }

   VypisCislo(10); // Volání metody s argumentem 10
   ```

3. **Metoda s více parametry:**
   ```csharp
   public void VypocetSouctu(int a, int b)
   {
       Console.WriteLine("Součet je: " + (a + b));
   }

   VypocetSouctu(5, 7); // Volání metody s argumenty 5 a 7
   ```

---

### Hodnotové vs. Referenční parametry

1. **Hodnotové parametry:**
    - Používají se s hodnotovými datovými typy (např. `int`, `double`).
    - Do metody se předává kopie hodnoty, změny uvnitř metody neovlivní původní proměnnou.

   **Příklad:**
   ```csharp
   public void ZvysCislo(int cislo)
   {
       cislo = cislo + 1;
       Console.WriteLine("Hodnota uvnitř metody: " + cislo);
   }

   int x = 5;
   ZvysCislo(x);
   Console.WriteLine("Hodnota mimo metodu: " + x);
   ```
   **Výsledek:**
   ```
   Hodnota uvnitř metody: 6
   Hodnota mimo metodu: 5
   ```

2. **Referenční parametry:**
    - Používají se s objekty nebo referenčními typy.
    - Do metody se předává odkaz na objekt, změny uvnitř metody ovlivní původní objekt.

   **Příklad:**
   ```csharp
   public void PridatKonec(StringBuilder text)
   {
       text.Append(" konec");
   }

   StringBuilder mujText = new StringBuilder("Začátek");
   PridatKonec(mujText);
   Console.WriteLine(mujText);
   ```
   **Výsledek:**
   ```
   Začátek konec
   ```

---

### Klíčové slovo `this` v parametrech

1. **Použití `this`:**
    - Používá se pro odlišení lokální proměnné od člena třídy se stejným jménem.

   **Příklad:**
   ```csharp
   public class Osoba
   {
       private string jmeno;

       public void NastavJmeno(string jmeno)
       {
           this.jmeno = jmeno;
       }
   }
   ```

---

### Důležité pravidla pro parametry

1. Každý parametr musí mít unikátní jméno.
2. Parametry musí odpovídat typem a počtem při volání metody.
3. Parametry jsou do metody předávány hodnotou (kopií) nebo odkazem (u objektů).

---

### Shrnutí
- Parametry umožňují metodám předávat data.
- Argumenty jsou hodnoty předávané při volání metod.
- Hodnotové typy jsou předávány hodnotou, zatímco referenční typy jsou předávány odkazem.
