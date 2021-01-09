using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    class Player
    {
        string pseudo;
        int position = 0;
        bool jail = false;

        public Player(string pseudo)
        {
            this.pseudo = pseudo;
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
        public bool GetJail()
        {
            return jail;
        }
        public void SetJail(bool jail)
        {
            this.jail = jail;
        }
    }
}
