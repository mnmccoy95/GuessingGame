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
            int secretNumber = Number();
            Console.WriteLine(secretNumber);
            int answerInt = 0;

            while(guesses < 3 && secretNumber != answerInt)
            {
            Console.Write($"Guess a Number! Chances Left({3 - guesses}) : ");
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
            }
        }
    }
}
