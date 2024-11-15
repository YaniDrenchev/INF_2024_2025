namespace IntroToCs.intro;

public class Loops
{
    public void Run()
    {
        // вход: число N (ест)
        // изход: всички числа между 1 i N (включително), които се делят на 3 без остатък
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
    }
}