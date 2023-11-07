using System;

// Base class for common activity behavior
public class BaseActivity
{
    protected int _duration;
    protected string _activityName;

    public virtual void StartActivity()
    {
        Console.Clear();
        Spinner();
        Console.Clear();
        Console.WriteLine($"Welcome to {_activityName} activity!");
        Console.WriteLine($"\nThis activity will help you focus and relax.");
        Console.Write("\nPlease enter the duration in seconds: ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nPrepare to begin...");
        Thread.Sleep(3000);
    }

    public virtual void EndActivity()
    {
        Console.WriteLine($"\nGreat job! You've completed the {_activityName} activity.");
        Console.WriteLine($"\nDuration: {_duration} seconds");
        Thread.Sleep(3000);
    }

    static void Spinner()
    {
        string[] spinnerChars = { "-", "\\", "|", "/" };
        int iterations = 2;

        for (int i = 0; i < iterations; i++)
        {
            foreach (var c in spinnerChars)
            {
                Console.Write(c + "\r");
                Thread.Sleep(500);
            }
        }

        Console.WriteLine(); // Move to the next line after the spinner
    }

    // Countdown method
    public void Countdown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000); // Wait for 1 second
            seconds--;
            Console.Write("\b \b");
        }
    }
}