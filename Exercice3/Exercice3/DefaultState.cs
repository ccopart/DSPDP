using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    public class DefaultState : State
    {
        public State DoState(Player player)
        {
            var dices = player.RollTheDices();

            return player.defaultState;
        }
    }
}
