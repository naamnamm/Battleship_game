using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship_game
{
    class Ship
    {
        public int Length { get; }
        public int Lives { get; set; }

        private readonly List<List<int>> _coordinates = new List<List<int>>();

        public List<List<int>> Coordinates { get => _coordinates; }

        public Ship()
        {
            Length = 5;
            Lives = 5;
        }

        private List<int> getShipHead()
        {
            //random [row,col]

            //1. generate random row
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

        private int getShipDirection()
        {
            // shipHead[] = [row, col]
            List<int> shipHead = getShipHead();
            int row = shipHead[0];
            int col = shipHead[1];
            
            // direction 1 = horizontal / direction 2 = vertical
            int direction = 1;

            // if row 1-6 && col 1-6 - direction can be 0 or 1 (need to -1)
            if ((row >= 0 && row <= 5) && (col >= 0 && col <= 5)) 
            {
                Random random = new Random();
                direction = random.Next(1, 2);
            }

            // if row 1-6 && col 7-10 - direction needs to be vertical (need to -1)
            if ((row >= 0 && row <= 5) && (col >= 6 && col <= 9))
            {
                direction = 2;
            }

            // direction needs to be horizontal (need to -1)
            if ((row >= 6 && row <= 9) && (col >= 0 && col <= 5))
            {
                direction = 1;
            }

            return direction;
        }

        public List<List<int>> getShipCoordinates()
        {
            List<int> shipHead = getShipHead();
            int direction = getShipDirection();

            int col = shipHead[1];
            int row = shipHead[0];

            if (direction == 1) // horizontal
            {
                for (int length = 0; length < Length; col++, length++)
                {
                    _coordinates.Add(new List<int> { row, col });               
                }

                return _coordinates;
            }

            if (direction == 2) // vertical
            {
                for (int length = 0; length < Length; row++, length++)
                {
                    _coordinates.Add(new List<int> { row, col });
                }

                return _coordinates;
            }

            return _coordinates;
        }
    }
}

//for (int row = 0; row < gridSize; row++)
//{
//    var list = new List<int>();
//    // create new list
//    _coordinates.Add(new List<int> { 1, 2, 3 });
//    // need to -1 because it starts from index 0
//    if (row == shipHead[0] - 1)
//    {
//        for (int col = 0; col < gridSize; col++)
//        {
//            if (col == shipHead[1] - 1)
//            {
//                // ship length = 5
//                // once I have the ship Head, loop 4 times to get 4 coordinates of the ship, then push it to the List
//                for (int length = 0; length < Length-1; col++, length++)
//                {
//                    int[] arr = { row, col };
//                    list.Add(row);

//                    // this isn't working as expected 
//                    Coordinates.AddRange(arr); 

//                    // expect this
//                    //{
//                    //    { 1,2 },
//                    //    { 1,3 },
//                    //    { 1,4 },
//                    //    { 1,5 },
//                    //    { 1,6 },
//                    //}

//                    // but it turn out to be
//                    // {1,2,1,3}





//                    //gridData[row, col] = "B";
//                }

//                //Coordinates = coordinates;
//                return Coordinates;
//            }
//        }
//    }
//}

//direction 2 = vertical
//if (direction == 2)
//{
//    for (int row = 0; row < gridData.GetLength(0); row++)
//    {
//        // when roll = 4, this met if condition. need to -1 because it starts from index 0
//        if (row == shipHead[0] - 1)
//        {
//            for (int length = 0; length < shipLength; row++, length++)
//            {
//                int col = shipHead[1] - 1;
//                gridData[row, col] = "B";
//            }
//            return;

//        }
//    }
//}