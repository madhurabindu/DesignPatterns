using Base.Interfaces;
using System;

namespace Imp.Quizzes
{
    public class QuizResult : IQuizResult
    {
        public int NumberOfQuestions { get; set; }
        public int Attempted { get; set; }
        public int CorrectAnswer { get; set; }

    }
}
