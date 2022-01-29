using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship_game
{
    public class GameCanvas
    {
        const int x_GridSize = 10;
        const int y_GridSize = 10;
        const int tableWidth2= 40;
        const int width = (tableWidth2 - x_GridSize) / x_GridSize;

        static void PrintRow(params string[] columns)
        {
            string row = string.Empty;

            foreach (string column in columns)
            {
                row += AlignCentre2(column, width);
            }

            Console.WriteLine(row);
        }

        public void createBattleshipGameCanvas()
        {
            PrintLine();
            PrintRow("", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10");

            for (int y = 0; y < y_GridSize; y++)
            {
                Console.Write($"{ y + 1}".PadLeft(width));

                for (int x = 0; x < x_GridSize; x++)
                {
                    string row = AlignCentre2("-", width);
                    Console.Write(row);                  
                }
                Console.WriteLine();
            }
            PrintLine();
        }

        private static string AlignCentre2(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth2));
        }
    }
}
