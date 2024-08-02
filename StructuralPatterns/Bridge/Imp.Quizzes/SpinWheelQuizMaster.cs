using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Base.Interfaces;
using Imp.Answers;

namespace Imp.Quizzes
{
    public class SpinWheelQuizMaster
    {
        private bool wheelStopped = false;

        public string SpinWheel(IList<string> subjects)
        {
            int selected = DisplaySpinWheel(subjects);
            return subjects[selected];
        }
        public bool AskQuestion(IQuestion question)
        {
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYou Selected the Subject {0}\n", question.Subject, Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}", question.QuestionText);
            foreach (var item in question.AnswerChoices)
            {
                Console.WriteLine("\t - {0}", item);
            }
            string ans = Console.ReadLine();

            var val =  question.Answer.CompareNoCase(new Answer(ans));
            string output = val ? "\nThats Correct!!" : "Sorry the aswer is " + question.Answer.RightAnswer;
            Console.ForegroundColor = val ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine("{0}", output, Console.ForegroundColor);

            Console.ForegroundColor = temp;
            return val;
        }

        private int DisplaySpinWheel(IList<string> subjects)
        {
            Console.WriteLine("\nOn Pressing a Key the Wheel will start spinning.");
            Console.ReadKey();
            Console.WriteLine("\nPress Any key to Stop spinning the wheel\n");

            PeekInput();
            int selected = 0;
            while (!wheelStopped)
            {
                for (int i = 0; i < subjects.Count; i++)
                {
                    Console.WriteLine("-------- {0} : {1}------------", "[x]", subjects[i]);
                    selected = i;
                    Thread.Sleep(1000);
                    if (wheelStopped)
                    {
                        break;
                    }
                }
            }
            return selected;
        }

        private void PeekInput()
        {
            Task.Factory.StartNew((Object obj) => {
                Console.ReadKey();
                lock (this)
                {
                    wheelStopped = true;
                }
            }, null);
        }
    }
}
