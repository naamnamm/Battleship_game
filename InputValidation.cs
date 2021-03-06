using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Battleship_game
{
    public class InputValidation
    {

        List<string> userInputs = new List<string>();
    
        public string validateInput (string argTextInput)
        {
            string validatedInput;

            string pattern = "^[a-j]([1-9]|0[1-9]|10)$";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(argTextInput);

            if (!m.Success) throw new ArgumentException("please enter valid input");

            validatedInput = argTextInput;

            return validatedInput;

        }

        public void isUserInputRepeated(string userInput)
        {
            if (userInputs.Count() == 0)
            {
                userInputs.Add(userInput);
                return;
            }

            if (userInputs.Contains(userInput)) throw new ArgumentException("Repeated input, please enter your next move again");

            userInputs.Add(userInput);

        }
    }
}
