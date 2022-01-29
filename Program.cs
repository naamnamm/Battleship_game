using System;

namespace Battleship_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int userTurn = 10;
            int battleShip_lives = 5;
     
            //while guess is more than 0 and game is not over
            while (userTurn > 0 && battleShip_lives > 0)
            {
                //execute this
                GameCanvas gameCanvas = new GameCanvas();
                gameCanvas.createBattleshipGameCanvas();

                Console.WriteLine("User turn remaining: {0}", userTurn);
                Console.WriteLine("Battleship lives remaining: {0}", battleShip_lives);
                Console.WriteLine("Please enter your next move:");

                //Todo: randomly place the ship


                bool inputComplete = false;
                while (!inputComplete) //while this is true
                {
                    try
                    {
                        //get user input && determine if the input is valid
                        InputConverter inputConverter = new InputConverter();
                        int num1 = inputConverter.convertInput(Console.ReadLine());
                        inputComplete = true;

                        //user input --1
                        userTurn--;

                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        Console.WriteLine(ex.Message);
                    }
                }

                //Todo: determine if the ship has been hit.

                
            }

        }




    }
}
