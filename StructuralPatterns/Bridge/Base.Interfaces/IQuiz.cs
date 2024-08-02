using System;
using System.Collections.Generic;

namespace Base.Interfaces
{
    public interface IQuiz
    {
        Quizzes.QuizType Type { get; set; }
        IList<IQuestion> Questions { get; set; }

        IQuizResult TakeQuiz();
    }

    public class Quizzes
    {
        public enum QuizType { Scored, Trivia, TrueFalse };
    }
}
