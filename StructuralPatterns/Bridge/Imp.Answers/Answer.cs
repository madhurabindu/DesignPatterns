using System;
using System.Collections.Generic;
using Base.Interfaces;

namespace Imp.Answers
{
    public class Answer : IAnswer
    {
        public Answer(string ans)
        {
            RightAnswer = ans;
        }
        public string RightAnswer
        {
            get; set;
        }

        public bool Compare(IAnswer another)
        {
            return string.Compare(RightAnswer, another.RightAnswer, false) == 0;
        }

        public bool CompareNoCase(IAnswer another)
        {
            return string.Compare(RightAnswer, another.RightAnswer, true) == 0;
        }
    }
}
