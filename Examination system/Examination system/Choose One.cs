using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Choose_One : Question
    {
        List<string> choices = new List<string>();
        public Choose_One(string theQuestion = "unknown", string answer = "unknown", int markOfQ = 0) : base(theQuestion, answer, markOfQ)
        { }

        public void AddChoices()
        {
            choices = new List<string>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter the Choice number {i} :");
                string choice = Console.ReadLine();
                choices.Add(choice);
            }
            choices.Add(Answer);
            Random rnd = new Random();
            choices.Sort((a, b) => rnd.Next(-1, 2));
        }

        public override string Display()
        {
            return $" Choose one of the following:\n{TheQuestion} ?" +
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
