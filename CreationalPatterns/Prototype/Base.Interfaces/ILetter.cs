using System;

namespace Base.Interfaces
{
    public interface ILetter : ICloneable
    {
        string FromName { get; set; }
        string ToName { get; set; }
        string[] FromAddress { get; set; }
        string[] ToAddress { get; set; }
        string Date { get; set; }
        string Place { get; set; }
        string ToGender { get; set; }

        string Title { get; set; }
        string Subject { get; set; }
        string MatterText { get; set; }

        string HTMLTemplate { get; }

        void PopulateHTML();
    }
}
