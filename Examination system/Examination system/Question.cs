using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal abstract class Question
    {
        public Question(string theQuestion = "unknown", string answer = "unknown", int markOfQ = 0)
        {
            TheQuestion = theQuestion;
            MarkOfQ = markOfQ;
            Answer = answer;
        }

        public string TheQuestion { get; set; }
        public string Answer { get; set; }
        public int MarkOfQ { get; set; }

        public abstract string Display();
        public abstract Boolean Check(string A);
    }
}