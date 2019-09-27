using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        //variables
        public int choice;

        //constructor
        public Human()
        {

        }

        //methods

        public override string ChooseName()
        {
            Console.WriteLine("Enter a name for this player");
            playerName = Console.ReadLine();
            return playerName;
        }

        public override int ChooseGesture()
        {
            do
            {
                string input;
                Console.WriteLine("Enter your gesture. Rock, Paper, Scissors, Lizard, Spock:");
                input = Console.ReadLine();
                switch (input)
                {

                    case "rock":
                        choice = 1;
                        break;
                    case "scissors":
                        choice = 2;
                        break;
                    case "paper":
                        choice = 3;
                        break;
                    case "lizard":
                        choice = 4;
                        break;
                    case "spock":
                        choice = 5;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid gesture.");
                        break;
                }
            } while (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5);
            return choice;
        }
    }
}
