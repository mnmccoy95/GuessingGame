using System;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Play();
        }

        static void Play()
        {
            Console.WriteLine("~Welcome to Secret Number Game~");
            Console.Write("Guess a Number! : ");
            string answer = Console.ReadLine();
            int answerInt;
            bool isNumber = int.TryParse(answer, out answerInt);

            while(!isNumber)
            {
                Console.Write("Guess a Number! : ");
                answer = Console.ReadLine();
                isNumber = int.TryParse(answer, out answerInt);
            }

            if(isNumber == true)
            {
                Console.WriteLine($"Your Guess: {answerInt}");
            }

        }
    }
}
