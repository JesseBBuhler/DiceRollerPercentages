using System;

namespace DiceRollerPercentages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numRolls = 0;
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            if (int.TryParse(Console.ReadLine(), out numRolls)) //checking to see if the user submitted an integer
            {
                Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
                Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
                Console.WriteLine("Total number of rolls = " + numRolls);
                DieRoller DR = new DieRoller(); // Creating DieRoller
                DR.rollDice(numRolls); // Rolling Dice
                DR.histogram(); // Creating Histogram based on the dice that have been rolled.
                Console.WriteLine("Thank you for using the dice throwing simulator.  Goodbye!");
            }
            else
            {
                Console.WriteLine("Input was invalid. Please restart program."); //Letting the user know their input was invalid
            }
        }

    }
}
