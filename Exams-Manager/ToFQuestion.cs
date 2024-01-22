using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class ToFQuestion : IQuestion
    {
        public string Header { get => Header; set => Header = value; }
        public string Body { get => Body; set => Body = value; }
        public IAnswers Answer { get => Answer; set => Answer = value; }
        public int Mark { get => Mark; set => Mark=value; }


        public ToFQuestion() {
            Answer = new ToFAnswer();
        }
    }


}
