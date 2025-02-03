using System;
using System.Collections.Generic;

public class LifeAffirmationsActivity : Activity
{
    private List<string> _affirmations = new List<string>
    {
        "I am strong and capable.",
        "I am worthy of love and respect.",
        "I can achieve my goals.",
        "I am confident and self-assured.",
        "I am grateful for the good things in my life.",
        "I am resilient and can overcome challenges.",
        "I am deserving of happiness and success.",
        "I am proud of who I am."
    };

    public LifeAffirmationsActivity() : base("Life Affirmations", "This activity will help you build a positive mindset by affirming positive statements about yourself. Focus on each affirmation and believe in its truth.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string affirmation = _affirmations[random.Next(_affirmations.Count)];
            Console.WriteLine(affirmation);
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }
}
