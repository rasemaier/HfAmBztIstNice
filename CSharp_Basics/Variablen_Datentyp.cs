
        int i = 1; // Int Variabel für ganze Zahlen / Ähnliche short, long
        float f = 5.2352f; // Float für Kommazahlen / Ähnliche double, decimal
        char c = 'A'; // Char für Einzelne Zeichen
        string s = "Hallo"; // String für Texte
        bool b = false; // Bool für true oder false

        if (i == 1) // If abfrage zur Variabel i
        {
            i += 14; // i = 1 + 14
            b = true; // b zu true
        }
        else
        {
            i += 1;
            b = false;
        }

        Console.WriteLine("Int: {0}", i); // Ausgabe von Int i
        Console.WriteLine("Float: {0}", f); // Ausgabe von float f
        Console.WriteLine("Char: {0}", c); // Ausgabe von char c
        Console.WriteLine("String: {0}", s); // Ausgabe von string s
        Console.WriteLine("Bool: {0}", b); // Ausgabe von bool b
         //Console.WriteLine("Int: {0} Float: {0} Char: {0} String: {0} Bool: {0}", i, f, c, s, b);