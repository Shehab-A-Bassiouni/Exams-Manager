﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class PracticalExam:Exam
    {
        public PracticalExam() {

            Questions = new();
            Subject = new();
        }
    }
}
