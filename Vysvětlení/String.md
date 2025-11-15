# String v C#

Řetězce (**string**) jsou v C# jedním z nejdůležitějších datových typů pro uchovávání a manipulaci s textem. Jsou reprezentovány typem `string`, což je alias pro třídu `System.String`, která patří mezi základní typy a není třeba ji importovat.

---

## Vlastnosti `string`

- **Neměnnost (Immutability)**: Hodnota objektu typu `string` nelze po vytvoření změnit. Všechny metody, které "mění" řetězec, vracejí nový objekt.
- **Ukládání textu**: Řetězce jsou interně uloženy jako pole znaků typu `char[]`.
- Lze je inicializovat:
  **Doslovným zápisem**:
  ```csharp
  string text = "Ahoj světe!";
  ```
  **Pomocí konstruktoru**:
  ```csharp
  string text = new string("Ahoj světe!".ToCharArray());
  ```

---

## Základní operace

### 1. **Vytváření a skládání řetězců**

Deklarace a inicializace:
```csharp
string jmeno = "Jan";
string prijmeni = "Novák";
```
Skládání řetězců:
```csharp
string celeJmeno = jmeno + " " + prijmeni; // "Jan Novák"
```

### 2. **Základní metody `string`**

| Metoda                 | Popis                                              | Příklad použití                        |
|------------------------|----------------------------------------------------|----------------------------------------|
| `Length`               | Vrací délku řetězce                                | `"Ahoj".Length // 4`                   |
| `charAt(int index)`    | Vrací znak na zadané pozici (v C#: `[index]`)      | `"Ahoj"[1] // 'h'`                     |
| `Substring(int start)` | Vrací podřetězec od daného indexu                  | `"Ahoj".Substring(2) // "oj"`          |
| `IndexOf(string s)`    | Vrací pozici podřetězce, nebo -1, pokud není       | `"Ahoj".IndexOf("oj") // 2`            |
| `ToUpper()`            | Převede všechny znaky na velká písmena             | `"ahoj".ToUpper() // "AHOJ"`           |
| `ToLower()`            | Převede všechny znaky na malá písmena              | `"AHOJ".ToLower() // "ahoj"`           |
| `Trim()`               | Odstraní bílé znaky na začátku a konci řetězce     | `"  Ahoj  ".Trim() // "Ahoj"`          |
| `Replace(char, char)`  | Nahradí všechny výskyty jednoho znaku jiným znakem | `"java".Replace('a', 'o') // "jovo"`   |

---

## Práce s podřetězci

```csharp
string text = "Ahoj světe!";
string podretezec = text.Substring(0, 4);  // "Ahoj"
int pozice = text.IndexOf("světe"); // 5
```

## Porovnávání řetězců 
 
- **Rovnost řetězců**:

```csharp
bool jeStejne = "ahoj" == "ahoj";  // true
// Nebo přes metodu:
bool jeStejneMetoda = "ahoj".Equals("ahoj"); // true
```

- **Ignorování velikosti písmen** :

```csharp
bool jeStejneIgnoreCase = "Ahoj".Equals("ahoj", StringComparison.OrdinalIgnoreCase); // true
```

- **Lexikografické porovnání** :

```csharp
int vysledek = "abc".CompareTo("abd"); // -1
```
