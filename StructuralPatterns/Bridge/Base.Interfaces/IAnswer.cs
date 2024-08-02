using System;
using System.Collections.Generic;

namespace Base.Interfaces
{
    public interface IAnswer
    {
        string RightAnswer { get; set; }
        bool Compare(IAnswer another);
        bool CompareNoCase(IAnswer another);
    }
}
