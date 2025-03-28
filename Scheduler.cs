namespace Assignment2;
using System;

/// <summary>
/// Scheduler class manages and displays work schedules for weekend and night shifts.
/// </summary>
public class Scheduler
{
    private const int TOTAL_WEEKS = 52; // Total number of weeks in a year

    /// <summary>
    /// Generates and displays a schedule based on the start week, interval, and shift type.
    /// </summary>
    /// <param name="startWeek">Starting week of the schedule.</param>
    /// <param name="interval">Interval between shifts.</param>
    /// <param name="shiftType">Type of shift (e.g., Weekend or Night Shift).</param>
    public void GenerateSchedule(int startWeek, int interval, string shiftType)
    {
        Console.WriteLine($"\n{shiftType} Schedule:");
        for (int week = startWeek; week <= TOTAL_WEEKS; week += interval)
        {
            Console.WriteLine($"Week {week}");
        }
    }

    /// <summary>
    /// Displays the scheduling menu and handles user input.
    /// Allows the user to view schedules for weekend or night shifts.
    /// Loops until the user chooses to exit.
    /// </summary>
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n--- Work Schedule Menu ---");
            Console.WriteLine("1. View Weekend Shifts");
            Console.WriteLine("2. View Night Shifts");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            if (choice == "3") break;

            switch (choice)
            {
                case "1":
                    GenerateSchedule(1, 2, "Weekend"); // Every 2nd week starting from week 1
                    break;
                case "2":
                    GenerateSchedule(2, 4, "Night Shift"); // Every 4th week starting from week 2
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    break;
            }
        }
    }
}
