using System;

class Program
{
    static void Main(string[] args)
    {
        int menuSelection = 0;

        do
        {
            Console.WriteLine("Please select from the following menu:");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load Saved File");
            Console.WriteLine("4. Save File");
            Console.WriteLine("5. Quit");

            menuSelection = Console.ReadLine();

            // Write a New Entry
            if (menuSelection == 1)
            {
                AddEntry();
            }
            // Display Entries
            else if (menuSelection == 2)
            {
                DisplayAll();
            }
            // Load Saved File
            else if (menuSelection == 3)
            {
                Console.WriteLine("I have not yet completed this.");
            }
            // Save File
            else if (menuSelection == 4)
            {
                SaveToFile();
            }
            // Quit
            else if (menuSelection == 5)
            {
                Console.WriteLine("Thank you, goodbye. ");
            }
            // Invalid answer
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand that. ");
            }

        } while (menuSelection != 5);
    }
}