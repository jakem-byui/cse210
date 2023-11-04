using System;

// Breathing Activity
public class BreathingActivity : BaseActivity
{
    public BreathingActivity()
    {
        _activityName = "Breathing";
    }

    public override void StartActivity()
    {
        base.StartActivity();
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("This activity will guide you through breathing exercises.");
        Console.WriteLine("Clear your mind and focus on your breath.");
        
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            Countdown(6); // Countdown for 6 seconds
            Console.Write("\nBreathe out... ");
            Countdown(4); // Countdown for 4 seconds
            Console.WriteLine();
        }

        EndActivity();
    }
}
