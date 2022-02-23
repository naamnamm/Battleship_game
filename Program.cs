using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Battleship_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            int battleShip_lives = 5;

            //while user health is more than 0 and game is not over
            do
            {
                //1. draw canvas
                GameCanvas gameCanvas = new GameCanvas();
                gameCanvas.drawGameCanvas();

                Console.WriteLine("User turn remaining: {0}", player.Health);
                Console.WriteLine("Battleship lives remaining: {0}", battleShip_lives);
                Console.WriteLine("Please enter your next move (i.e. a2 or f8):");

                //2. randomly place the ship
                gameCanvas.placingShipOnBoard();

                //3. determine if user input is valid
                InputValidation inputConverter = new InputValidation();
                string userInput = inputConverter.validateInput(Console.ReadLine());
                gameCanvas.checkForHit(userInput);
                player.Health--;

                //bool isInputComplete = false;
                //while (!isInputComplete) //while this is true
                //{
                //    try
                //    {
                //        //get user input && determine if the input is valid
                //        InputValidation inputConverter = new InputValidation();
                //        string userInput = inputConverter.validateInput(Console.ReadLine());

                //        isInputComplete = true;

                //        // call the checkHit fn
                //        gameCanvas.checkForHit(userInput);
                //        // call the render grid fn



                //        //user input --1
                //        player.Health--;

                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine(ex);
                //        Console.WriteLine(ex.Message);
                //    }
                //}

                Console.Clear();

                //4. determine if the ship has been hit 

            } while (player.Health > 0 && battleShip_lives > 0);

        }

        private static bool isUserInputValid(string argTextInput)
        {
            
            //check to see if input is valid
            string pattern = "^[a-j]([1-9]|0[1-9]|10)$";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(argTextInput);

            //if not, throw error
            if (!m.Success) throw new ArgumentException("please enter valid input");

            return true;
        }
    }
}
