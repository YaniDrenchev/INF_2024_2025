namespace IntroToCs.Project_Card_Game;

public class Player
{
    private List<Card> _cards;
    private string playerName;
    private int age;
    
    
    
    public List<Card> Cards { get => _cards; set => _cards = value; }
    public string PlayerName
    {
        get => playerName;
        set => playerName = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public Player(string playerName, int age)
    {
        this.playerName = playerName;
        this.age = age;
    }

    public Card getCard()
    {
        return _cards.First();
    }
    public void giveCard(Card card)
    { 
        _cards.Add(card);
    }

    public void winCards(Card a, Card b)
    {
        _cards.Add(a);
        _cards.Add(b);
    }
    public void winCards(Card a, Card b, Card c, Card d, Card e, Card f, Card g, Card h)
    {
        // TODO getIntoTheDeck
    }
}
