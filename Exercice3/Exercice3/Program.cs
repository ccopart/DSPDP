using System;

namespace Exercice3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBienvenue dans le Monopoly : 'OnlyBoard'.");
            bool rightNumbersOfPlayers = false;
            int numberOfPlayers =0;
            while (!rightNumbersOfPlayers)
            {
                Console.Write("\n\nCombien de joueurs y a-t-il ? ");
                string numberOfPlayersStr = Console.ReadLine();
                int output = 0;
                if (int.TryParse(numberOfPlayersStr, out output) && Convert.ToInt32(numberOfPlayersStr) >1 && Convert.ToInt32(numberOfPlayersStr) <= 8)
                {
                    rightNumbersOfPlayers = true;
                    numberOfPlayers = Convert.ToInt32(numberOfPlayersStr);
                    Console.WriteLine("\n\n");
                }
                else Console.WriteLine("\n\nERREUR : Vous devez écrire un nombre entre 2 et 8 !");
            }
            Player[] players = new Player[numberOfPlayers];
            string nameInput;
            for(int i = 1; i<=numberOfPlayers; i++)
            {
                Console.Write("Entrez le nom du joueur " + i + " : ");
                nameInput = Console.ReadLine();
                players[i-1] = new Player(nameInput);
            }
            bool gameContinues = true;
            while (gameContinues)
            {
                foreach(Player p in players)
                {
                    Console.WriteLine("\n\nAppuyez sur ENTREE pour lancer les dés de "+ p.GetPseudo() + " qui se situe actuellement sur la case "+p.GetPosition()+"...");
                    Console.ReadKey();
                    p.UpdateState();
                }
            }
        }
    }
}
