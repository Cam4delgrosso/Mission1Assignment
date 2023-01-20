using System;

namespace Mission1Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!"); 
            Console.WriteLine("How many dice would you like to simulate?");
            double throws = Convert.ToDouble(Console.ReadLine()); //Get the number of rolls from the user
            Random r = new Random();

            int[] rolls = new int[11]; //Declare the array that will hold the rolls
            for (int i=0; i < 11; i++) //For loop to initialize the array
            {
                rolls[i] = 0;
            }

            for (int i = 0; i < throws; i++) //Loop for as many rolls
            {
                int roll1 = r.Next(0, 6);
                int roll2 = r.Next(0, 6);
                int rollTotal = roll1 + roll2; //Add the 2 dice rolls together to get the total number
                rolls[rollTotal] = rolls[rollTotal] + 1; //Increment the count of the total number rolled
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each * represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + int.Parse(throws.ToString()));

            for (int i = 0; i < 11; i++) // Loop through each total roll count
            {
                string astrix = "";
                double percent = 0;
                percent = (rolls[i]) / throws * 100; //Calculate the percentage rolled for each number
                percent = (int)Math.Round(percent);
                
                for (int j = 0; j < percent; j++) //Make a string to print the number of astrisks for each number
                {
                    astrix += "*";
                }
                Console.WriteLine(string.Concat((i + 2).ToString(), ":", astrix)); //Print final results
            }
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
