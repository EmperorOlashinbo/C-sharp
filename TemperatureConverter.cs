namespace Assignment2;

/// <summary>
/// TemperatureConverter class provides functions to convert between Fahrenheit and Celsius.
/// </summary>
public class TemperatureConverter
{
    /// <summary>
    /// Starts the temperature conversion menu.
    /// Allows the user to choose between converting Fahrenheit to Celsius or Celsius to Fahrenheit.
    /// Loops until the user chooses to exit.
    /// </summary>
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n--- Temperature Converter ---");
            Console.WriteLine("1. Convert Fahrenheit to Celsius");
            Console.WriteLine("2. Convert Celsius to Fahrenheit");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            if (choice == "3") break;

            Console.Write("Enter temperature value: ");
            if (!double.TryParse(Console.ReadLine(), out double inputTemp))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            double convertedTemp = (choice == "1") ? ConvertFahrenheitToCelsius(inputTemp) : ConvertCelsiusToFahrenheit(inputTemp);
            string fromUnit = (choice == "1") ? "F" : "C";
            string toUnit = (choice == "1") ? "C" : "F";

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("| Input Temp | Converted Temp |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"| {inputTemp,10:F2} {fromUnit} | {convertedTemp,13:F2} {toUnit} |");
            Console.WriteLine("--------------------------------");
        }
    }

    /// <summary>
    /// Converts Fahrenheit to Celsius using the formula: C = (5/9) * (F - 32).
    /// </summary>
    /// <param name="f">Temperature in Fahrenheit</param>
    /// <returns>Converted temperature in Celsius</returns>
    private double ConvertFahrenheitToCelsius(double f) => (5.0 / 9.0) * (f - 32);

    /// <summary>
    /// Converts Celsius to Fahrenheit using the formula: F = (9/5) * C + 32.
    /// </summary>
    /// <param name="c">Temperature in Celsius</param>
    /// <returns>Converted temperature in Fahrenheit</returns>
    private double ConvertCelsiusToFahrenheit(double c) => (9.0 / 5.0) * c + 32;
}
