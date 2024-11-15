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
        switch (command)
        {
            case "%":
                money = money / 2;
                break;
            case "*":
                money = money + 10;
                break;
            default:
                char a = command[0];
                if (Char.IsUpper(a))
                {
                    if (money >= 0.5 * a)
                    {
                        money = money - 0.5 * a;
                        purchases++;
                    }
                }
                else if (Char.IsLower(a))
                {
                    if (money >= 0.3 * a)
                    {
                        money = money + 0.3 * a;
                        purchases++;
                    }
                }
                else
                {
                    if (money >= a)
                    {
                        money = money - a;
                        purchases++;
                    }
                }

                break;
        }
    }
}