using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public Setup setup;
        public Player playerOne;
        public string p1Name;
        public Player playerTwo;
        public string p2Name;
        public bool onWhat;
        public int roundNumber;

        public Game()
        {
            setup = new Setup();
            roundNumber = 1;

            List<string> gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("scissors");
            gestures.Add("paper");
            gestures.Add("lizard");
            gestures.Add("spock");
        }
        
        public void StartGame()
        {
            DisplayRules();
            setup.SetupGame();

            WinCondition(setup.BestOf);
            CreatePlayers(setup.Pvp);
            onWhat = setup.OnScissors;
            Console.WriteLine("Time to name the players");
            Console.WriteLine("Player One");
            p1Name = playerOne.ChooseName();
            Console.WriteLine("Player Two");
            p2Name = playerTwo.ChooseName();

            Console.WriteLine("Player One: " + p1Name);
            Console.WriteLine("Player Two: " + p2Name);
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Let's begin!");
            do
            {
                RunRound();
                roundNumber++;
            } while (playerOne.roundsWon != WinCondition(setup.BestOf) && playerTwo.roundsWon != WinCondition(setup.BestOf));

            Console.Write(GameWinner(playerOne.roundsWon, playerTwo.roundsWon));

        }
       
        public void RunRound()
        {
            List<string> Gestures = new List<string>();
            Gestures.Add("rock");
            Gestures.Add("scissors");
            Gestures.Add("paper");
            Gestures.Add("lizard");
            Gestures.Add("spock");

            Console.WriteLine("Round " + roundNumber + ".");
            Console.WriteLine("Player One");
            int p1Choice = playerOne.ChooseGesture();
            Console.Clear();
            Console.WriteLine("Round " + roundNumber + ".");
            Console.WriteLine("Player Two");
            int p2Choice = playerTwo.ChooseGesture();
            Console.Clear();
            if (onWhat == true)
            {
                Console.WriteLine("Rock...Paper...SCISSORS!");
            }
            else
            {
                Console.WriteLine("One, two, three, SHOOT!");
            }


            Console.WriteLine(p1Name + ": " + Gestures[p1Choice - 1]);
            Console.WriteLine(p2Name + ": " + Gestures[p2Choice - 1]);

            int roundWinner = RoundWinner(p1Choice, p2Choice);

            switch (roundWinner)
            {
                case 1:
                    playerOne.roundsWon++;
                    Console.WriteLine(p1Name + " wins the round!");
                    break;
                case 2:
                    playerTwo.roundsWon++;
                    Console.WriteLine(p2Name + " wins the round!");
                    break;
                case 0:
                    Console.WriteLine("Round was a tie.");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public int RoundWinner(int p1Choice, int p2Choice)
        {
            switch (p1Choice)
            {
                case 1:
                    if (p2Choice == 1)
                    {
                        return 0;
                    }
                    if (p2Choice == 2 || p2Choice == 4)
                    {
                        return 1;
                    }
                    break;

                case 2:
                    if (p2Choice == 2)
                    {
                        return 0;
                    }
                    if (p2Choice == 3 || p2Choice == 4)
                    {
                        return 1;
                    }
                    break;

                case 3:
                    if (p2Choice == 3)
                    {
                        return 0;
                    }
                    if (p2Choice == 1 || p2Choice == 5)
                    {
                        return 1;
                    }
                    break;

                case 4:
                    if (p2Choice == 4)
                    {
                        return 0;
                    }
                    if (p2Choice == 3 || p2Choice == 5)
                    {
                        return 1;
                    }
                    break;

                case 5:
                    if (p2Choice == 5)
                    {
                        return 0;
                    }
                    if (p2Choice == 1 || p2Choice == 2)
                    {
                        return 2;
                    }
                    break;

                default:
                    return 2;

            }
            return 2;
        }

        public string GameWinner(int p1Score, int p2Score)
        {
            if (p1Score > p2Score)
            {
                return (p1Name + " wins!");
            }
            else
            {
                return (p2Name + " wins!");
            }
        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock. This game is a variant of the popular game Rock Paper Scissors.");
            Console.WriteLine("This game can be played Player vs. Player, Player vs. AI or can be simulated AI vs. AI. User chooses how many");
            Console.WriteLine("rounds the game is best of. User also chooses whether gesture is made on scissors or on shoot.");
            Console.WriteLine();
            Console.WriteLine("Scissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons spock, spock smashes scissors,");
            Console.WriteLine("scissors decapitates lizard, lizard eats paper, paper disproves spock, spock vaporizes rock and, as always,");
            Console.WriteLine("rock crushes scissors. I don't really know, it's something to do with Star Trek or pediatric psychoanalysis.");
            Console.WriteLine();
            Console.WriteLine("The first player to win enough rounds wins. Good luck!");
            Console.WriteLine();
        }



        public int WinCondition(int bestOf)
        {
            int winRound = (((bestOf - 1) / 2) + 1);
            return winRound;
        }


        public void CreatePlayers(int players)
        {
            if (players == 0)
            {
                playerOne = new Computer();
                playerTwo = new Computer();
            }
            if (players == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            if (players == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }

        }

    }
}


