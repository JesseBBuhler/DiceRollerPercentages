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
            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = rnd.Next(6) + 1;
                int roll2 = rnd.Next(6) + 1;
                int total = roll1 + roll2;
                rollLog[total - 2] = rollLog[total - 2] + 1;
            }


        }

        public void histogram()
        {
            for (int i = 0; i < 11; i++)
            {
                string starString = "";
                int percentage = (rollLog[i] * 100)/ numRolls;
                for (int j = 0; j < percentage; j++)
                {
                    starString = starString + "*";
                }
                Console.WriteLine((i + 2) + ": " + starString);
            }
        }
    }
}
