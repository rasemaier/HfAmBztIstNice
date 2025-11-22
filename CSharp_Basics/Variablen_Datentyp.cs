using System;

class Program
{
    static void Main()
    {
        int i = 1; // Int Variabel für ganze Zahlen / Ähnliche short, long
        float f = 5.2352f; // Float für Kommazahlen / Ähnliche double, decimal
        char c = 'A'; // Char für Einzelne Zeichen
        string s = "Hallo"; // String für Texte
        bool b = false; // Bool für true oder false

    if(i == 1) // If abfrage zur Variabel i
        {
            i += 14; // i = 1 + 14
            b = true; // b zu true
        }
    else
        {
            i += 1;
        }
        
        Console.WriteLine(i); // Ausgabe von Int i
        Console.WriteLine(f); // Ausgabe von float f
        Console.WriteLine(c); // Ausgabe von char c
        Console.WriteLine(s); // Ausgabe von string s
        Console.WriteLine(b); // Ausgabe von bool b
    }
}
