namespace Assignment2;

/// <summary>
/// CostCalculator class calculates the total cost of purchasing products
/// with discounts applied based on quantity ordered.
/// </summary>
public class CostCalculator
{
    private double pricePerUnit;
    private int quantity;
    private double totalCost;

    /// <summary>
    /// Reads and validates user input for price and quantity.
    /// Ensures that the entered values are positive numbers.
    /// </summary>
    public void ReadInput()
    {
        while (true)
        {
            Console.Write("Enter the price per unit: ");
            if (double.TryParse(Console.ReadLine(), out pricePerUnit) && pricePerUnit > 0)
                break;
            Console.WriteLine("Invalid input. Price must be a positive number.");
        }

        while (true)
        {
            Console.Write("Enter the number of units purchased: ");
            if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                break;
            Console.WriteLine("Invalid input. Quantity must be a positive integer.");
        }
    }

    /// <summary>
    /// Calculates the total cost after applying discounts based on quantity.
    /// Applies discount tiers: 10% for 10-19 units, 20% for 20-49 units, etc.
    /// </summary>
    public void CalculateTotalCost()
    {
        double discount = 0;

        if (quantity >= 100)
            discount = 0.50;
        else if (quantity >= 50)
            discount = 0.40;
        else if (quantity >= 20)
            discount = 0.30;
        else if (quantity >= 10)
            discount = 0.20;

        double originalTotal = pricePerUnit * quantity;
        totalCost = originalTotal * (1 - discount);

        Console.WriteLine($"\nOriginal Total: {originalTotal:C}");
        Console.WriteLine($"Discount Applied: {discount * 100}%");
        Console.WriteLine($"Final Total Cost: {totalCost:C}");
    }

    /// <summary>
    /// Starts the cost calculation process and allows repetition.
    /// Continues until the user chooses to exit.
    /// </summary>
    public void Start()
    {
        do
        {
            ReadInput();
            CalculateTotalCost();
            Console.Write("\nWould you like to perform another calculation? (yes/no): ");
        }
        while (Console.ReadLine().Trim().ToLower() == "yes");
    }
}
