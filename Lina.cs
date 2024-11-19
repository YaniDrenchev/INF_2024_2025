namespace IntroToCs;

// Task from Softuni 
// https://csharp-book.softuni.bg/chapter-09-problems-for-champions-part-2.html
public class Lina
{
    private double money;
    private int purchases;

    public int Purchases
    {
        get => purchases;
        set => purchases = value;
    }

    public double Money
    {
        get => money;
        set => money = value;
    }

    public Lina(double money)
    {
        purchases = 0;
        this.money = money;
    }

    public void executeCommand(string command)
    {
        char symbol = command[0];
        if (symbol == '%')
        {
            money /= 2;
            purchases++;
        }else if (symbol == '*')
        {
            money += 10;
        }else if (Char.IsUpper(symbol))
        {
            if (money >= 0.5 * symbol)
            {
                money -= 0.5 * symbol;
                purchases++;
            }
        }else if (Char.IsLower(symbol))
        {
            if (money >= 0.3 * symbol)
            {
                money -= 0.3 * symbol;
                purchases++;
            }
        }
        else
        {
            if (money >= symbol)
            {
                money -= symbol;
                purchases++;
            }
        }
       
    }
}