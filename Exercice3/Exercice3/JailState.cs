using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    public class JailState : State
    {
        public State DoState(Player player)
        {
            var play = player.RollTheDices();
            player.jailPlayCounts += 1;
            if(play.Item3 || player.jailPlayCounts == 3)
            {
                if(play.Item3 && player.jailPlayCounts != 3)
                {
                    Console.WriteLine("Joueur " + player.GetPseudo() + "a fait un double, il sort de prison !");
                }
                else
                {
                    Console.WriteLine("Joueur " + player.GetPseudo() + "a passé 3 tours en prison, il est libre !");
                }
                player.IncrementPosition(play);
                Console.WriteLine("Joueur " + player.GetPseudo() + " avance jusqu'à la case " + player.GetPosition()); 
                player.jailPlayCounts = 0;
                return player.defaultState;
            }
            else
            {
                return player.jailState;
            }
        }
    }
}
