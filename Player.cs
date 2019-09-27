using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //variables
        public int roundsWon;
        public string playerName;


        //constructor
        public Player()
        {


            roundsWon = 0;
        }

        //methods

        public abstract string ChooseName();

        public abstract int ChooseGesture();


    }
}

