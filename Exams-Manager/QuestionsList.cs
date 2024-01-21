using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class QuestionsList<IQuestion> : List<IQuestion>
    {
        public new void Add(IQuestion question) {
            base.Add(question);
        }
    }
}
