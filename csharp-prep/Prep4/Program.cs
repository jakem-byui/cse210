using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment
        //Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        //Once you have a list, have your program do the following:

        // Core Requirements
        //Work through these core requirements step-by-step to complete the program. Please don't skip 
        // ahead and do the whole thing at once, because others on your team may benefit from building 
        // the program up slowly.
        // 1. Compute the sum, or total, of the numbers in the list.
        // 2. Compute the average of the numbers in the list.
        // 3. Find the maximum, or largest, number in the list.
        
        List<int> listNumbers = new List<int>();
        
        int userNumber = 100;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            Console.Write("Enter number ('0' ends session): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                listNumbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in listNumbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / listNumbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = listNumbers[0];

        foreach (int number in listNumbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}