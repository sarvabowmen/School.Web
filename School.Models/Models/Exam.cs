﻿using System;

namespace School.Models
{
    public class Exam
    {
        public int ExamId { get; set; }

        public int ExamTypeId { get; set; }

        public string ExamName { get; set; }

        public DateTime StartDate { get; set; }
    }
}
