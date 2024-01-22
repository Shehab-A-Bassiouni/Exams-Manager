﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal class ToFQuestion : IQuestion
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public IAnswers Answer { get; set; }
        public int Mark { get; set; }


        public ToFQuestion() {
            Answer = new ToFAnswer();
        }
    }


}
