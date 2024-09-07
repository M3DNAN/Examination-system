using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class ExamSystem
    {
        public List<Exam> Exams { get; set; } = new List<Exam>() { };

        public void MakeExam()
        {
            Console.WriteLine("How many question you want ?");
            int numOfQ = int.Parse(Console.ReadLine());
            Exam exam = new Exam(numOfQ);
            for (int i = 0; i < numOfQ; i++)
            {
                Console.WriteLine("type of question you want \n1. True or False question \n2. choose one question \n3. multiple chooses question");
                int typeOfQ = int.Parse(Console.ReadLine());
                if (typeOfQ == 1)
                {
                    Console.WriteLine("Enter the question");
                    string theQuestion = Console.ReadLine();

                    Console.WriteLine("What is the question mark");
                    int markOfQ = int.Parse(Console.ReadLine());
                    exam.Totalgrade += markOfQ;
                    string answer = "";
                    do
                    {
                        Console.WriteLine("Enter the Answer (T / F)");
                        answer = Console.ReadLine();

                        if (answer == "T" || answer == "t" || answer == "f" || answer == "F")
                        {
                            Console.WriteLine("Your question is added successfully ");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a correct answer");
                        }
                    } while (answer != "T" && answer != "t" && answer != "f" && answer != "F");
                    Question question1 = new TrueOrFalse(theQuestion, answer, markOfQ);
                    exam.Addquestion(question1);

                }
                else if (typeOfQ == 2)
                {
                    Console.WriteLine("Enter the question");
                    string theQuestion = Console.ReadLine();

                    Console.WriteLine("What is the question mark");
                    int markOfQ = int.Parse(Console.ReadLine());
                    exam.Totalgrade += markOfQ;
                    Console.WriteLine("Enter the Answer");
                    string answer = Console.ReadLine();
                    Choose_One question2 = new Choose_One(theQuestion, answer, markOfQ);
                    question2.AddChoices();
                    exam.Addquestion(question2);

                }
                else if (typeOfQ == 3)
                {
                    Console.WriteLine("Enter the question");
                    string theQuestion = Console.ReadLine();

                    Console.WriteLine("What is the question mark");
                    int markOfQ = int.Parse(Console.ReadLine());
                    exam.Totalgrade += markOfQ;
                    Console.WriteLine("Enter the Answer");
                    string answer = Console.ReadLine();
                    Console.WriteLine("Enter the the second Answer");
                    string answer2 = Console.ReadLine();
                    ChooseMultiple question3 = new ChooseMultiple(theQuestion, answer, answer2, markOfQ);
                    question3.AddChoices();
                    exam.Addquestion(question3);
                }
                else 
                {
                    Console.WriteLine("Please enter a correct answer");
                }
                    Exams.Add(exam);
            }
        }
        public void TakeExam()
        {
            DateTime currentDateTime = DateTime.Now;
            int grade = 0;
            Console.WriteLine("Please Enter Your Name");
            string studentName= Console.ReadLine();
            Random random = new Random();
            int randomIndex = random.Next(Exams.Count);

            Exam CurrentExam = Exams[randomIndex];
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"Current Date:{currentDateTime.ToString("yyyy-MM-dd")} ------------------ Current Time: {currentDateTime.ToString("HH:mm:ss")}");
            Console.WriteLine("------------------------------------------\n------------------------------------------");
            for (int i = 0; i < CurrentExam.Questions.Count; i++)
            {
                Console.WriteLine($"Q{i+1}"+" "+CurrentExam.Questions[i].Display());
                string AformStudent = Console.ReadLine();
                if (CurrentExam.Questions[i].Check(AformStudent.ToLower()))
                { grade += CurrentExam.Questions[i].MarkOfQ; }

         
            }
            Console.WriteLine("------------------------------------------\n------------------------------------------");
            Console.WriteLine($"{studentName} your result is {grade} from {CurrentExam.Totalgrade}");

        }

    }
    }
    
    

