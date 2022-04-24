using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Anchie";

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("Let's Play!\nGuess the number from 1 to 10...");

            Console.WriteLine("What's your name?");
            
            string inputName = Console.ReadLine();

            Console.WriteLine("Nice to meet you, {0}! What's your guess?", inputName);


            while (true)
            {

                Random random = new Random();

                int guess = 0;

                int correctNumber = random.Next(0, 11);

                while (guess != correctNumber)
                {

                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Please enter an actual number.");

                        Console.ResetColor();

                        continue;

                    }
                    guess = Int32.Parse(input);



                    if (guess != correctNumber)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Wrong guess, please try again.");

                        Console.ResetColor();

                    }
                }


                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("YOU WIN!!! You guessed the number!");

                Console.ResetColor();


                Console.WriteLine("Would you like to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    Console.WriteLine("Sounds good! Hit enter to play again...");
                    continue;

                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
    }
}
