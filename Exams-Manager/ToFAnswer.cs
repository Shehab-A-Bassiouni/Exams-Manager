using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class ToFAnswer:IAnswers
    {

        public string RightAnswer { get; set; }
        public string[] Options { get; set; }

        public ToFAnswer() {
            Options = new string[2];
        }
    }
}
