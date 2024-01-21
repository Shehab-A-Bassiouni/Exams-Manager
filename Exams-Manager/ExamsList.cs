using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class ExamsList<Exam>:List<Exam>
    {

        public new void Add(Exam exam) {
            base.Add(exam);
        }

    }
}
