namespace IntroToCs;

public class Player
{
    private Card cards;
    private string playerName;
    private int age;
    
    public Card Cards { get => cards; set => cards = value; }
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
        return new Card("K", "red");
    }

    public void winCards(Card a, Card b)
    {
        
    }
    public void winCards(Card a, Card b, Card c, Card d, Card e, Card f, Card g, Card h)
    {
        // TODO getIntoTheDeck
    }
}
