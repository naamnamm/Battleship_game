using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Battleship_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            GameCanvas gameCanvas = new GameCanvas();

            Ship ship = new Ship();
            List<List<int>> shipCoordinates = ship.getShipCoordinates();

            InputValidation inputValidation = new InputValidation();

            do
            {
                //1. draw canvas
                gameCanvas.drawGameCanvas();

                Console.WriteLine("User turn remaining: {0}", player.Health);
                Console.WriteLine("Battleship lives remaining: {0}", ship.Lives);
                Console.WriteLine("Please enter your next move (i.e. a2 or f8):");

                bool isInputComplete = false;
                string userInput = string.Empty;
                while (!isInputComplete) 
                {
                    try
                    {
                        //2. check if user input is valid
                        userInput = inputValidation.validateInput(Console.ReadLine());

                        //2.1 check if user input is not repeated.
                        inputValidation.isUserInputRepeated(userInput);

                        isInputComplete = true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        Console.WriteLine(ex.Message);
                    }
                }

                //3. check if the ship has been hit 
                if (gameCanvas.checkForHit(userInput, shipCoordinates) == true)
                {
                    ship.Lives--;
                };
                
                player.Health--;

                var gameContinue = player.Health > 0 && ship.Lives > 0;
                if (gameContinue)
                {
                    Console.Clear();
                }

                // To create check for winner function.
                // Todo: need to mark X or O on the board game on round 10 as well.
                var userWin = ship.Lives == 0 && player.Health > 0;
                if (userWin) 
                {
                    Console.WriteLine("You win!!!");
                }

                var gameOver = player.Health == 0 && ship.Lives > 0;
                if (gameOver)
                {
                    Console.WriteLine("Game over!!!");
                }

            } while (player.Health > 0 && ship.Lives > 0);

        }
    }
}


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

// set ship coordinates
//gameCanvas.placingShipOnBoard(shipHead, direction, ship.Length);