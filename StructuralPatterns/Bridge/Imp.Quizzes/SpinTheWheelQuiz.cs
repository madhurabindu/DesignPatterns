using System;
using System.Collections.Generic;
using Base.Interfaces;
using Imp.Answers;
using Imp.Questionaires;
using BI = Base.Interfaces;

namespace Imp.Quizzes
{
    public class SpinTheWheelQuiz : IQuiz
    {
        private IList<string> subjects;

        public BI.Quizzes.QuizType Type { get; set; }
        public IList<BI.IQuestion> Questions { get; set; }

        public SpinTheWheelQuiz()
        {
            FilleQuestions();
        }

        public IQuizResult TakeQuiz()
        {
            IQuizResult result = new QuizResult() { NumberOfQuestions = Questions.Count, Attempted = 0, CorrectAnswer=0 };
            SpinWheelQuizMaster master = new SpinWheelQuizMaster();
            string subject = master.SpinWheel(subjects);

            IQuestion qn = FindQuestion(subject);
            bool val = master.AskQuestion(qn);

            if (val) { result.Attempted++; result.CorrectAnswer++; }

            return result;
        }

        private IQuestion FindQuestion(string subject)
        {
            // find a question for a subject
            // For Sample just returning one of the questions
            Questions[0].Subject = subject;
            return Questions[0];
        }

        private void FilleQuestions()
        {
            // This could be reading the question from a database..
            Questions = new List<IQuestion>();

            IQuestion qn = new MCQ()
            {
                QuestionText = "How Heavy Is a Whale? (in LB)",
                AnswerChoices = new List<string> { "120", "30", "176" },
                Answer = new Answer("176"),
                Subject = ""
            };

            Questions.Add(qn);

            subjects = new List<string>() { "Aquatic", "BlueWhale", "Under Water", "Sea Creatures", "New Era Creatures" };
        }
    }
}
