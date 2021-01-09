﻿using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameContinues = true;
            bool rightNumbersOfPlayers = false;
            int numberOfPlayers =0;
            while (!rightNumbersOfPlayers)
            {
                Console.Write("\n\nHow many players will there be ? ");
                string numberOfPlayersStr = Console.ReadLine();
                int output = 0;
                if (int.TryParse(numberOfPlayersStr, out output) && Convert.ToInt32(numberOfPlayersStr) >1 && Convert.ToInt32(numberOfPlayersStr) < 8)
                {
                    rightNumbersOfPlayers = true;
                    numberOfPlayers = Convert.ToInt32(numberOfPlayersStr);
                    Console.WriteLine("\n\n");
                }
                else Console.WriteLine("\n\nERROR : You should write a number between 2 and 8 !");
            }
            Player[] players = new Player[numberOfPlayers];
            string nameInput;
            for(int i = 0; i<numberOfPlayers; i++)
            {
                Console.Write("Write the name of player number " + i + " : ");
                nameInput = Console.ReadLine();
                players[i] = new Player(nameInput);
            }

            //foreach(Player p in players)
            //{
            //    Console.WriteLine(p.GetPseudo());
            //}
            
            while (gameContinues)
            {

            }

            var dices = RollTheDices();
        }

        public static (int, int) RollTheDices()
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            return (dice1, dice2);
        }
    }
}