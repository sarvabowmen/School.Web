using System;
using System.Collections.Generic;

namespace School.Models
{
     public class Grade
    {
        public int GradeID { get; set; }

        public string GradeName { get; set; }

        public string GradeDesc { get; set; }

        public ICollection<Course> Courses { get; set; }

        public ICollection<GradeSection> GradeSections { get; set; }
    }
}
