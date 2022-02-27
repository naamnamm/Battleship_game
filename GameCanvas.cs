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

        public void checkForHit(string gridPoints, List<List<int>> shipCoordinates)
        {

            // convert gridpoints to indices (row, column)
            int col = 0;
            
            int.TryParse(gridPoints.Substring(1), out int row);

            // switch case a, b, c
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

            //loop through ship coordinate to see if it is match.

            //if hit, display "O".


            //otherwise, display "X"
            gridData[row-1, col] = "X";
        }

        //public void placingShipOnBoard(int[] shipHead, int direction, int shipLength)
        //{

        //    // direction 1 = horizontal
        //    if (direction == 1)
        //    {
        //        // display boat on the board
        //        for (int row = 0; row < gridData.GetLength(0); row++)
        //        {
        //            // when roll = 7, this met if condition. need to -1 because it starts from index 0
        //            if (row == shipHead[0]-1)
        //            {
        //                for (int col = 0; col < gridData.GetLength(1); col++)
        //                {
        //                    //when col = 4
        //                    if (col == shipHead[1]-1)
        //                    {
        //                        //loop through 5 times with col++ 
        //                        for (int length = 0; length < shipLength; col++,length++)
        //                        {
        //                            gridData[row, col] = "B";
        //                        }
        //                        return;
        //                    }
        //                }
        //            }               
        //        }
        //    }

        //    //direction 2 = vertical
        //    if (direction == 2)
        //    {
        //        for (int row = 0; row < gridData.GetLength(0); row++)
        //        {
        //            // when roll = 4, this met if condition. need to -1 because it starts from index 0
        //            if (row == shipHead[0] - 1)
        //            {
        //                for (int length = 0; length < shipLength; row++, length++)
        //                {
        //                    int col = shipHead[1] - 1;
        //                    gridData[row, col] = "B";
        //                }
        //                return;
                        
        //            }
        //        }
        //    }

        //}

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
