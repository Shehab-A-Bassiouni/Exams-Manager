namespace Exams_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 2;
            for (int i = 0; i < size ; i++) {
                Exam exam = Generation.AddExam();

                Console.WriteLine("---------------------------");

                Generation.AddQuestionsToExam(exam);

                Console.WriteLine("---------------------------");

            }



        }
    }
}
