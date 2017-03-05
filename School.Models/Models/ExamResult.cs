using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models.Models
{
    public class ExamResult
    {
        public int ExamId { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public int Marks { get; set; }


    }
}
