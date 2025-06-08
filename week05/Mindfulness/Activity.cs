using System;
using System.Threading;

public abstract class Activity
{
    // Protected so derived classes can access them directly if needed
    protected string _activityName;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    // Set duration with user input
    public void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            Console.Write("Enter the duration of the activity in seconds: ");
        }
    }

    // Show the starting message
    public virtual void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_activityName} ---");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("Get ready to begin...");
        PauseWithAnimation(3);
    }

    // Show the ending message
    public virtual void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        PauseWithAnimation(3);
        Console.WriteLine($"You have completed the {_activityName} for {_duration} seconds.");
        PauseWithAnimation(3);
    }

    // Pause with spinner animation
    protected void PauseWithAnimation(int seconds)
    {
        string spinner = "|/-\\";
        for (int i = 0; i < seconds * 10; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(100);
        }
        Console.WriteLine();
    }

    // Abstract method: each activity must implement its own Run method
    public abstract void Run();
}
