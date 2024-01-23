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
            Console.WriteLine("Enter Question Type : M/TF/MM");

            string ans = Console.ReadLine();

            if (ans == "M")
            {
                q = new MultiQuestion();
            }
            else if (ans == "MM") { 
                q = new MMQuestion();

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



            string options = "";

            Console.WriteLine("Enter Options");
            do
            {
                options = Console.ReadLine();
                if (options != "-1") {
                    q.Answer.Options.Add(options);
                }
            } while (options != "-1");
                               

            Console.WriteLine("Enter Question Correct Answer");

            string answ = "";

            do
            {
                answ = Console.ReadLine();
                if (answ != "-1")
                {
                    q.Answer.RightAnswer.Add(answ);
                }
            } while (answ != "-1");

            exam.Questions.Add(q);

        }

        public static int AssignExamAndAnswer(StudentAnswerExam sae , Exam exam) {

            sae.Exam = exam;


            foreach (var x in exam.Questions) {
                sae.QA.Add(x, new());
                Console.WriteLine("Answer The Following Questions");

                Console.WriteLine(x.Header);
                Console.WriteLine(x.Body);

                Console.WriteLine("Options Are :");

                foreach (var y in x.Answer.Options) {
                    Console.WriteLine(y);
                }

                Console.WriteLine("Answer");

                string answ="";

                do
                {
                     answ = Console.ReadLine();
                    if (answ != "-1") {
                        sae.QA[x].Add(answ);
                    }
                } while (answ != "-1");

                
            }
            int marks = 0;
            bool flag = true;
            foreach (var qa in sae.QA) {
                foreach (var ans in qa.Value) {
                    if (!qa.Key.Answer.RightAnswer.Contains(ans)) flag = false; ;
                }
                if (flag) marks += qa.Key.Mark;
            }
            
            return marks;
        }
    }
}


