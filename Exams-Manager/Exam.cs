using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal abstract class Exam
    {
        private QuestionsList<IQuestion> questions;
        private Subject subject;
        private int mark;

        public int Mark { get => mark; set => mark = value; }
        internal QuestionsList<IQuestion> Questions { get => questions; set => questions = value; }
        internal Subject Subject { get => subject; set => subject = value; }
    }
}
