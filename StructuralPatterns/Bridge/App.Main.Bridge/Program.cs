using System;
using System.Threading;
using Base.Interfaces;
using Imp.Quizzes;

namespace App.Main.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nLets Take a Spin The Wheel Quiz.....");
            Thread.Sleep(1500);
            IQuiz quiz = new SpinTheWheelQuiz();
            quiz.TakeQuiz();
            Console.WriteLine();


            Console.WriteLine("Lets Take a TRUE or FALSE Quiz.....");
            IQuiz quiz2 = new TrueOrFalseQuiz();
            quiz2.TakeQuiz();
            Console.WriteLine();
        }
    }
}
