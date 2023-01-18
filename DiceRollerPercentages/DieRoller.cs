using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRollerPercentages
{
    class DieRoller
    {
        public void RollDie()
        {
            Console.WriteLine("What number do you want to roll?");
            string roll = Console.ReadLine();
            Console.WriteLine("I rolled a " + roll);
        }
    }
}
