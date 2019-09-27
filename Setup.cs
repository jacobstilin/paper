using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Setup
    {
        //variables
        public int Pvp;
        public int BestOf;
        public bool OnScissors;
        int input;


        //constructor
        public Setup()
        {
            input = 0;
            Pvp = 3;
        }

        public void SetupGame()
        {
            PvPSelector();
            BestOfSelector();
            OnWhatSelector();
        }

        public void PvPSelector()
        {
            do
            {
                string input;
                Console.WriteLine("Is this PvP, PvE or EvE?");
                input = Console.ReadLine();
                switch (input)
                {
                    case "pvp":
                        Pvp = 2;
                        break;
                    case "pve":
                        Pvp = 1;
                        break;
                    case "eve":
                        Pvp = 0;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid gametype.");
                        break;
                }
            } while (Pvp != 2 && Pvp != 1 && Pvp != 0);
        }

        public void BestOfSelector()
        {
            do
            {
                Console.WriteLine("How many rounds is this best of?");
                string input = Console.ReadLine();

                BestOf = Int32.Parse(input);
                if (BestOf % 2 != 1)
                {
                    Console.WriteLine("Please enter an odd number");
                }
            } while (BestOf % 2 != 1);

            Console.WriteLine("You said it's out of " + BestOf + " rounds.");


        }

        public void OnWhatSelector()
        {
            Console.WriteLine("Is this on scissors or on shoot?");
            string input = Console.ReadLine();
            if (input == "on scissors")
            {
                OnScissors = true;
            }
            if (input == "on shoot")
            {
                Console.WriteLine("Ah, an aristocrat");
                OnScissors = false;
            }
            else
            {
                Console.WriteLine("We'll go on shoot then");
                OnScissors = false;
            }


        }

    }
}