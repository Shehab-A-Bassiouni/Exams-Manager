using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class MultiQuestion : IQuestion
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public IAnswers Answer { get; set; }
        public int Mark { get; set; }


        public MultiQuestion()
        {
            Answer = new MultiAnswer();
        }
    }
}
