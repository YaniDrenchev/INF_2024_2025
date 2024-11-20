namespace IntroToCs.Project_Card_Game;

public class Board
{
    private List<string> powerOfCards = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    private List<Card> cards = new List<Card>();
    private Player player1;
    private Player player2;
    private string state; 
        
    public Board(Player p1, Player p2)
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
       
        this.player1 = p1;
        this.player2 = p2;
        state = "Playing";
        deal();
    }

   private void deal()
    {
        int i = 0;
        int maxIndex = 51;
        while (i < 52)
        {
            Random random = new Random(); 
            int randomIndex = random.Next(0, maxIndex);
            player1.getCard(cards[randomIndex]);
            cards.RemoveAt(randomIndex);
            player2.getCard(cards[randomIndex]);
            cards.RemoveAt(randomIndex);
            i += 2;
            maxIndex -= 2;
        }
    }

    private bool checkIflost()
    {
        return player1.Cards.Count == 0 || player2.Cards.Count == 0;
    }
    public void playGame()
    {
     
        while (true)
        {
            Console.ReadLine();
            if (checkIflost())
            {
                Console.WriteLine("Game is over Player 1:  {0} Cards \n Player 2 {1} Cards", player1.Cards.Count, player2.Cards.Count );
                break;
            }
            
            List<Card> cardsOnTable = new List<Card>();
           Card p1 =  player1.putCardOnTable();
           Card p2 =  player2.putCardOnTable();
           if (powerOfCards.IndexOf(p1.Symbol) > powerOfCards.IndexOf(p2.Symbol))
           {
               player1.getCard(p1);
               player1.getCard(p2);
               continue;
           }
           else if (powerOfCards.IndexOf(p1.Symbol) < powerOfCards.IndexOf(p2.Symbol))
           {
               player2.getCard(p1);
               player2.getCard(p2);
               continue;
           }

           while (powerOfCards.IndexOf(p1.Symbol) == powerOfCards.IndexOf(p2.Symbol))
           { 
               Console.WriteLine("ВОЙНА");
              cardsOnTable.Add(p1);
              cardsOnTable.Add(p2);
              for (int i = 0; i < 3; i++)
              {
                  Card c1 = player1.putCardOnTable();
                  Card c2 = player2.putCardOnTable();
                  if (c1 != null)
                  {
                      cardsOnTable.Add(c1);
                  }else if (c2 != null)
                  {
                      cardsOnTable.Add(c2);
                  }
                  if (c1 == null)
                  {
                      Card player1LastCard = cardsOnTable[cardsOnTable.Count - 2];
                      if (powerOfCards.IndexOf(player1LastCard.Symbol) > powerOfCards.IndexOf(c2.Symbol))
                      {
                          foreach (var card in cardsOnTable)
                          {
                              player1.getCard(card);
                          }
                      }
                      else if (powerOfCards.IndexOf(player1LastCard.Symbol) < powerOfCards.IndexOf(c2.Symbol))
                      {
                          foreach (var card in cardsOnTable)
                          {
                              player2.getCard(card);
                          }
                      } 
                  }else if (c2 == null)
                  {
                      Card player2LastCard = cardsOnTable[cardsOnTable.Count - 1];
                      if (powerOfCards.IndexOf(c1.Symbol) > powerOfCards.IndexOf(player2LastCard.Symbol))
                      {
                          foreach (var card in cardsOnTable)
                          {
                              player1.getCard(card);
                          }
                      }
                      else if (powerOfCards.IndexOf(c1.Symbol) < powerOfCards.IndexOf(player2LastCard.Symbol))
                      {
                          foreach (var card in cardsOnTable)
                          {
                              player2.getCard(card);
                          }
                      } 
                  }
              }
              p1 = cardsOnTable[cardsOnTable.Count - 2];
              p2 = cardsOnTable[cardsOnTable.Count - 1];
           }
           
           
        }
    }
}