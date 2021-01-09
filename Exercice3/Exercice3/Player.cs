using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    public class Player
    {
        private string pseudo;
        private int position = 0;
        private State currentState;

        private DefaultState defaultState = new DefaultState();
        private JailState jailState = new JailState();


        public Player(string pseudo)
        {
            this.pseudo = pseudo;
            currentState = defaultState;
        }

        public void IncrementPosition(Tuple<int,int> dices)
        {
            this.position = (position + dices.Item1 + dices.Item2) % 40;
        }

        public string GetPseudo()
        {
            return pseudo;
        }
        public void SetPseudo(string pseudo)
        {
            this.pseudo = pseudo;
        }
        public int GetPosition()
        {
            return position;
        }
        public void SetPosition(int position)
        {

            this.position = position;
        }
        public State GetCurrentState()
        {
            return currentState;
        }
        public void SetCurrentState(State currentState)
        {
            this.currentState = currentState;
        }
    }
}
