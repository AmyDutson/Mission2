using Mission2;

class DiceSimulator
{
    public static void Main()
    {
        int numRolls = 0;

        //ask user how many dice rolls and read user input
        System.Console.WriteLine("Welcome to the dice throwing simulator! \n");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        numRolls = int.Parse(System.Console.ReadLine());

        //create an instance of the DiceRoller class
        DiceRoller diceRoller = new DiceRoller(); 

        //simulate dice rolls and get the results
        int[] results = diceRoller.SimulateRolls(numRolls);

        //display histogram of results
        DisplayHistogram(results, numRolls);

        Console.WriteLine("Thank you for using the dice simulator. Goodbye!");
    }

    public static void DisplayHistogram(int[] results, int numRolls)
    {
        int percentage = 0;
        string asterisks = "";

        // display header information
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine($"Total number of rolls = {numRolls}.\n");

        // iterate through possible dice rolls
        for (int i = 2; i <= 12; i++)
        {
            //calculate percentage
            percentage = (int)((results[i] / (float)numRolls) * 100);

            // create a string of asterisks based on percentage and display
            asterisks = new string('*', percentage);
            Console.WriteLine($"{i}: {asterisks}");
        }
    }

}

