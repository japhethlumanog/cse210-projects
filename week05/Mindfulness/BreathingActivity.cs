using System;
using System.Threading;
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", 
    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your")
    {
        
    }
    
    public void Run()
    {
        StartActivity();

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in... ");
            int step = Math.Min(4, _duration - elapsedTime);
            ShowCountdown(step);
            elapsedTime += step;

            if (elapsedTime >= _duration)
            {
                continue;
            }

            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            step = Math.Min(4, _duration - elapsedTime);
            ShowCountdown(step);
            elapsedTime += step;
        }
        EndActivity();
    }
}