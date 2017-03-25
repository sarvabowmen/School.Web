using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class UserSections
    {
        public int StudentID { get; set; }

        public int GradeSectionID { get; set; }

        public GradeSection GradeSection { get; set; }

        public User Student { get; set; }

        public int SchoolYear { get; set; }
    }
}
