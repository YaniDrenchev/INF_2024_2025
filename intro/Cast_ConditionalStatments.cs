namespace IntroToCs.intro;

public class Cast_ConditionalStatments
{
    public void a()
    {

        // WHAT IS Parse?
        float var = float.Parse(Console.ReadLine());
        float var2 = float.Parse(Console.ReadLine());
        //Cast (implicit) 
        double sum = var + var2;
        //
        // Сравнете числата по абсолютна стойност
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        bool first = Math.Abs(firstNum) > Math.Abs(secondNum);
        bool second = firstNum > secondNum;
        //

        // MATH - class
        Console.WriteLine(Math.Ceiling(4.5));
        Console.WriteLine(Math.Floor(4.5));
        //
        // ЗАД: Намерете по-голямото от две числа
        int first1 = int.Parse(Console.ReadLine());
        int second1 = int.Parse(Console.ReadLine());
        int max = Math.Max(first1, second1);
        Console.WriteLine(max);
        //Зад 3/38 стр
        double r, c, s;
        r = double.Parse(Console.ReadLine());
        c = 2 * Math.PI * r;
        s = Math.PI * Math.Pow(r, 2);
        Console.WriteLine(s);
        Console.WriteLine(c);
        // BOOL Algebra
        int e = 2;
        int f = 2;
        bool g = e <= f;

        bool gg = true;
        //
        Console.WriteLine(!!!gg);
        // конюнкция - логическо И (&&)
        // дизункция - логическо ИЛИ (||)
        // негация - логическо отрицание (!)


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

    }
}
