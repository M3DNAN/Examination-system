using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Exam
    {
        public List<Question> Questions { get; set; } = new List<Question> { };
        public Exam( int numOfQ = 0, double totalgrade = 0)
        {
            Totalgrade = totalgrade;
            NumOfQ = numOfQ;
       
        }
      
        public double Totalgrade { get; set; }
        public int NumOfQ { get; set; }

        public void Addquestion(Question Q)
        {
            Questions.Add(Q);
        }
        public void DisplayQuestions()
        {
            foreach (Question item in Questions)
            {
                Console.WriteLine(item.Display());
            }
        }
    }
}
