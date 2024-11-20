using IntroToCs.Project_Card_Game;

namespace IntroToCs;
internal class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Nikola", 16);
        Player player2 = new Player("MIla", 17);
        Board board = new Board(player1, player2);
        board.playGame();
    }

}


      