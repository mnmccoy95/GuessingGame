using System;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessAmount = 0;
            Play(guessAmount);
        }

        static void Play(int guesses)
        {
            Console.WriteLine("~Welcome to Secret Number Game~");

            while(guesses < 3)
            {
            Console.Write("Guess a Number! : ");
            string answer = Console.ReadLine();
            int answerInt;
            bool isNumber = int.TryParse(answer, out answerInt);
            int secretNumber = 42;

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

        static void Compare(int userNum, int secretNum)
        {
            if(userNum == secretNum)
            {
                Console.WriteLine($"YOOOO YOU GOT IT!! {secretNum}!!!");
            }
            else
            {
                Console.WriteLine("that ain't it, fam :(");
            }
        }
    }
}
