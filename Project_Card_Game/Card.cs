namespace IntroToCs.Project_Card_Game;

public class Card
{
    private string symbol;

    public Card(string symbol)
    {
        this.symbol = symbol;
    }
    
    public string Symbol { get => symbol; set => symbol = value; }
}