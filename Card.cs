namespace IntroToCs;

public class Card
{
    private string color;
    private string symbol;

    public Card(string symbol, string color)
    {
        this.symbol = symbol;
        this.color = color;
    }
    
    public string Symbol { get => symbol; set => symbol = value; }
    public string Color { get => color; set => color = value; }
}