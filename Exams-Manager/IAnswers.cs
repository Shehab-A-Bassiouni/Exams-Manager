using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal interface IAnswers
    {
        List<string> RightAnswer { get; set; }
        public List<string> Options { get; set; }
    }
}
