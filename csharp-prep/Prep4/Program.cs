using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Please enter the number you would like to add to the list. Enter 0 to finish. ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }


        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");


        // Compute the average
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");


        // Find the maximum
        int maximum = 0;
        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The maximum is: {maximum}");
    }
}