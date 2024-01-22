using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class MultiAnswer : IAnswers
    {
        public string RightAnswer { get; set; }
        public string[] Options { get; set; }

        public MultiAnswer() {
            Options = new string[4];
        }
    }
}
