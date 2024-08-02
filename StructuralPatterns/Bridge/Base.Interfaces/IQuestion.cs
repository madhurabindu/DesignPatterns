using System;
using System.Collections.Generic;

namespace Base.Interfaces
{
    public interface IQuestion
    {
        Questions.QType Type { get; set; }
        string QuestionText { get; set; }
        string Subject { get; set; }
        IAnswer Answer { get; set; }

        IList<string> AnswerChoices { get; set; }
    }

    public class Questions
    {
        public enum QType { Simple, MCQ, FIB, Descriptive, Essay };
        public static class Subjects
        {
            public static string Geography = "geo";
            public static string GeneralKnowledge = "gk";
            public static string CurrentAffairs = "ca";
            public static string Sports = "gm";
        }
    }
}
