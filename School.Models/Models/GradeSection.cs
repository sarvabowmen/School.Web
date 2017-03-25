using System;
using System.Collections.Generic;

namespace School.Models
{
     public class GradeSection
    {
        public int GradeSectionID { get; set; }

        public string SectionName { get; set; }

        public bool Status { get; set; }

        public int GradeID { get; set; }

        public Grade Grade { get; set; }

        public ICollection<UserSections> GradeSections { get; set; }
    }
}
