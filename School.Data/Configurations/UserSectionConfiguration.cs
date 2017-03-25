using System;
using School.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace School.Data
{
    public class UserSectionConfiguration : EntityTypeConfiguration<UserSections>
    {
        public UserSectionConfiguration()
        {
            ToTable("UserSection");

            //relationship  
            HasRequired(t => t.GradeSection).WithMany(c => c.GradeSections).HasForeignKey
                    (t => t.GradeSectionID).WillCascadeOnDelete(false);

            //relationship  
            HasRequired(t => t.Student).WithMany(c => c.UserSections).HasForeignKey
                    (t => t.StudentID).WillCascadeOnDelete(false);


        }
    }
}
