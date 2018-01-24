using System;

namespace Bonus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int magicNumber = random.Next(0, 100);

            Console.WriteLine("Hello, we are about to play a guessing game!");
            Console.WriteLine("I'm thinking of a number 1 through 100!");
            NumberGame(magicNumber);

        }
        public static void NumberGame(int magicNumber)
        {
            Console.WriteLine("Try to guess!");
            bool guess = Int32.TryParse(Console.ReadLine(), out int magicGuess);
            if (guess == false)
            {
                Console.WriteLine("I dont know what you said, but your not right");
                NumberGame(magicNumber);
            }
            else if (magicGuess > magicNumber)
            {
                Console.WriteLine("Your number is too high");
                NumberGame(magicNumber);
            }
            else if (magicGuess < magicNumber)
            {
                Console.WriteLine("Your number is too low");
                NumberGame(magicNumber);
            }
            else if (magicGuess == magicNumber)
            {
                Console.WriteLine("Congratulations!!! You got the answer correct!");
                Console.WriteLine("Thanks for playing");
            }
            else
            {
                Console.WriteLine("I have no idea what you said");
                NumberGame(magicNumber);
            }

        }


    }
}
