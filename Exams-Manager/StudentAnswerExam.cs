using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class StudentAnswerExam
    {
        public Exam Exam { get; set; }

        public Dictionary<IQuestion, List<string>> QA { get; set;}

        public StudentAnswerExam(Exam _Exam) {
            Exam = _Exam;
            QA = new();
        }
    }
}
