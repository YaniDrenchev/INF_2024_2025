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

        // int a; // цяло число Stores whole numbers from -2,147,483,648 to 2,147,483,647 on a 64 bits
        // long b; // 	Stores whole numbers from -9,223,372,036,854,775,808 to
        // float c; // Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
        // double s; // Sufficient for storing 15 decimal digits
        // bool t; // True/False
        // // int r = int.Parse(Console.ReadLine());
        //
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
        // const double price_per_kvm = 7.61;
        // double kvm = double.Parse(Console.ReadLine());
        // Console.WriteLine(  (kvm*7.61) - (kvm*7.61) * 0.18);
        // Console.WriteLine((kvm * 7.61) * 0.18);
        // string b = Console.ReadLine();
        // int a = int.Parse("2");
        // double a = double.Parse("2.0");

        // WHAT IS CAST?
        // float var = float.Parse(Console.ReadLine());
        // float var2 = float.Parse(Console.ReadLine());
        //
        // double sum = var + var2;
        //
        // int first = 2000000000;
        // int second = 3;
        // int sum2 = first + second;

        // Сравнете числата по абсолютна стойност

        // double firstNum = double.Parse(Console.ReadLine());
        // double secondNum = double.Parse(Console.ReadLine());
        // bool first = Math.Abs(firstNum) > Math.Abs(secondNum);
        // bool second = firstNum > secondNum;
        //


        // Console.WriteLine(Math.Ceiling(4.5));
        // Console.WriteLine(Math.Floor(4.5));
        //
        // // ЗАД: Намерете по-голямото от две числа
        // int first = int.Parse(Console.ReadLine());
        // int second = int.Parse(Console.ReadLine());
        // int max = Math.Max(first, second);
        // Console.WriteLine(max);
        //Зад 3/38 стр
        // double r, c, s;
        // r = double.Parse(Console.ReadLine());
        // c = 2 * Math.PI * r;
        // s = Math.PI * Math.Pow(r, 2);
        // Console.WriteLine(s);
        // Console.WriteLine(c);

        // int a = 2;
        // int b = 2;
        // bool c = a <= b;
        // bool s = a != b;
        //
        // bool gg = true;
        //
        // Console.WriteLine(!!!gg);
        // конюнкция - логическо И (&&)
        // дизункция - логическо ИЛИ (||)
        // негация - логическо отрицание (!)
        // int a = 0;
        // bool c = (a >= 0) && (a <= 10);
        // // int b = 4;
        // // bool c = ((a > 0) && (b != a)) && ((a == 2) && (b - a) > Math.Abs(-5));
        // //
        // Console.WriteLine(a);
        // double a, b, c, d;
        // a = double.Parse(Console.ReadLine());
        // b = double.Parse(Console.ReadLine());
        // c = double.Parse(Console.ReadLine());
        // d = double.Parse(Console.ReadLine());
        //
        // // a b    c d 
        // // c d    a b
        // bool intersect = ! ((b < c) || (d < a));
        // Console.WriteLine(intersect);

        // Тернарен оператор <uslovie>?<operator_true>:<operator_fasle>
        // int a = 10;
        // int b = 4;
        // int c;
        // c = a <= b ? 2 : 3;
        // Console.WriteLine(c);

        // if(<uslovie>) { <operator true>}
        // Решете уравнението от типа ax + b = 0, a AND b in R
        // double a = double.Parse(Console.ReadLine());
        // double b = double.Parse(Console.ReadLine());
        // // Ако a = 0 и b = 0 => V x resh
        // // a = 0 и b != 0 => No sol
        // // a != 0 and b != 0 => x = -b/a
        // if (a == 0 && b == 0)
        // {
        //     Console.WriteLine("Всяко Х е реш");
        // }else if (a == 0 && b != 0)
        // {
        //     Console.WriteLine("Няма решение");
        // }
        // else if (a != 0 && b == 0)
        // {
        //     Console.WriteLine(0);
        // }
        // else
        // {
        //     double sol = -b / a;
        //     Console.WriteLine(sol);
        // }
        //
        //
        //
        // Кв уравнение
//        double a = double.Parse(Console.ReadLine());
//        double b = double.Parse(Console.ReadLine());
//        double c = double.Parse(Console.ReadLine());
//        
//        double result = (a + b + c) / 3;
//        Console.WriteLine(result);
//        
//        
//        if (a != 0)
//        {
//            double d = Math.Pow(b, 2) - 4 * a * c;
//            if (d < 0)
//            {
//                Console.WriteLine("Няма реални корени");
//            }else if (d == 0)
//            {    
//                // Приоритет на действие на операциите
//                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//                Console.WriteLine($"Двоен корен: {x1}");
//            }
//            else
//            {
//                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//                Console.WriteLine($"Корените са: {x1} и {x2}");
//            }
//        }else if (b == 0 && c == 0)
//        {
//            Console.WriteLine("Всяко Х е реш");
//        }
//        else
//        {
//            double res = (-c/b == -0) ? 0 : -c/b;
//            Console.WriteLine(res);
//        }
//     }
// }
//This is how the Gregorian calendar calculates
//leap years: If the year is divisible by four, it's a leap year.
//But if the year can be divided by 100 as well as four, it's not a leap year.
//However, if the year is divisible by 400, it is a leap year.Ï

        int year = int.Parse(Console.ReadLine());
        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not Leap");
        }    
    }
}