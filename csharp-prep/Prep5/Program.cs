using System;

class Program
{
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program! ");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your username: ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            
            return squaredNumber;
        }

        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(userName, squaredNumber);
        
    }
}