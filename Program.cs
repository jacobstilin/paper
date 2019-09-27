using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
            Console.ReadLine();
        }
    }
}



/*Let's take some notes today.
 *  
 * 
 * 
 *  increment winner score, (increment round number if not tie?), check if game over, if yes congrats, if no choose gestures again. 
 * Each of these steps is a method.
 * Classes: Game, Player, Human, Computer, Gesture
 * Game class
 *  Variables: 
 *  Player playerOne, Player playerTwo
 *  Human playerOne = new Human();
 *  Computer playerTwo = new Computer();
 *  When we instantiate we are declaring a variable and assigning it a value
 *  These objects hold many variables and methods. I guess a class is like a bunch of variables
 * Player attributes: int roundsWon, string name, string gesture (choice?)
 * Player methods: choose gesture, 
 * Choose gesture could return or be void. Could change member variable (but how to use it?)
 * Player can be abstract (not sure why, find out) and we won't instantiate it
 * Name choose method could be a void abstract method as well.
 * Abstract method ends with ;
 * I think it has something to do with inheritance
 * Human inherits from Player as in Human:Player
 * public override void ChooseGesture and ChooseName is all it really needs
 * Computer inherits from Player, Computer:Player
 * public override void ChooseGesture (random)
 * Instantiate random class premade in C#
 * Through inheritance human automatically has member variables (I think)
 * Human:Player class has method like public override void ChooseGesture() {}
 *  CWL("Choose gesture");
 *  gesture (from player) = CRL():
 *  
 * Don't write string gesture because it is inherited.
 * If I did write string gesture it would override the inherited gesture and scope it local
 * Public override method chooses how public abstract works
 * Could use inherit for Gesture class. Class for each gesture that inherits
 * Abstract class: can't be instantiated
 * Abstract method: can be overrided
 * Public: seen in every other class. Always use when inheritance needed
 * Private: find out
 * Protected: find out
 * If you don't make variables public they default to private and can only be seen in scope of class
 * Come up with random names for the computer
 * 
 * Don't know why but: (in Game class ig) QUESTION can these be done in the Setup class
 * public int GetNumberOfPlayers
 * CWL("How many players");
 * int numberOfPlayers = int.Parse(CRL);
 * return numberOfPlayers;
 * 
 * public void CreatePlayers(int numberOfPlayers)
 * if number of players is 1, playerOne = new Human(), playerTwo = new Computer(), maybe if zero players two computers
 * type shit
 * then the RunGame method
 * int numberOfPlayers = GetNumberOfPlayers();
 * CreatePlayers(numberOfPlayers)
 * playerOne.ChooseGesture();
 * playerTwo.ChooseGesture();
 * playerOne.gesture
 *  if gesture is public then playerOne.gesture is diff from playerTwo.gesture and shit 
 * 
 * This method can be kept the same and the program will know if the player is a computer or a player and choose gesture accordingly
 * I guess you don't have to pass in the member variables as parameters if they are scoped in the class ...
 * 
 * Gesture class:
 * Gesture objects. Variables could be a string name or int value. Makes sense because we could add more gestures (e.g. lizard, spock)
 *  
 *  Figure out how to get a random number
 *  
 *  
 *  
 *  
 *  SOLID design principals
 *  
 *  Single responsibility principal
 *  every class and function should do one thing. once things do more than one thing let's break it down
 *  
 *  Open/closed prince
 *  open to extension, closed to modification
 *  open so that existing source code can't be changed but extended to add new shit
 *  closed so that new requirements can be met without changing functionality of existing code
 *  example: shape class, where you can add another class that inherits shape and can calculate new shit
 *  
 *  Liskov substitution
 *  Parent class and child class can be logically used in the same way. Is A is important. like is a square a shape. inheritance has to 
 *      make sense n shit.
 *      
 *      
 *      Fixes:
 *      which player we're entering names for
 *      which player's turn is it
 * */
