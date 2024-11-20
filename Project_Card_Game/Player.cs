namespace IntroToCs.Project_Card_Game;

public class Player
{
    private List<Card> _cards = new List<Card>();
    private string playerName;
    
    public List<Card> Cards { get => _cards; set => _cards = value; }
    public string PlayerName
    {
        get => playerName;
        set => playerName = value;
    }
    public Player(string playerName, int age)
    {
        this.playerName = playerName;
    }

    public Card putCardOnTable()
    {
        Console.WriteLine($"Player Name: {playerName} put card on the table {_cards.First().Symbol} " );
        if (_cards.Count == 0)
        {
            return null; 
        }
        Card card = _cards.First();
        _cards.Remove(card);
        return card;
    }
    public void getCard(Card card)
    { 
        _cards.Add(card);
    }
}
