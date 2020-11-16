using System;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessAmount = 0;
            int allowedGuesses = 0;
            Difficulty(allowedGuesses, guessAmount);
        }
        static void Difficulty(int allowedGuesses, int guesses)
        {
            Console.WriteLine(@"~Welcome to Secret Number Game~
            Choose Your Difficulty:
            1. Easy
            2. Medium
            3. Hard
            4. CHEATER!!");
            Console.Write("Difficulty: ");
            string difficultyChosen = Console.ReadLine();
            int difficultyInt = 0;
            bool isDiffNumber = int.TryParse(difficultyChosen, out difficultyInt);

            while(!isDiffNumber | difficultyInt > 4)
            {
                Console.Write("Difficulty: ");
                difficultyChosen = Console.ReadLine();
                isDiffNumber = int.TryParse(difficultyChosen, out difficultyInt);
            }

            if(isDiffNumber == true)
            {
                if(difficultyInt == 1)
                {
                    allowedGuesses = 8;
                    Play(guesses, allowedGuesses);
                }
                if(difficultyInt == 2)
                {
                    allowedGuesses = 6;
                    Play(guesses, allowedGuesses);
                }
                if(difficultyInt == 3)
                {
                    allowedGuesses = 4;
                    Play(guesses, allowedGuesses);
                }
                if(difficultyInt == 4)
                {
                    Cheater();
                }
            }

        }
        static void Play(int guesses, int allowedGuesses)
        {
            int secretNumber = Number();
            int answerInt = 0;

            while(guesses < allowedGuesses && secretNumber != answerInt)
            {
            Console.Write($"Guess a Number! Chances Left({allowedGuesses - guesses}) : ");
            string answer = Console.ReadLine();
            bool isNumber = int.TryParse(answer, out answerInt);

            while(!isNumber)
            {
                Console.Write("Guess a Number! : ");
                answer = Console.ReadLine();
                isNumber = int.TryParse(answer, out answerInt);
            }

            if(isNumber == true)
            {
                Compare(answerInt, secretNumber);
                guesses++;
            }
            }

        }

        static int Number() {
            Random r = new Random();
            int genRand= r.Next(1,101);
            return genRand;
        }

        static void Compare(int userNum, int secretNum)
        {
            if(userNum == secretNum)
            {
                Console.WriteLine($"YOOOO YOU GOT IT!! {secretNum}!!!");
            }
            else
            {
                Console.WriteLine("that ain't it, fam :(");
                if(userNum > secretNum)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Too low!");
                }
            }
        }

        static void Cheater()
        {
            int secretNumber = Number();
            int answerInt = 0;

            while(secretNumber != answerInt)
            {
            Console.Write("Guess a Number! Chances Left(∞) : ");
            string answer = Console.ReadLine();
            bool isNumber = int.TryParse(answer, out answerInt);

            while(!isNumber)
            {
                Console.Write("Guess a Number! : ");
                answer = Console.ReadLine();
                isNumber = int.TryParse(answer, out answerInt);
            }

            if(isNumber == true)
            {
                Compare(answerInt, secretNumber);
            }
            }

        }
    }
}
