namespace IntroToCs.intro;

public class Variables_Console_printing
{
    public void a()
    {
        // Писане в конзолата (стандартен изход)
        Console.WriteLine("Hello, World!");
        Console.Write("Hello, World!"); //strings
        Console.Write("Hello, World! \n");
        // // <type> <name>; дефиниция или декларация
        // // <type> <name> = value - инициализация 
        string s = "Ivan e 'prekrasen' 321312edasdas$%!@#!@DASDC"; //string
        Console.WriteLine(s);

        // четене от стандартния вход
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name);

        Console.WriteLine("Please enter a symbol:");
        string symbol = Console.ReadLine();
        Console.WriteLine($"{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}");
        Console.WriteLine($"{symbol}{symbol}{symbol}");
        Console.WriteLine($"{symbol}{symbol}{symbol}");
        Console.WriteLine($"{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}");
       // escaping quotes
        Console.WriteLine("Hello \"World!\"");

        //Data types

        int a; // цяло число Stores whole numbers from -2,147,483,648 to 2,147,483,647 on a 64 bits
        long b; // 	Stores whole numbers from -9,223,372,036,854,775,808 to
        float c; // Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
        double d; // Sufficient for storing 15 decimal digits
        bool t; // True/False
        int r = int.Parse(Console.ReadLine());

    }

}