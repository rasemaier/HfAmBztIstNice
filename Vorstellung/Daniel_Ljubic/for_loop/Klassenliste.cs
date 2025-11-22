using System;

class Program
{
    static void Main()
    {
            // Frage: Wie viele Schüler sind in der Klasse?
            Console.Write("Wie viele Schüler sind in deiner Klasse? ");
            int anzahl = int.Parse(Console.ReadLine());

            // Array für die Namen der Schüler
            string[] namen = new string[anzahl];

            // for-Schleife, die die Namen abfragt
            for (int i = 0; i < anzahl; i++)
            {
                Console.Write($"Schüler {i + 1}: Wie heißt du? ");
                namen[i] = Console.ReadLine();
            }

            // Namen alphabetisch sortieren
            Array.Sort(namen);

            Console.WriteLine();
            Console.WriteLine("Alle Namen alphabetisch sortiert:");
            foreach (string name in namen)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine("Fertig! Drücke Enter zum Beenden.");
            Console.ReadLine();
    }
}
