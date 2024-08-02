using System;
using System.IO;
using Base.Interfaces;
using cnst = Base.Interfaces.PlaceholderConstants;
namespace Imp.Letters
{
    public class GenericLetter : ILetter
    {
        public string FromName { get; set; }
        public string ToName { get; set; }
        public string[] FromAddress { get; set; }
        public string[] ToAddress { get; set; }
        public string Date { get; set; }
        public string ToGender { get; set; }

        public string Title { get; set; }
        public string Subject { get; set; }
        public string MatterText { get; set; }
        public string Place { get; set; }
        public string HTMLTemplate { get; set; }

        public GenericLetter()
        {
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void PopulateHTML()
        {
            string sourceHtml = HTMLTemplate;
            string toTitle = ToGender == "Male" ? "Mr." : "Ms.";
            sourceHtml = sourceHtml.Replace(cnst.AddresseTitle, toTitle);
            sourceHtml = sourceHtml.Replace(cnst.Title, Title);
            sourceHtml = sourceHtml.Replace(cnst.Subject, Subject);
            sourceHtml = sourceHtml.Replace(cnst.FromName, FromName);
            sourceHtml = sourceHtml.Replace(cnst.FromAddr1, FromAddress[0]);
            sourceHtml = sourceHtml.Replace(cnst.FromAddr2, FromAddress[1]);
            sourceHtml = sourceHtml.Replace(cnst.FromAddr3, FromAddress[2]);

            sourceHtml = sourceHtml.Replace(cnst.AddresseName, ToName);
            sourceHtml = sourceHtml.Replace(cnst.ToAddr1, ToAddress[0]);
            sourceHtml = sourceHtml.Replace(cnst.ToAddr2, ToAddress[1]);
            sourceHtml = sourceHtml.Replace(cnst.ToAddr3, ToAddress[2]);

            sourceHtml = sourceHtml.Replace(cnst.Date, Date);
            sourceHtml = sourceHtml.Replace(cnst.Place, Place);
            HTMLTemplate = sourceHtml;

        }

    }
}
