using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. One-dimensional string array
        // Create an array of strings
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date" };

        // Ask the user to choose an index
        Console.WriteLine("Select an index (0–3) for the string array:");
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index exists
        if (stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            // Display the string at the chosen index
            Console.WriteLine("You selected: " + stringArray[stringIndex]);
        }
        else
        {
            // Message for an index that doesn’t exist
            Console.WriteLine("That index does not exist in the string array.");
        }

        // 2. One-dimensional integer array
        // Create an array of integers
        int[] intArray = { 10, 20, 30, 40, 50 };

        // Ask the user to choose an index
        Console.WriteLine("\nSelect an index (0–4) for the integer array:");
        int intIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index exists
        if (intIndex >= 0 && intIndex < intArray.Length)
        {
            // Display the integer at the chosen index
            Console.WriteLine("You selected: " + intArray[intIndex]);
        }
        else
        {
            // Message for an index that doesn’t exist
            Console.WriteLine("That index does not exist in the integer array.");
        }

        // 3. List of strings
        // Create a list of strings
        List<string> stringList = new List<string>()
        {
            "Red",
            "Blue",
            "Green",
            "Yellow"
        };

        // Ask the user to choose an index
        Console.WriteLine("\nSelect an index (0–3) for the string list:");
        int listIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index exists
        if (listIndex >= 0 && listIndex < stringList.Count)
        {
            // Display the string at the chosen index in the list
            Console.WriteLine("You selected: " + stringList[listIndex]);
        }
        else
        {
            // Message for an index that doesn’t exist
            Console.WriteLine("That index does not exist in the string list.");
        }

        // Pause so the console window stays open
        Console.WriteLine("\nPress Enter to exit.");
        Console.ReadLine();
    }
}
