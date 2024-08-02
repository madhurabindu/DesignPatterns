using Base.Interfaces;
using Imp.Letters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Main.Prototype
{
    public class LetterGenerator
    {
        Dictionary<string, ILetter> templates = new Dictionary<string, ILetter>();
        public LetterGenerator()
        {

            GenericLetter offer = new GenericLetter(){
                Title = "Offer Letter",
                Subject = "Confirmation of Employment",
                Place = "Bangalore"
            };

            offer.HTMLTemplate = File.ReadAllText("EmpLetterTemplate.html");
            templates["Offer Letter"] = offer;


            GenericLetter promo = new GenericLetter()
            {
                Title = "Promotion Letter",
                Subject = "Promotion / Change Of Designation Communication",
                Place = "Netherlands"
            };

            promo.HTMLTemplate = File.ReadAllText("PromoLetterTemplate.html");
            templates["Promotion Letter"] = promo;
        }

        internal ILetter GetLetterForType(string letterType)
        {
            ILetter letter = null;
            if (!string.IsNullOrEmpty(letterType))
            {
                if (templates.ContainsKey(letterType))
                {
                    letter = (ILetter)templates[letterType].Clone();
                }
            }

            return letter;
        }


        internal string GenerateLeter(ILetter details)
        {
            details.PopulateHTML();

            return details.HTMLTemplate;


        }



    }
}
