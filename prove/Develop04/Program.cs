using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            BaseActivity activity;

            if (choice == 1)
            {
                activity = new BreathingActivity();
                activity.StartActivity();
            }
            else if (choice == 2)
            {
                activity = new ReflectionActivity();
                activity.StartActivity();
            }
            else if (choice == 3)
            {
                activity = new ListingActivity();
                activity.StartActivity();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        } while (choice != 4);
    }
}