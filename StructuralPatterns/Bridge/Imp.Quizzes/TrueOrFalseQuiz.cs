using System;
using System.Collections.Generic;
using Base.Interfaces;
using Imp.Answers;
using Imp.Questionaires;
using BI=Base.Interfaces;

namespace Imp.Quizzes
{
    public class TrueOrFalseQuiz : IQuiz
    {
        public BI.Quizzes.QuizType Type { get; set; }
        public IList<IQuestion> Questions { get; set; }

        public TrueOrFalseQuiz()
        {
            FillQuestions();
        }

       

        public IQuizResult TakeQuiz()
        {
            IQuizResult result = new QuizResult() { NumberOfQuestions = Questions.Count, Attempted = 0, CorrectAnswer = 0 };

            foreach (var item in Questions)
            {
                bool val = AskQuestion(item);

                if (val) { result.Attempted++; result.CorrectAnswer++; }

            }
            return null;
        }

        private bool AskQuestion(IQuestion question)
        {
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n{0}", question.QuestionText);
            foreach (var item in question.AnswerChoices)
            {
                Console.WriteLine("\t - {0}", item);
            }

            string ans = Console.ReadLine();
            bool val = question.Answer.CompareNoCase(new Answer(ans));
            string output = val ? "\nThats Correct!!" : "Sorry the aswer is " + question.Answer.RightAnswer;
            Console.ForegroundColor = val ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine("{0}", output, Console.ForegroundColor);
            Console.WriteLine();
            Console.ForegroundColor = temp;
            return val;
        }

        private void FillQuestions()
        {
            Questions = new List<IQuestion>();

            TrueOrFalse qn = new TrueOrFalse();
            qn.QuestionText = "Blue Whale is the Largest Living Creature on Planet Earth";
            qn.Subject = "Animals";
            qn.SetAnswer(TrueOrFalse.Const.True);
            Questions.Add(qn);
        }

    }
}
