# Co je OOP v C#?

Objektově orientované programování (OOP) je programovací paradigma, které organizuje kód do objektů.

- Každý objekt kombinuje
  - **stav** (atributy)
  - **chování** (metody)
- Objekty spolu komunikují pomocí volání metod a předávání argumentů.

Principy (stručně):
- Zapouzdření (Encapsulation) — skrývání interní implementace a vystavení veřejného rozhraní.
- Dědičnost (Inheritance) — vytváření nových tříd z již existujících pro opětovné použití kódu.
- Polymorfismus (Polymorphism) — různé objekty mohou reagovat odlišně na stejná volání metod.
- Abstrakce (Abstraction) — modelování podstatných vlastností objektu a skrytí detailů.

---

## Procedurální vs. objektový přístup

### Procedurální přístup

- Organizace: Program se skládá z funkcí (procedur) a sdílených dat.
- Struktura: Kód je sled instrukcí a volání funkcí.
- Výhody: Jednodušší pro malé úlohy, přímočarý tok programu.
- Nevýhody: Hůře udržovatelný a rozšiřitelný pro větší projekty, problém s globálním stavem.

### Objektově orientovaný přístup

- Organizace: Program je rozdělen do tříd a objektů; každý objekt obsahuje data a metody.
- Struktura: Využívá zapouzdření, dědičnost a polymorfismus; vede k modulární a rozšiřitelné struktuře.
- Výhody: Lepší organizace kódu, znovupoužitelnost, snazší údržba.
- Nevýhody: Může zvýšit složitost návrhu a mít mírnou režii.

---

## Úkol

Jaké objekty by měla aplikace z minulého cvičení (2d ArrayList - seznam Tříd)

- Např.: Class (Třída), Student, Schedule, Subject, Teacher — každý s vlastními poli a metodami.

---

## Příklad jednoduché hry OOP.Blackjack

Níže jsou dvě verze téže zjednodušené hry: procedurální a objektově orientovaná v C#. Obě verze používají zjednodušenou logiku: karty mají hodnoty 1–11, cílíme na 21, bez pravidel pro esa apod.

### Procedurální přístup (C#)

```csharp
// ProceduralBlackjack.cs
using System;

class ProceduralBlackjack
{
    private static readonly Random rng = new Random();

    // Karty mají hodnotu 1..11
    static int DrawCard()
    {
        return rng.Next(1, 12); // vrací 1..11 (horní mez exclusive)
    }

    static void Main()
    {
        Console.WriteLine("=== Procedurální Blackjack ===");
        int playerScore = 0;
        int dealerScore = 0;

        // Hráč si lízne dvě karty
        playerScore += DrawCard();
        playerScore += DrawCard();
        Console.WriteLine($"Hráč, tvoje skóre: {playerScore}");

        // Jednoduché rozhodnutí hráče
        Console.Write("Chceš další kartu? (ano/ne): ");
        string decision = Console.ReadLine()?.Trim() ?? "ne";
        if (decision.Equals("ano", StringComparison.OrdinalIgnoreCase))
        {
            playerScore += DrawCard();
            Console.WriteLine($"Nové skóre: {playerScore}");
        }

        // Dealer si lízne dvě karty
        dealerScore += DrawCard();
        dealerScore += DrawCard();
        Console.WriteLine($"Dealerovo skóre: {dealerScore}");

        // Vyhodnocení výsledku
        if (playerScore > 21)
            Console.WriteLine("Hráč prohrál – přetáhl jsi!");
        else if (dealerScore > 21 || playerScore > dealerScore)
            Console.WriteLine("Hráč vyhrál!");
        else if (playerScore < dealerScore)
            Console.WriteLine("Dealer vyhrál!");
        else
            Console.WriteLine("Remíza!");
    }
}
```

*V této verzi je logika rozptýlena v jedné třídě a používají se lokální proměnné pro stav hry.*

---

### Objektově orientovaný přístup (C#)

Rozdělíme logiku do tříd: Card, Deck, Player a BlackjackGame.

