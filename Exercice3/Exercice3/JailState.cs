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
                    Console.WriteLine(player.GetPseudo() + " a fait un double, il sort de prison !");
                }
                else
                {
                    Console.WriteLine(player.GetPseudo() + " a passé 3 tours en prison, il est libre !");
                }
                player.IncrementPosition(play);
                Console.WriteLine(player.GetPseudo() + " avance jusqu'à la case " + player.GetPosition() + "\n"); 
                player.jailPlayCounts = 0;
                return player.defaultState;
            }
            else
            {
                Console.WriteLine(player.GetPseudo() + " n'a pas fait de double, il reste en prison.\n");
                return player.jailState;
            }
        }
    }
}
