namespace IntroToCs.Project_Card_Game;

public class Board
{
    private List<string> powerOfCards = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    private List<Card> cards = new List<Card>();
    private Player player1;
    private Player player2;
    private string state; 
        
    Board(Player p1, Player p2)
    {
        int card = 2;
      
        foreach (string card1 in powerOfCards)
        {
            Card first = new Card(card1);
            Card second = new Card(card1);
            Card third = new Card(card1);
            Card fourth = new Card(card1);
            cards.Add(first);
            cards.Add(second);
            cards.Add(third);
            cards.Add(fourth);
            card++;
        }
        deal();
        player1 = p1;
        player2 = p2;
        state = "Playing";
    }

    void deal()
    {
        int i = 0;
        while (i < 52)
        {
            player1.giveCard(cards[i]);
            player2.giveCard(cards[i+1]);
            i += 2;
        }
    }
    public void playGame()
    {
        while (state == "Playing")
        {
           Card p1 =  player1.getCard();
           Card p2 =  player2.getCard();
           if (powerOfCards.IndexOf(p1.Symbol) > powerOfCards.IndexOf(p2.Symbol))
           {
               player1.winCards(p1, p2);
           }
           else
           {
               player2.winCards(p1, p2);
           }

           while (powerOfCards.IndexOf(p1.Symbol) == powerOfCards.IndexOf(p2.Symbol))
           {
               Card c1 = player1.getCard();
               Card c2 = player1.getCard();
               Card c3 = player1.getCard();
               
               Card c4 = player2.getCard();
               Card c5 = player2.getCard();
               Card c6 = player2.getCard();
            
           }

           if (player1.Cards == null || player2.Cards == null )
           {
               state = "Lost";
           }
        }
    }
}