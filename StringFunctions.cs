namespace Assignment2;

/// <summary>
/// StringFunctions class provides various string operations.
/// </summary>
public class StringFunctions
{
    /// <summary>
    /// Runs the string manipulation functions.
    /// Loops to allow multiple string operations until the user decides to exit.
    /// </summary>
    public void Start()
    {
        do
        {
            StringLength();
            PredictMyDay();
            Console.Write("\nWould you like to try another string operation? (yes/no): ");
        }
        while (Console.ReadLine().Trim().ToLower() == "yes");
    }

    /// <summary>
    /// Prompts the user to enter a string and displays its length and uppercase version.
    /// </summary>
    private void StringLength()
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();
        Console.WriteLine($"\nString Length: {userInput.Length}");
        Console.WriteLine($"Uppercase Version: {userInput.ToUpper()}");
    }

    /// <summary>
    /// Asks the user for a number (1-7) and displays a message predicting their day.
    /// Uses a switch expression to map numbers to day predictions.
    /// </summary>
    private void PredictMyDay()
    {
        Console.Write("Enter a number (1-7) to predict your day: ");
        if (!int.TryParse(Console.ReadLine(), out int day) || day < 1 || day > 7)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            return;
        }

        string message = day switch
        {
            1 => "Monday: The hardest part is getting started! ☕",
            2 => "Tuesday: You're getting into the groove! 🎵",
            3 => "Wednesday: Halfway there! Keep pushing! 🏋️",
            4 => "Thursday: Almost Friday! Stay strong! 💪",
            5 => "Friday: The weekend is calling! 🎉",
            6 => "Saturday: Relax and enjoy! 🌞",
            7 => "Sunday: Time to recharge for the new week! 🔋",
            _ => "Oops! Something went wrong."
        };

        Console.WriteLine($"\n{message}");
    }
}
