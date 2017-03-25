using School.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace School.Data
{
    public class CourseConfiguration: EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            ToTable("Course");
            HasKey(u => u.CourseID);

            HasRequired(t => t.Grade).WithMany(c => c.Courses).HasForeignKey
         (t => t.CourseID).WillCascadeOnDelete(false);
        }
    }
}
