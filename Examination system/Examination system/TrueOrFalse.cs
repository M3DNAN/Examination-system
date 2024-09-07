using Examination_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(string theQuestion = "unknown", string answer = "unknown", int markOfQ = 0) : base(theQuestion, answer, markOfQ)
        { }

        public override string Display()
        {
            return $"{TheQuestion}? \n(T) true or (F) False ";
        }

        public override Boolean Check(string AformStudent)
        {
            if (Answer.ToLower() == AformStudent)
            { return true; }
            else { return false; }
        }
    }
}