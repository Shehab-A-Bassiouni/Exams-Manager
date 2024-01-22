namespace Exams_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Exam> list = new List<Exam>(); 
            int size = 1;
            for (int i = 0; i < size ; i++) {
                list.Add(Generation.AddExam());

                Console.WriteLine("---------------------------");

                Generation.AddQuestionsToExam(list[i]);


                Console.WriteLine("---------------------------");

            }

            StudentAnswerExam std = new(list[0]);
           int mark = Generation.AssignExamAndAnswer( std,list[0]);

            Console.WriteLine($"Your mark is {mark}");



        }
    }
}
