using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class MMAnswer:IAnswers
    {
        public List<string> Options { get; set; }

        public List<string> RightAnswer { get; set; }

        public MMAnswer() {
            Options = new();
            RightAnswer = new();
        }


    }
}
