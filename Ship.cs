using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship_game
{
    class Ship
    {
        public int[] getShipHead()
        {
            //random [row,col]

            //1. generate random row
            Random random = new Random();
            int row = random.Next(1, 10);
            int col = 0;

            // if row = 1-6, col can be 1-10
            if (row >= 1 && row <= 6)
            {
                col = random.Next(1, 10);
            }

            // if row = 7-10, col can only be 1-6
            if (row >= 7 && row <= 10)
            {
                col = random.Next(1, 6);
            }

            return new[] { row, col };

        }

        public int getShipDirection()
        {
            // shipHead[] = [row, col]
            int[] shipHead = getShipHead();
            int row = shipHead[0];
            int col = shipHead[1];
            
            // direction 1 = horizontal / direction 2 = vertical
            int direction = 1;

            // if row 1-6 && col 1-6 - direction can be 0 or 1
            if ((row >= 1 && row <= 6) && (col >= 1 && col <= 6)) 
            {
                Random random = new Random();
                direction = random.Next(1, 2);
            }

            // if row 1-6 && col 7-10 - direction needs to be vertical
            if ((row >= 1 && row <= 6) && (col >= 7 && col <= 10))
            {
                direction = 2;
            }

            // direction needs to be horizontal
            if ((row >= 7 && row <= 10) && (col >= 1 && col <= 6))
            {
                direction = 1;
            }

            return direction;
        }
    }
}
