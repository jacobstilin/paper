using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public int roundsWon;
        public string playerName;

        public Player()
        {
            roundsWon = 0;
        }

        public abstract string ChooseName();

        public abstract int ChooseGesture();

    }
}

