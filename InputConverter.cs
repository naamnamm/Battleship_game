using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship_game
{
    public class InputConverter
    {
        public int convertInput (string argTextInput)
        {
            int convertedNumber;

            bool isNumConvertedSuccessfully = int.TryParse(argTextInput, out convertedNumber);

            if (!isNumConvertedSuccessfully) throw new ArgumentException("please enter valid number");

            return convertedNumber;

        }
    }
}
