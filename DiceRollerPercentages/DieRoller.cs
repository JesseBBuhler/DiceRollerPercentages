using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRollerPercentages
{
    class DieRoller
    {
        private int[] rollLog = new int[11];
        private int numRolls = 0;

        public void rollDice(int inNumRolls)
        {
            numRolls = inNumRolls;
            Random rnd = new Random();
            for (int i = 0; i < numRolls; i++) //rolling however many sets of dice the user selected
            {
                int roll1 = rnd.Next(6) + 1; // Rolling 6 sided die.  +1 shifts from base 0 to (1-6)
                int roll2 = rnd.Next(6) + 1; // ^ditto
                int total = roll1 + roll2;
                rollLog[total - 2] = rollLog[total - 2] + 1; //total - 2 shifts the die rolls (2-12) down to fit in the base 0 array (0-10)
            }


        }

        public void histogram()
        {
            for (int i = 0; i < 11; i++)
            {
                string starString = "";
                int percentage = (rollLog[i] * 100)/ numRolls; // Calculating percentage rolled for each possible result
                for (int j = 0; j < percentage; j++)
                {
                    starString = starString + "*"; //appending *s to the string for each percentage point of each result
                }
                Console.WriteLine((i + 2) + ":\t" + starString); // i + 2 converts from base 0 array back to (2-12) dice rolls.
            }
        }
    }
}
