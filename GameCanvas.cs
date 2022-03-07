using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Battleship_game
{
    public class GameCanvas
    {
        public const int gridSize = 10;
        const int tableWidth = 40;
        const int width = (tableWidth - gridSize) / gridSize;

        static void PrintFirstRow(params string[] columns)
        {
            string row = string.Empty;

            foreach (string column in columns)
            {
                row += column.PadLeft(width);
                //row += AlignCentre2(column, width);
            }

            Console.WriteLine(row);

        }

        private string[,] gridData = new string[,]
        {
            { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" }
        };

        public bool checkForHit(string gridPoints, List<List<int>> shipCoordinates)
        {
            int col = 0;
            
            int.TryParse(gridPoints.Substring(1), out int row);
            row = row - 1;

            switch (char.ToLower(gridPoints[0]))
            {
                case 'a':
                    col = 0;
                    break;

                case 'b':
                    col = 1;
                    break;

                case 'c':
                    col = 2;
                    break;

                case 'd':
                    col = 3;
                    break;

                case 'e':
                    col = 4;
                    break;

                case 'f':
                    col = 5;
                    break;

                case 'g':
                    col = 6;
                    break;

                case 'h':
                    col = 7;
                    break;

                case 'i':
                    col = 8;
                    break;

                case 'j':
                    col = 9;
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;
            }

            for (int i = 0; i < shipCoordinates.Count; i++)
            {
                if (shipCoordinates[i][0] == row && shipCoordinates[i][1] == col)
                {
                    gridData[row, col] = "O";
                    return true;
                }           
            }

            gridData[row, col] = "X";
            return false;
        }

        public void drawGameCanvas()
        {
         
            PrintLine();
            PrintFirstRow("", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J");

            for (int row = 0; row < gridData.GetLength(0); row++)
            {
                Console.Write($"{row+1}".PadLeft(width));

                for (int col = 0; col < gridData.GetLength(1); col++)
                {
                    string character = gridData[row, col].PadLeft(width);
                    Console.Write(character);
                 
                }
                Console.WriteLine();
            }


            PrintLine();
        }

        public void checkForWinner(int shipLives, int playerHealth)
        {
            var userWin = shipLives == 0 && playerHealth > 0;
            if (userWin)
            {
                drawGameCanvas();
                Console.WriteLine("You win!!!");
            }

            var gameOver = playerHealth == 0 && shipLives > 0;
            if (gameOver)
            {
                drawGameCanvas();
                Console.WriteLine("Game over!!!");
            }

            return;
        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
    }
}



