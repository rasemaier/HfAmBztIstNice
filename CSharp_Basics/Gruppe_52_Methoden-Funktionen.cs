
// Neues Objekt von der Klasse "Rechner" erstellen
Rechner r = new Rechner();

// Aufruf 1: Methode mit Rückgabewert
int summe1 = r.Addiere(5, 7);
Console.WriteLine($"5 + 7 = {summe1}");

// Aufruf 2: void-Methode
r.Begruesse("Talip");

// Aufruf 3: statische Methode
int q = Rechner.Quadrat(4);
Console.WriteLine($"4² = {q}");

string input = Console.ReadLine();
Console.WriteLine($"Du hast '{input}' eingegeben.");


public class Rechner  // Definition der Klasse "Rechner"
{
    // 1. Methode mit Rückgabewert und Parametern
    public int Addiere(int a, int b)  // Methode "Addiere" nimmt zwei int-Werte
    {
        return a + b;  // Gibt die Summe von a und b zurück
    }

    // 2. Methode ohne Rückgabewert (void)
    public void Begruesse(string name)  // Methode "Begruesse" nimmt einen string-Parameter
    {
        Console.WriteLine($"Hallo {name}!");  // Gibt eine Begrüßung in der Konsole aus
    }

<<<<<<< HEAD
    // 3. Statische Methode (ohne Objekt aufrufbar)
    public static int Quadrat(int x)  // Methode "Quadrat" ist statisch, braucht kein Objekt
    {
        return x * x;  // Gibt das Quadrat von x zurück
=======
            // Aufruf 1: Methode mit Rückgabewert
            int summe = r.Addiere(10, 25);
            Console.WriteLine($"10 + 25 = {summe}");

            // Aufruf 2: void-Methode
            r.Begruesse("zusammen");

            // Aufruf 3: statische Methode
            int q = Rechner.Quadrat(11);
            Console.WriteLine($"11² = {q}");

            Console.WriteLine("Drücke eine Taste zum Beenden...");
            Console.ReadKey();
        }
>>>>>>> d222704a84957f34d137528488e1bea18d412649
    }
}
