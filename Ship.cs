using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship_game
{
    class Ship
    {
        int _length = 5;

        public int Lives { get; set; }

        private readonly List<List<int>> _coordinates = new List<List<int>>();

        public Ship()
        {
            Lives = 5;
        }

        private List<int> getShipHead()
        {

            Random random = new Random();
            int row = random.Next(0, 9);
            int col = 0;

            // if row = 1-6, col can be 1-10 (need to -1)
            if (row >= 0 && row <= 5)
            {
                col = random.Next(0, 9);
            }

            // if row = 7-10, col can only be 1-6 (need to -1)
            if (row >= 6 && row <= 9)
            {
                col = random.Next(0, 5);
            }

            return new List<int> { row, col };

        }

        private int getShipDirection(List<int> shipHead)
        {
            int row = shipHead[0];
            int col = shipHead[1];
            
            // direction 1 = horizontal / direction 2 = vertical
            int direction = 1;

            if ((row >= 0 && row <= 5) && (col >= 0 && col <= 5)) 
            {
                Random random = new Random();
                direction = random.Next(1, 2);
            }

            if ((row >= 0 && row <= 5) && (col >= 6 && col <= 9))
            {
                direction = 2;
            }

            if ((row >= 6 && row <= 9) && (col >= 0 && col <= 5))
            {
                direction = 1;
            }

            return direction;
        }

        public List<List<int>> getShipCoordinates()
        {
            List<int> shipHead = getShipHead();
            int direction = getShipDirection(shipHead);

            int col = shipHead[1];
            int row = shipHead[0];

            if (direction == 1) // horizontal
            {
                for (int length = 0; length < _length; col++, length++)
                {
                    _coordinates.Add(new List<int> { row, col });
                }

                return _coordinates;
            }

            if (direction == 2) // vertical
            {
                for (int length = 0; length < _length; row++, length++)
                {
                    _coordinates.Add(new List<int> { row, col });
                }

                return _coordinates;
            }

            return _coordinates;
        }
    }
}

