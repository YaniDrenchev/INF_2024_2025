namespace IntroToCs.intro;

public class Arrays
{
    public void Run()
    {
        
     
        string s = Console.ReadLine();
        string[] stringSep = s.Split(" ");
        foreach (var item in stringSep)
        {
            if (item.Length > 3)
            {
                Console.Write(item);
            }
        }
        
        
        
        List<int> list = new List<int>();
        int i = 0;
        while (i < 10)
        {
            list.Add(int.Parse(Console.ReadLine()));
            i++;
        }
        
        int product = 1;
        foreach (int item in list)
        {
            if (item % 2 == 0)
            {
                product *= item;
            }
        }
        Console.WriteLine(product);

        List<string> list2 = new List<string>();
        
        for (int j = 2; j < 100; j+=2)
        {
            list2.Add(i.ToString() + "ivan");
        }
        
        foreach (var t in list2)
        {
            Console.WriteLine(t);
        }
        

        
        //                0  1  2  3  4  5   6
        int[] numbers = { 1, 2, 3, 4, 5, 6 , 10};
        char[] chars = { 'I', 'V' ,'A', 'N'};
        int [] numbers2 = new int [10];
        
        for (int w = 0; w < numbers2.Length; w++)
        {
            Console.Write(numbers2[w]);
        }
        
        // numbers[6] = 2;
        Console.WriteLine(numbers[6]);
        for (int q = 0; q < chars.Length; q++)
        {
            Console.Write(chars[q]);
        }


    }
}