using System;
using System.Collections.Generic;
using Base.Interfaces;

namespace Imp.Questionaires
{
    public class MCQ : IQuestion
    {
        protected Questions.QType type;
        public Questions.QType Type { get { return type; } set { } } 
        public string QuestionText { get; set; }
        public string Subject { get; set; }
        public IAnswer Answer { get; set; }
        public IList<string> AnswerChoices { get; set; }

        public MCQ()
        {
            Type = Questions.QType.MCQ;
        }
    }
}
