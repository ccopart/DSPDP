using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    public class DefaultState : State
    {
        public State DoState(Player player)
        {
            bool continuePlaying = true;
            while (continuePlaying)
            {
                var dices = player.RollTheDices();
                player.IncrementPosition(dices);
            }
           

            return player.defaultState;
        }
    }
}
