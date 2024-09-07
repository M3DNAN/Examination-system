namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExamSystem examSystem = new ExamSystem();
 
            string input = "";
      
            do
            {
                Console.WriteLine("student or teacher?");
                input = Console.ReadLine();
                if (input.ToLower().Contains("teacher"))
                {
                    examSystem.MakeExam();
                    string input2 = "";
                    do
                    {
                        Console.WriteLine("do you want to make an exam? (y) yes / press any thing to escape");
                        input2 = Console.ReadLine();
                        if (input2 == "y" || input2 == "Y")
                        {
                            examSystem.MakeExam();
                        }
                        else { Console.WriteLine("---thank you, teacher "); }
                    }
                    while (input2 == "y" || input2 == "Y");
                }
                else if (input.ToLower().Contains("student"))
                {
                    Console.WriteLine("Are you ready to start exam? (y) yes");
                    string inputstudent = Console.ReadLine();
                    if (inputstudent == "y" || inputstudent=="Y" )
                    {
                        if (examSystem.Exams.Count == 0)
                        { Console.WriteLine("---there is no exams yet"); }
                        else
                        {
                            examSystem.TakeExam();
                        }
                    }
                }
                // unknown input
                else { Console.WriteLine("---not valid answer"); }

            } while (input.ToLower().Contains("student") || input.ToLower().Contains("teacher"));


        }
    }
}
    


