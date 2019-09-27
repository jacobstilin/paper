using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        static Random rng = new Random(DateTime.Now.Millisecond);

        public Computer()
        {

        }

        public override string ChooseName()
        {
            Console.WriteLine("Computer choosing name...");
            int randomNumber = rng.Next(31);
            string computerName;
            switch (randomNumber)
            {
                case 1:
                    computerName = "Pastelle Pete";
                    break;
                case 2:
                    computerName = "Donahue Plower";
                    break;
                case 3:
                    computerName = "Steve";
                    break;
                case 4:
                    computerName = "Phil";
                    break;
                case 5:
                    computerName = "Sven Dingo";
                    break;
                case 6:
                    computerName = "Piotr Puczapstik";
                    break;
                case 7:
                    computerName = "Jean Poole";
                    break;
                case 8:
                    computerName = "Lucy Goosi";
                    break;
                case 9:
                    computerName = "Leonard Washington";
                    break;
                case 10:
                    computerName = "Joey Bamma";
                    break;
                case 11:
                    computerName = "Junebug";
                    break;
                case 12:
                    computerName = "George Porridge";
                    break;
                case 13:
                    computerName = "Liam Neesons";
                    break;
                case 14:
                    computerName = "Lou Gehrigs";
                    break;
                case 15:
                    computerName = "Mister Mojo";
                    break;
                case 16:
                    computerName = "Juan Poncho";
                    break;
                case 17:
                    computerName = "Charlie Chomps";
                    break;
                case 18:
                    computerName = "Jimmy Bags";
                    break;
                case 19:
                    computerName = "Kevin Baasdan";
                    break;
                case 20:
                    computerName = "Gucci Maine";
                    break;
                case 21:
                    computerName = "Duncan Joans";
                    break;
                case 22:
                    computerName = "Chris Kringle";
                    break;
                case 23:
                    computerName = "Cuffs";
                    break;
                case 24:
                    computerName = "The Big Ragu";
                    break;
                case 25:
                    computerName = "Larry Barry";
                    break;
                case 26:
                    computerName = "Tron";
                    break;
                case 27:
                    computerName = "Leon Isaac Kennedy";
                    break;
                case 28:
                    computerName = "Omar Little";
                    break;
                case 29:
                    computerName = "Sherman Hemsley";
                    break;
                case 30:
                    computerName = "Grif Simmons";
                    break;
                default:
                    computerName = "Joe";
                    break;
            }
            return computerName;
        }

        public override int ChooseGesture()
        {
            int randomNumber = rng.Next(1, 6);
            return randomNumber;
        }
    }
}