```csharp
// OOPBlackjack.cs
using System;
using System.Collections.Generic;

namespace OOPBlackjack
{
    // Reprezentuje jednu kartu (zjednodušeno: pouze hodnota)
    public class Card
    {
        public int Value { get; }

        public Card(int value)
        {
            Value = value;
        }

        public override string ToString() => Value.ToString();
    }

    // Balíček karet
    public class Deck
    {
        private readonly List<Card> cards;
        private readonly Random rng = new Random();

        public Deck()
        {
            cards = new List<Card>();
            // Naplníme balíček opakovaně hodnotami 1..11 (např. 4 sady)
            for (int set = 0; set < 4; set++)
            {
                for (int v = 1; v <= 11; v++)
                {
                    cards.Add(new Card(v));
                }
            }
            Shuffle();
        }

        private void Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                var tmp = cards[i];
                cards[i] = cards[j];
                cards[j] = tmp;
            }
        }

        public Card DrawCard()
        {
            if (cards.Count == 0) throw new InvalidOperationException("Balíček je prázdný.");
            var c = cards[0];
            cards.RemoveAt(0);
            return c;
        }
    }

    // Hráč se jménem a vlastní rukou
    public class Player
    {
        public string Name { get; }
        private readonly List<Card> hand = new List<Card>();

        public Player(string name) => Name = name;

        public void Hit(Card card) => hand.Add(card);

        public int GetScore()
        {
            int sum = 0;
            foreach (var c in hand) sum += c.Value;
            return sum;
        }

        public string ShowHand() => string.Join(", ", hand);
    }

    // Hlavní třída hry
    class BlackjackGame
    {
        static void Main()
        {
            Console.WriteLine("=== OOP Blackjack (C#) ===");
            var deck = new Deck();
            var player = new Player("Hráč");
            var dealer = new Player("Dealer");

            // Hráč si lízne dvě karty
            player.Hit(deck.DrawCard());
            player.Hit(deck.DrawCard());
            Console.WriteLine($"{player.Name}, tvoje karty: {player.ShowHand()} (skóre: {player.GetScore()})");

            Console.Write("Chceš další kartu? (ano/ne): ");
            string decision = Console.ReadLine()?.Trim() ?? "ne";
            if (decision.Equals("ano", StringComparison.OrdinalIgnoreCase))
            {
                player.Hit(deck.DrawCard());
                Console.WriteLine($"Nové karty hráče: {player.ShowHand()} (skóre: {player.GetScore()})");
            }

            // Dealer si lízne dvě karty
            dealer.Hit(deck.DrawCard());
            dealer.Hit(deck.DrawCard());
            Console.WriteLine($"{dealer.Name} karty: {dealer.ShowHand()} (skóre: {dealer.GetScore()})");

            // Vyhodnocení výsledku (stejná jednoduchá pravidla jako v procedurální verzi)
            if (player.GetScore() > 21)
                Console.WriteLine("Hráč prohrál – přetáhl jsi!");
            else if (dealer.GetScore() > 21 || player.GetScore() > dealer.GetScore())
                Console.WriteLine("Hráč vyhrál!");
            else if (player.GetScore() < dealer.GetScore())
                Console.WriteLine("Dealer vyhrál!");
            else
                Console.WriteLine("Remíza!");
        }
    }
}
```

Výhody OOP verze:
- Jasné rozdělení zodpovědností (Deck se stará o karty, Player o ruku).
- Snadnější rozšíření (esa, více hráčů, strategie dealera).
- Snadnější testování jednotlivých částí (DrawCard, GetScore, Shuffle).

---

## Shrnutí

- OOP v C# rozdělí logiku do tříd a instancí, využívá vlastnosti jazyka (generika, vlastnosti, kolekce).
- Procedurální kód je vhodný pro malé ukázky; OOP lépe škáluje a usnadňuje údržbu.
- Typické rozšíření: správné hodnocení es (1 nebo 11), více hráčů, sázení, uživatelské rozhraní nebo unit testy.
