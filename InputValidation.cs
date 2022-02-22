using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Battleship_game
{
    public class InputValidation
    {
        public string validateInput (string argTextInput)
        {
            string validatedInput;

            //check to see if input is valid
            string pattern = "^[a-j]([1-9]|0[1-9]|10)$";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(argTextInput);

            //if not, throw error
            if (!m.Success) throw new ArgumentException("please enter valid input");

            validatedInput = argTextInput;

            return validatedInput;

        }
    }
}
