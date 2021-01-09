using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    public class DefaultState : State
    {
        public State DoState(Player player)
        {
            int numberOfConsecutiveDoubles = 0;
            while(true)
            {
                var dices = player.RollTheDices();
                if (numberOfConsecutiveDoubles == 2 && dices.Item3)//if it is the 3 consecutive double
                {
                    Console.WriteLine(player.GetPseudo() +" a réalisé un 3eme double d'affilé. Direction prison en case 10.");
                    player.SetPosition(10);
                    return player.jailState;
                }
                player.IncrementPosition(dices);
                Console.WriteLine(player.GetPseudo() + " avance jusqu'à la case "+ player.GetPosition()+".");
                if (player.GetPosition() == 30)
                {
                    Console.WriteLine("C'est la case 'Go To Jail', il va donc en prison case 10.");
                    player.SetPosition(10);
                    return player.jailState;
                }
                else
                {
                    if (dices.Item3)//If the dices are equals
                    {
                        numberOfConsecutiveDoubles++;
                        Console.WriteLine("\n" + player.GetPseudo() + " a fait un double, appuyer sur ENTREE pour le faire rejouer...");
                        Console.ReadKey();
                    }
                    else return player.defaultState;
                }
            }
        }
    }
}
