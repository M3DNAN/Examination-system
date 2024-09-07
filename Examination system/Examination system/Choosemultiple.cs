using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class ChooseMultiple:Question
    {
        public string Answer2 { get; set; }
        List<string> choices = new List<string>();
        public ChooseMultiple(string theQuestion = "unknown", string answer = "unknown", string answer2 = "unknown", int markOfQ = 0) : base(theQuestion, answer, markOfQ)
        {
            Answer2 = answer2;
        }

        public void AddChoices()
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Enter the Choice number {i} :");
                string choice = Console.ReadLine();
                choices.Add(choice);

                choices.Add(Answer);
                choices.Add(Answer2);

                Random rnd = new Random();
                choices.Sort((a, b) => rnd.Next(-1, 1));
            }
        }
        public override string Display()
        {
            return $" choose one or more of the following:\n{TheQuestion} ?" +
                   $"\nA- {choices[0]}\n" +
                   $"B- {choices[1]}\n" +
                   $"C- {choices[2]}\n" +
                   $"D- {choices[3]}";
        }
        public override Boolean Check(string AformStudent)
        {
            if (Answer.ToLower() == AformStudent)
            { return true; }
            else { return false; }
        }

    }
}

