
using System;

class Program
{
    static void Main()
    {
        // Variablen deklarieren
        string name = "Dirk";           // Datentyp: string für Namen
        int alter = 32;                // Datentyp: int für Alter
        double gehalt = 4500.50;       // Datentyp: double für Gehalt
        bool istStudent = true;        // Datentyp: bool für Studentstatus
        decimal rabatt = 0.15m;        // Datentyp: decimal für Rabatt (15%)
        
        // Ausgabe der Informationen
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Alter: " + alter);
        Console.WriteLine("Gehalt: " + gehalt);
        Console.WriteLine("Ist Student: " + istStudent);

        // Berechnung des rabattierten Gehalts, wenn der Benutzer ein Student ist
        double monatlichesGehalt = gehalt;

        if (istStudent)
        {
            monatlichesGehalt = gehalt - (gehalt * (double)rabatt);  // Rabatt anwenden
            Console.WriteLine("Monatliches Gehalt mit Student-Rabatt: " + monatlichesGehalt);
        }
        else
        {
            Console.WriteLine("Monatliches Gehalt ohne Rabatt: " + monatlichesGehalt);
        }
        
        // Debugging: Ausgabe von Zwischenergebnissen
        Console.WriteLine("Rabatt: " + rabatt);
        Console.WriteLine("Berechneter Gehaltsbetrag: " + monatlichesGehalt);
    }
}
