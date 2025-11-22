using System;

namespace MethodenPraesentation
{
    class Rechner
    {
        // 1. Methode mit Rückgabewert und Parametern
        public int Addiere(int a, int b)
        {
            return a + b;
        }

        // 2. Methode ohne Rückgabewert (void)
        public void Begruesse(string name)
        {
            Console.WriteLine($"Hallo {name}!");
        }

        // 3. Statische Methode (ohne Objekt aufrufbar)
        public static int Quadrat(int x)
        {
            return x * x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Objekt von Rechner erstellen (für nicht-statische Methoden)
            Rechner r = new Rechner();

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
    }
}
