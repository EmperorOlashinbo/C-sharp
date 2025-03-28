namespace Assignment2;

/// <summary>
/// GuessNumberGame class implements a number guessing game with difficulty levels.
/// </summary>
public class GuessNumberGame
{
    private int numberToGuess;
    private int maxAttempts;
    private int maxRange;

    /// <summary>
    /// Reads user input and selects the difficulty level.
    /// Sets the max range and max attempts based on user selection.
    /// </summary>
    private void ReadDifficultyLevel()
    {
        while (true)
        {
            Console.WriteLine("\nSelect Difficulty Level:");
            Console.WriteLine("1 - Easy (1-10, Unlimited attempts)");
            Console.WriteLine("2 - Medium (1-50, 10 attempts)");
            Console.WriteLine("3 - Hard (1-100, 5 attempts)");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();
            if (choice == "1") { maxRange = 10; maxAttempts = int.MaxValue; break; }
            if (choice == "2") { maxRange = 50; maxAttempts = 10; break; }
            if (choice == "3") { maxRange = 100; maxAttempts = 5; break; }

            Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
        }
    }

    /// <summary>
    /// Runs the number guessing game logic.
    /// Generates a random number and prompts the user to guess it within the allowed attempts.
    /// Provides feedback on each guess.
    /// </summary>
    private void PlayGame()
    {
        Random random = new Random();
        numberToGuess = random.Next(1, maxRange + 1);
        int attempts = 0;

        Console.WriteLine($"\nGuess the number between 1 and {maxRange}!");
        while (attempts < maxAttempts)
        {
            Console.Write("Enter your guess: ");
            if (!int.TryParse(Console.ReadLine(), out int userGuess) || userGuess < 1 || userGuess > maxRange)
            {
                Console.WriteLine($"Please enter a valid number between 1 and {maxRange}.");
                continue;
            }

            attempts++;

            if (userGuess == numberToGuess)
            {
                Console.WriteLine($"\nCongratulations! You guessed the number in {attempts} attempts!");
                return;
            }
            else if (userGuess < numberToGuess)
                Console.WriteLine("Too low! Try again.");
            else
                Console.WriteLine("Too high! Try again.");
        }

        Console.WriteLine($"\nGame over! The correct number was {numberToGuess}.");
    }

    /// <summary>
    /// Starts the game and allows the user to replay.
    /// Calls methods to read difficulty and play the game.
    /// </summary>
    public void Start()
    {
        do
        {
            ReadDifficultyLevel();
            PlayGame();
            Console.Write("\nWould you like to play again? (yes/no): ");
        }
        while (Console.ReadLine().Trim().ToLower() == "yes");
    }
}
