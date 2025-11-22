


//normale Class
var calc = new Calculator2(); //Dient als Identifikator calc referenziert auf Calcuator2 (Class)
Console.WriteLine(calc.Add(4,6)); // Ausabe in CMD (Console ist eine static Class)

public class Calculator2 
{
    // Method with a return value
    public  int Add(int a, int b) //Dies ist eine Funktion
    {
        return a + b;
    }
    public  int Add(int a, int b, int c) //Selbe funktion mit andern Parametern
    {
        return a + b + c;
    }

    public int multiply(int a, int b) //Andere funktion
    {return a * b}

}


