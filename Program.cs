namespace IntroToCs;

class Program
{
    static int sum()
    {
        int result = 0;
        return 1;
    }
    static void Main(string[] args)
    {
        // Писане в конзолата (стандартен изход)
        // Console.WriteLine("Hello, World!");
        // Console.Write("Hello, World!"); //strings
        // Console.Write("Hello, World! \n");
        // // <type> <name>; дефиниция или декларация
        // // <type> <name> = value - инициализация 
        // string s = "Ivan e 'prekrasen' 321312edasdas$%!@#!@DASDC"; //string
        // Console.WriteLine(s);
        
        // четене от стандартния вход
        // string name = Console.ReadLine();
        // Console.WriteLine("Hello, " + name);
        
        // Console.WriteLine("Please enter a symbol:");
        // string symbol = Console.ReadLine();
        // Console.WriteLine($"{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}");
        // Console.WriteLine($"{symbol}{symbol}{symbol}");
        // Console.WriteLine($"{symbol}{symbol}{symbol}");
        // Console.WriteLine($"{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}{symbol}");
        //escaping кавички
        // Console.WriteLine("Hello \"World!\"");
        
        //Data types

        int a; // цяло число Stores whole numbers from -2,147,483,648 to 2,147,483,647 on a 64 bits
        long b; // 	Stores whole numbers from -9,223,372,036,854,775,808 to
        float c; // Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
        double s; // Sufficient for storing 15 decimal digits
        bool t; // True/False
        // int r = int.Parse(Console.ReadLine());
        
        // const double fixing = 1.95583;
        // double price_of_veg, price_of_fruits;
        // short kg_of_veg, kg_of_fruits;
        // price_of_veg = double.Parse(Console.ReadLine());
        // price_of_fruits = double.Parse(Console.ReadLine());
        // kg_of_veg = short.Parse(Console.ReadLine());
        // kg_of_fruits = short.Parse(Console.ReadLine());
        // double sum = (price_of_veg/fixing)*kg_of_veg + (price_of_fruits/fixing)*kg_of_fruits;
        // sum = Math.Round(sum, 2);
        // Console.WriteLine(sum);
        const double price_per_kvm = 7.61;
        double kvm = double.Parse(Console.ReadLine());
        Console.WriteLine(  (kvm*7.61) - (kvm*7.61) * 0.18);
        Console.WriteLine((kvm * 7.61) * 0.18);
    }
}