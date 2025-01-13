using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess = 0;

        
        while (guess != magicNumber)
        {
            
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}