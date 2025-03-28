namespace Assignment2;

/// <summary>
/// Entry point for the Assignment2 program. Displays the main menu and navigates to selected features.
/// </summary>
class Program
{
    /// <summary>
    /// Main method that runs the program and displays the main menu.
    /// </summary>
    /// <param name="args">Command-line arguments</param>
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Temperature Converter");
            Console.WriteLine("2. String Functions");
            Console.WriteLine("3. Guess the Number Game");
            Console.WriteLine("4. Cost Calculator");
            Console.WriteLine("5. Work Scheduler");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            if (choice == "6") break;

            if (choice == "1")
            {
                // Run Temperature Converter
                TemperatureConverter tempConverter = new TemperatureConverter();
                tempConverter.Start();
            }
            else if (choice == "2")
            {
                // Run String Functions
                StringFunctions stringFunctions = new StringFunctions();
                stringFunctions.Start();
            }
            else if (choice == "3")
            {
                // Run Guess the Number Game asynchronously
                Task.Run(() =>
                {
                    GuessNumberGame game = new GuessNumberGame();
                    game.Start();
                }).Wait();
            }
            else if (choice == "4")
            {
                // Run Cost Calculator
                CostCalculator calculator = new CostCalculator();
                calculator.Start();
            }
            else if (choice == "5")
            {
                // Run Work Scheduler
                Scheduler scheduler = new Scheduler();
                scheduler.Start();
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid choice. Please enter 1, 2, 3, 4, 5, or 6.");
            }
        }
    }
}
