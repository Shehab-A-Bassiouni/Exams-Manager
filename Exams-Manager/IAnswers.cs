﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Manager
{
    internal interface IAnswers
    {
        string RightAnswer { get; set; }
        public string[] Options { get; set; }
    }
}
