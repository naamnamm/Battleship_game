using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Battleship_game
{
    public class GameCanvas
    {
        const int gridSize = 10;
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

        public void checkForHit(string gridPoints)
        {

            // convert gridpoints to indices (row, column)
            int row = 0;
            
            int.TryParse(gridPoints.Substring(1), out int col);

            // switch case a, b, c
            switch (gridPoints[0])
            {
                // if case a: row = 0, col = number followed
                case 'a':
                    row = 0;
                    // grid point [row,col] = "X";
                    Console.WriteLine('a');
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;
            }

            gridData[row, col] = "X";

            drawGameCanvas();
        }

        public void placingShipOnBoard()
        {
            Ship randomShip = new Ship();

            int[] shipHead = randomShip.getShipHead();
            int direction = randomShip.getShipDirection();

            // direction 1 = horizontal / direction 2 = vertical
            if (direction == 1)
            {
                // display boat on the board
            }

            if (direction == 2)
            {
                // display boat on the board
            }

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


        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
    }
}

//https://stackoverflow.com/questions/314466/generating-an-array-of-letters-in-the-alphabet/5271891

//public string[,] gridData { get; set; } = {
//    { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
//    { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
//    { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
//    { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
//    { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
//    { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
//    { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
//    { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
//    { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
//    { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" }
//};
