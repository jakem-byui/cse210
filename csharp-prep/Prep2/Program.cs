using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks user for number grade
        Console.Write("Please input your grade percentage (ex. 79): ");
        string numGradeText = Console.ReadLine();

        // Converts string to int for grade letter calculation
        int numGrade = int.Parse(numGradeText);
        string letterGrade = "";

        if  (numGrade >= 90) 
        {
            letterGrade = "A";
        }
        else if (numGrade >= 80) 
        {
            letterGrade = "B";
        }
        else if (numGrade >= 70) 
        {
            letterGrade = "C";
        }
        else if (numGrade >= 60) 
        {
            letterGrade = "D";
        }
        else if (numGrade < 60) 
        {
            letterGrade = "F";
        }
        else
        {
            Console.WriteLine("Invalid entry. Try again with '00' format.");
        }

        Console.WriteLine ($"Your grade is {letterGrade}.");
        
        if (numGrade >= 70)
        {
            Console.WriteLine ("Congratulations! You passed!");
        }
        else if (numGrade <= 69)
        {
            Console.WriteLine ("Sorry! Looks like you didn't pass. Try again!");
        }
    }
}