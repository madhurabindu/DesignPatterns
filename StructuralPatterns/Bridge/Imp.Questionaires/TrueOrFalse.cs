using Imp.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imp.Questionaires
{
    public class TrueOrFalse : MCQ
    {
        public static class Const
        {
            public static string True = "TRUE";
            public static string False = "FALSE";
        }
        public TrueOrFalse()
        {
            AnswerChoices = new List<string> { Const.True, Const.False };
        }

        public void SetAnswer(string ans)
        {
            Answer = new Answer(ans);
        }
    }
}
