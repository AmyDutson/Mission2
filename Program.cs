class DiceSimulator
{
    public static void Main()
    {
        //declare variables
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
        //declare variables
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

class DiceRoller
{
    public int[] SimulateRolls(int numRolls)
    {
        // declare variables
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

        //return array of the results
        return rollTotals; 
    }
}