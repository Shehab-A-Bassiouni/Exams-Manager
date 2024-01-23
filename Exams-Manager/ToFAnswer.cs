using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class ToFAnswer:IAnswers
    {

        public List<string> RightAnswer { get; set; }
        public List<string> Options { get; set; }

        public ToFAnswer() {
            Options = new();
            RightAnswer = new();
        }
    }
}
