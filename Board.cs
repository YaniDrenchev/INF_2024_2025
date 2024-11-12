namespace IntroToCs;

public class Board
{
    private string powerOfCards = "2 3 4 5 6 7 8 9 10 J Q K A";
    private Player player1;
    private Player player2;
    private string state; 
        
    Board(Player p1, Player p2)
    {
        player1 = p1;
        player2 = p2;
        state = "Playing";
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