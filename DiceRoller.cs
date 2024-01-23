using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
 class DiceRoller
    {
        public int[] SimulateRolls(int numRolls)
        {
            int die1 = 0;
            int die2 = 0;
            int total = 0;

            //array to store count of each possible dice roll
            int[] rollTotals = new int[13];

            // instance of the Random class
            Random random = new Random();

            // simulate dice rolls for specified number of times
            for (int i = 1; i <= numRolls; i++)
            {
                // generate random numbers for two dice and calulate roll total
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                total = die1 + die2;

                // increment the count for the corresponding roll total
                rollTotals[total]++;
            }

            return rollTotals;
        }
    }
}
