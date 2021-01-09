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
                player.IncrementPosition(play);
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
