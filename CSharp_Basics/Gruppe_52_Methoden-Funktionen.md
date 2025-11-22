# Methoden und Funktionen in C#

## 1. Methode

- **Definition:** Eine Methode ist ein Codeblock innerhalb einer Klasse, der eine bestimmte Aufgabe ausführt.
- **Eigenschaften:**

  - Kann Parameter entgegennehmen.
  - Kann einen Rückgabewert haben oder `void` sein.
  - Kann öffentlich (`public`) oder nur intern (`private`) zugänglich sein.
  - Kann statisch (`static`) oder nicht-statisch sein.

**Beispiel:**

```csharp
public class Rechner
{
    public int Addiere(int a, int b)  // Methode mit Rückgabewert
    {
        return a + b;
    }

    public void Begruesse(string name) // Methode ohne Rückgabewert (void)
    {
        Console.WriteLine($"Hallo {name}!");
    }
}
```

- `Addiere` und `Begruesse` sind **Methoden**.
- Methoden werden über ein Objekt oder die Klasse (bei `static`) aufgerufen.

---

## 2. Funktion

- **Definition:** Eine Funktion ist im Prinzip eine Methode, die **immer einen Rückgabewert liefert**.
- **Eigenschaften:**

  - Muss immer einen Rückgabewert haben.
  - Kann Parameter haben.
  - Wird oft synonym mit "Methode mit Rückgabewert" verwendet.

**Beispiel:**

```csharp
public int Quadrat(int x)  // Funktion
{
    return x * x;  // Gibt einen Wert zurück
}
```

- `Quadrat` ist eine **Funktion**, weil sie einen Wert zurückliefert.
- Methoden ohne Rückgabewert (`void`) nennt man **nicht Funktion**, sondern nur Methode.

---

## 3. Merksatz

| Begriff  | Rückgabewert?             | Gehört zu einer Klasse? |
| -------- | ------------------------- | ----------------------- |
| Methode  | optional (`void` möglich) | ja                      |
| Funktion | ja (immer)                | ja                      |

**Kurz:**

- Jede Funktion ist eine Methode.
- Nicht jede Methode ist eine Funktion.

---

## 4. Praxisbeispiel

```csharp
Rechner r = new Rechner();       // Objekt erstellen
int summe = r.Addiere(3, 5);    // Methode aufrufen
Console.WriteLine(summe);        // Ausgabe: 8

r.Begruesse("Anna");           // Methode ohne Rückgabewert aufrufen

int q = Rechner.Quadrat(4);     // Statische Funktion aufrufen
Console.WriteLine(q);            // Ausgabe: 16
```
