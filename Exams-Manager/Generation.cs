using System;
using System.Linq;
using System.Security.AccessControl;

namespace Exams_Manager
{
    internal static class Generation
    {

        // Add Exam
        public static Exam AddExam()
        {
            Console.WriteLine("Enter Exam Subject");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter Exam Type : P/F");
            string examType = Console.ReadLine();

            Console.WriteLine("Enter Exam Mark ");
            int mark = int.Parse(Console.ReadLine());

            Exam exam;

            if (examType == "F")
                exam = new FinalExam();
            else
                exam = new PracticalExam();

            exam.Subject.Name = subject;
            exam.Mark = mark;
            return exam;
        }

        // ADD Question To Exam
        public static void AddQuestionsToExam(Exam exam) {
            IQuestion q;
            Console.WriteLine("Enter Question Type : M/TF");

            string ans = Console.ReadLine();

            if (ans == "M")
            {
                q = new MultiQuestion();
            }
            else {
                q = new ToFQuestion();
            } 

            Console.WriteLine("Enter Question header");
            q.Header = Console.ReadLine();
            Console.WriteLine("Enter Question Body");
            q.Body = Console.ReadLine();
            Console.WriteLine("Enter Question Mark");
            q.Mark = int.Parse(Console.ReadLine());


            if (ans == "M")
            {
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine($"Enter Question Option {i}");
                    q.Answer.Options[i - 1] = Console.ReadLine();
                }
            }

            else {
                q.Answer.Options[0] = "true";
                q.Answer.Options[1] = "false";

            }

            Console.WriteLine("Enter Question Correct Answer");
            q.Answer.RightAnswer = Console.ReadLine();

            exam.Questions.Add(q);

        }

        public static int AssignExamAndAnswer(StudentAnswerExam sae , Exam exam) {

            sae.Exam = exam;


            foreach (var x in exam.Questions) {
                Console.WriteLine("Answer The Following Questions");

                Console.WriteLine(x.Header);
                Console.WriteLine(x.Body);

                Console.WriteLine("Options Are :");

                foreach (var y in x.Answer.Options) {
                    Console.WriteLine(y);
                }

                sae.QA[x] = Console.ReadLine();

            }
            int marks = 0;
            foreach (var x in sae.QA) {
                if (x.Key.Answer.RightAnswer == x.Value) marks++;
            }
            return marks;
        }
    }
}


