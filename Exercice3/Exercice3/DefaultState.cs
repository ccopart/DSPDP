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
                    player.SetPosition(10);
                    return player.jailState;
                }
                player.IncrementPosition(dices);
                if (player.GetPosition() == 30)
                {
                    player.SetPosition(10);
                    return player.jailState;
                }
                else
                {
                    if (dices.Item3)//If the dices are equals
                    {
                        numberOfConsecutiveDoubles++;
                    }
                    else return player.defaultState;
                }
            }
        }
    }
}
