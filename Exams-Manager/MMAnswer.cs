using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class MMAnswer:IAnswers
    {
        public string RightAnswer { get; set; }
        public string[] Options { get; set; }

        public string[] RightAnswers { get; set; }

        public MMAnswer() {
            Options = new string[4];
        }


    }
}
