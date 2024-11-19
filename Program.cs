namespace IntroToCs;



internal class Program
{
    static void Main(string[] args)
    {
        double money = double.Parse(Console.ReadLine());

        Lina lina = new Lina(money);
        string command = Console.ReadLine();

        while (command != "mall.Enter")
        {
             command = Console.ReadLine();
        }
     
        while (command != "mall.Exit")
        {
            command = Console.ReadLine();
            if (command == "mall.Exit")
            {
                break;
            }
            lina.executeCommand(command);
        }
        Console.WriteLine($"Purchases: {lina.Purchases}, Money: {lina.Money}");
        
        //
        // Drob drob = new Drob(2, 8);
        // Drob drob1 = new Drob(5, 10);
        //
        // Drob.print(Drob.umnojenie(drob, drob1));
        // Drob.print(Drob.delenie(drob, drob1));
        // Drob.print(Drob.sum(drob, drob1));
        // Drob.print(Drob.minus(drob, drob1));
        // List<int> newList = new List<int>();
        // newList.Add(1);
        //
        // Player ivan = new Player("Ivan", 12);

    }

}


      