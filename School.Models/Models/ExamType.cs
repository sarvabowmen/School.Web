using System;
using System.Collections.Generic;

namespace School.Models
{
    public class ExamType
    {
        public int ExamTypeID { get; set; }

        public string ExamTypeName { get; set; }

        public string ExamTypeDesc { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
