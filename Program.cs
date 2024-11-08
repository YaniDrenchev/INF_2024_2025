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

        // int year = int.Parse(Console.ReadLine());
        // if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
        // {
        //     Console.WriteLine("Leap Year");
        // }
        // else
        // {
        //     Console.WriteLine("Not Leap");
        // }    
// въвежда се оценка от 2-6 и се изкарва сътоветно "Слаб, Среден, Добър .. Отличен") 
        // int grade = int.Parse(Console.ReadLine());
        // switch (grade)
        // {
        //     case 2:
        //         Console.Write("Слаб 2");
        //         break;
        //     case 3:
        //         Console.Write("Среден 3");
        //         break;
        //     case 4:
        //         Console.Write("Добър 4");
        //         break;
        //     case 5:
        //         Console.Write("Мн. Добър 5");
        //         break;
        //     case 6:
        //         Console.Write("Отличен 6");
        //         break;
        // }
        //     char gender = char.Parse(Console.ReadLine());
        //     int years = int.Parse(Console.ReadLine());
        //     switch (gender)
        //     {
        //         case 'm':
        //             if (years >= 16) {
        //                 Console.WriteLine("Mr.");
        //             }
        //             else {
        //                 Console.WriteLine("Master.");
        //             }
        //             break;
        //         case 'f':
        //             if (years >= 16) {
        //                 Console.WriteLine("Ms.");
        //             }else {
        //                 Console.WriteLine("Miss.");
        //             }
        //             break;
        //         default:
        //             Console.WriteLine("Wrong input!");
        //             break;
        //     }
        // }
        // for

        // int a = 1;
        // a++;
        // a = a + 1;
        // ++a;
        // a += 1;
        // a += 5;
        // a *= 2;// <=> a = a*2;
        // a -= 2;
        // a /= 2;
        // 0 i = 0
        // 1 i = 1
        // 2 i = 2
        // ...
        // 9 i = 9
        // вход число N (ест)
        // изход всички числа между 1 i N (включително), които се делят на 3 без остатък
        // int N = int.Parse(Console.ReadLine());
        // for (int i = 3; i <= N; i+=3)
        // {
        //     Console.WriteLine(i);
        // }


        // Вход число N, M M <= N
        // Да намерим сумата на всички нечетни числа между М i N

        // int sum = 0;
        // int M = int.Parse(Console.ReadLine());
        // int N = int.Parse(Console.ReadLine());
        // for (int i = M; i <= N; i++)
        // {
        //     if (i % 2 == 1)
        //     {
        //         sum = sum + i;
        //     }
        // }
        // // 1 10 // 1 3 5 7 9 SUM = 25
        // Console.WriteLine(sum);

        //Вход: Число А
        // Изход: true/false

        //     long a = long.Parse(Console.ReadLine());
        //     if (a == 2)
        //     {
        //         Console.WriteLine("TRUE");
        //         return;
        //     }
        //     for (int i = 2; i <= Math.Sqrt(a); i++)
        //     {
        //         // a % 2 == 0? = NO
        //         if (a % i == 0)
        //         {
        //             Console.WriteLine("FALSE");
        //             return;
        //         }
        //     }
        //     Console.WriteLine("TRUE");
        // }
        // Вход N - бр. редовете, които ще четем
        // Изход максималното от тях

        // int n = int.Parse(Console.ReadLine());
        // int GLOBALMAX = int.Parse(Console.ReadLine());

        // 5

        // 1
        // 2
        // 3 
        // 4
        // 5
        // for (int i = 1; i < n; i++)
        // {
        //     int newNum = int.Parse(Console.ReadLine());
        //     if (GLOBALMAX < newNum)
        //     {
        //         GLOBALMAX = newNum;
        //     }
        // }
        // Console.WriteLine("IZHOD: " + GLOBALMAX);
        // for (int i = 1, x = 20; i <= 128 || x > 18; i*=2, x--)
        // {
        //     Console.WriteLine("i = {0}, x = {1}", i, x);
        // }
        //

        // Вход: N (nth число на Фибоначи)
        // Изход - стойността на н-тото число

        // int n = int.Parse(Console.ReadLine());
        // const int first = 1;
        // const int second = 1;
        // // if (n == 1 || n == 2)
        // // {
        // //     Console.Write(first);
        // //     return;
        // // }
        //
        // int k, k1;
        // k = first;
        // k1 = second;
        // //?
        // for (int i = 0; i < n-2; i++)
        // {
        //     int next = k1 + k;
        //     k = k1;
        //     k1 = next;
        // }
        // Console.Write(k1);
        // Вход: n
        // изход n!
        
        // n(n-1)(n-2)....1
        // int n = int.Parse(Console.ReadLine());
        // long factorial = 1;
        // for (int i = n; i > 0; i--)
        // {
        //     factorial *= i;
        // }
        // Console.WriteLine(factorial);
        // long fact = 1;
        // for (int i = 1; i <= n; i++)
        // {
        //     fact *= i;
        // }
        // Console.WriteLine(fact);
        
        // Вход N 
                // N реда с реални числа
        // Изход: Сумата на N-те числа
        // int n = int.Parse(Console.ReadLine());
        // double sum = 0;
        // for (int i = 0; i < n; i++)
        // {
        //     double num = double.Parse(Console.ReadLine());
        //     sum += num;
        // }
        // Console.WriteLine(sum);
        // int n = int.Parse(Console.ReadLine());
        // int i = 1;
        // while (i <= n)
        // {
        //     Console.WriteLine(i);
        //     i++;
        // }
        //
        // for (int j = 1; j <= n; j++) Console.WriteLine(i);
        // Напишете игра, в която компютъра намисля число от 1 до 1000 и 
        // вие трябва да го познаете
        // Random random = new();
        // int a = random.Next(1, 1001); 
        // Console.WriteLine("Намислих едно число мебду 1 " +
        //                   "и 1000 - трябва да го познаеш, " +
        //                   "като аз ще ти казвам дали е " +
        //                   "нагоре или надолу от предположеното");
        // int hodove = 1;
        // int guessed = int.Parse(Console.ReadLine());
        // while (guessed != a) {
        //     hodove++;
        //     if (guessed > a) Console.WriteLine("Надолу"); else
        //     {
        //         Console.WriteLine("Нагоре");
        //     }
        //     guessed = int.Parse(Console.ReadLine());
        // }
        // Console.WriteLine("ПОЗНА за {0}", hodove);
        // int guessed = int.Parse(Console.ReadLine());
        // for (;;)
        // {
        //     if (guessed == a)
        //     {
        //         Console.WriteLine("ПОЗНА за {0}", hodove);
        //         break;
        //     }
        //
        //     if (guessed > a) Console.WriteLine("Надолу");
        //     else  Console.WriteLine("Нагоре");
        //     
        //     guessed = int.Parse(Console.ReadLine());
        //     hodove++;
        // }
        // 5 = r
        // 3
        // 1 = x 
        // 2 = y
        
        // 3 = x
        // 6 = y
        // int r = int.Parse(Console.ReadLine());
        // int n = int.Parse(Console.ReadLine());
        // //classic
        // for (int i = 0; i < 2*n; i++)
        // {
        //     double x = Math.Abs(double.Parse(Console.ReadLine()));
        //     double y = Math.Abs(double.Parse(Console.ReadLine()));
        //     double dist = Math.Sqrt(x * x + y * y);
        //     if (r > dist)
        //     {
        //         Console.WriteLine("ВЪТРЕ");
        //     }else if (r < dist)
        //     {
        //         Console.WriteLine("ВЪН");
        //     }else Console.WriteLine("ПО");
        // }
        // modification
        // Console.WriteLine("Въведете център");
        // double xc = double.Parse(Console.ReadLine());
        // double yc = double.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Въведете радиус");
        // int r = int.Parse(Console.ReadLine());
        // Console.WriteLine("Въвеждате колкото искате точки, но за да спрете - Exit Или EXIT");
        // while (true)
        // {
        //     string b = Console.ReadLine();
        //     if (b == "Exit" || b == "EXIT")
        //     {
        //         return;
        //     }
        //     double x = double.Parse(b);
        //     double y = double.Parse(Console.ReadLine());
        //     double dist = Math.Sqrt(Math.Pow((x - xc),2) + Math.Pow((y - yc), 2));
        //     if (r > dist)
        //     {
        //         Console.WriteLine("ВЪТРЕ");
        //     }else if (r < dist)
        //     {
        //         Console.WriteLine("ВЪН");
        //     }else Console.WriteLine("ПО");
        // }
        static void zad1()
        {
            double n, sum;
            sum = 0;
            n = double.Parse(Console.ReadLine());
            while (n >= 0)
            {
                sum += n;
                n = double.Parse(Console.ReadLine());
            }
        
            Console.WriteLine("sum : {0}", sum);
        }
        static void zad2(){
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (a%2==0)  sum += a;
            }

            if (sum < 50 )
            {
                Console.WriteLine("Сумата на числата е по-малка от 50 и е равна на" + sum);
            }
            else
            {
                Console.WriteLine("Сумата на числата е по-голяма от 50 и е равна на " + sum);
            }
        }


        static void zad5()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            while (n != 0)
            {
                if (n % 2 == 0) sum += n;
                else counter++;
            
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("sum : {0}, count: {1}", sum, counter);
        }
    }
}