using System;

// Listing Activity
public class ListingActivity : BaseActivity
{
    private string[] _listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _activityName = "Listing";
    }

    public override void StartActivity()
    {
        base.StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        Console.WriteLine("This activity will help you reflect on the good things in your life.");
        Thread.Sleep(3000);

        Random rand = new Random();

        while (DateTime.Now < endTime)
        {
            string prompt = _listingPrompts[rand.Next(_listingPrompts.Length)];
            Console.WriteLine(prompt);
            Console.WriteLine();
            Countdown(3);

            Console.WriteLine("Start listing your items...");

            int itemCount = 0;
            while (DateTime.Now < endTime) // Loop for listing items within the duration
            {
                string input = Console.ReadLine(); // Take user input for an item
                if (!string.IsNullOrEmpty(input)) // Check if input is not empty
                {
                    itemCount++;
                }
                else
                {
                    Console.WriteLine("Item added. Press enter to add more items or wait for the activity to end.");
                    break;
                }
            }

            Console.WriteLine("Number of items listed: " + itemCount);
            if (DateTime.Now >= endTime) // Check if it's time to exit the main activity loop
                break;
        }

        EndActivity();
    }
}
