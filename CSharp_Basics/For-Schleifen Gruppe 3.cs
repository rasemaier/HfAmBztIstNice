using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wie oft soll ich zählen?");
        Console.Write("Bitte Zahl eingeben: ");

        // Eingabe lesen
        string eingabe = Console.ReadLine();

        // Eingabe in eine Zahl umwandeln
        int anzahl = int.Parse(eingabe);

        Console.WriteLine("\nIch zähle jetzt bis " + anzahl + ":\n");

        // For-Schleife mit Benutzerwert
        for (int i = 1; i <= anzahl; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nFertig!");
    }
}
