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

        public DefaultState defaultState = new DefaultState();
        public JailState jailState = new JailState();


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
        public void UpdateState()
        {
            currentState = currentState.DoState(this);
        }
        public (int, int, bool) RollTheDices()
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            return (dice1, dice2, dice1.Equals(dice2));
        }
    }
}
