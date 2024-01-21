using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class Exam
    {
        private QuestionsList<IQuestion> questions;

        internal QuestionsList<IQuestion> Questions { get => questions; set => questions = value; }

        public Exam(QuestionsList<IQuestion> _questions)
        {
            questions = _questions;
        }
    }
}
