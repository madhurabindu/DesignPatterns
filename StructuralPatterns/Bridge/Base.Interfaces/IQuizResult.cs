using System;

namespace Base.Interfaces
{
    public interface IQuizResult
    {
        int NumberOfQuestions { get; set; }
        int Attempted { get; set; }
        int CorrectAnswer { get; set; }
    }
}
