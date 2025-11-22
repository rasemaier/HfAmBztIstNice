using System;

class Program
{
    static void Main()
    {
        // Frage: Wie oft soll die Schleife laufen?
        Console.Write("Wie oft soll ich dich etwas fragen? ");
        int anzahl = int.Parse(Console.ReadLine());

        // for-Schleife, die dich mehrmals etwas fragt
        for (int i = 1; i <= anzahl; i++)
        {
            Console.Write("Frage " + i + ": Wie heißt du? ");
            string name = Console.ReadLine();

            Console.WriteLine("Antwort " + i + ": Hallo " + name + "!");
            Console.WriteLine(); // leere Zeile für Übersicht
        }

        Console.WriteLine("Fertig! Drücke Enter zum Beenden.");
        Console.ReadLine();
    }
}
