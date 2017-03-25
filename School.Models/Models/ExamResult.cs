using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class ExamResult
    {
        [Key, Column(Order = 1)]
        public int ExamID { get; set; }

        [Key, Column(Order = 2)]
        public int StudentID { get; set; }

        [Key, Column(Order = 3)]
        public int CourseID { get; set; }

        public int Marks { get; set; }


    }
}
